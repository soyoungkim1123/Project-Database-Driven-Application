using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UT = Library.UIUtilities;

namespace Library
{
    public partial class frmMaintenanceBook : Form
    {
        int currentBookId;

        int currentRecord;
        int firstBookId;
        int lastBookId;
        int numberOfBooks;
        int? previousBookId;
        int? nextBookId;

        bool createNewRecord;

        public frmMaintenanceBook()
        {
            InitializeComponent();
        }

        private void frmMaintenanceBook_Load(object sender, EventArgs e)
        {
            LoadCategory();
            GetFirstBook();
            NavigationButtonManagement();
        }

        #region Event

        /// <summary>
        /// clear all controls and change text in the update button when user click add button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ((mdiForm)this.MdiParent).StatusStipLabel.Text = "Adding a new book";
            ((mdiForm)this.MdiParent).StatusStipLabe2.Text = "";
            UT.ClearControls(grpBookInfo.Controls);

            LoadCategory();

            btnUpdate.Text = "Create";
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            createNewRecord = true;

            NavigationState(false);
        }

        /// <summary>
        /// display book detail again and enable buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadBookDetails();
            btnUpdate.Text = "Update";
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            createNewRecord = false;

            NavigationState(true);
            NavigationButtonManagement();
        }

        /// <summary>
        /// update data based on user change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    ProgressBar();

                    if (createNewRecord)
                    {
                        CreateBook();
                    }
                    else
                    {
                        SaveBookChanges();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Something is wrong with the data or database!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// call delete book method. prompt confirmation message box before delete.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are ou sure you wish to delete this book?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeleteBook();
            }
        }

        #endregion

        /// <summary>
        /// insert new record into book table
        /// </summary>
        #region NonQuery Exection
        private void CreateBook()
        {
            string sqlInsertBook = $@"
                                      INSERT INTO Book
                                      (
                                        ISBN,
                                        Title,
                                        Description,
                                        Edition,
                                        PublicateDate,
                                        Publisher,
                                        Price,
                                        Available,
                                        CategoryId
                                      )
                                      VALUES
                                      (
                                        {txtISBN.Text.Trim()},
                                        '{DataAccess.SQLFix(txtTitle.Text.Trim())}',
                                        '{DataAccess.SQLFix(txtDescription.Text.Trim())}',
                                        '{DataAccess.SQLFix(txtEdition.Text.Trim())}',
                                        '{dtpPublicateDate.Value}',
                                        '{DataAccess.SQLFix(txtPublisher.Text.Trim())}',
                                        {txtPrice.Text.Trim()},
                                        {(chkAvailable.Checked ? 1 : 0)},
                                        {cmbCategory.SelectedValue}
                                      )";

            sqlInsertBook = DataAccess.SQLCleaner(sqlInsertBook);

            if (IsSameBook())
            {
                int rowsAffected = DataAccess.ExecuteNonQuery(sqlInsertBook);
                if (rowsAffected == 1)
                {
                    MessageBox.Show("Book created");
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    btnUpdate.Text = "Update";
                    createNewRecord = false;
                    GetFirstBook();
                }

                else
                {
                    MessageBox.Show("The database reported no rows affected");
                }
            }
            
            NavigationState(true);
        }

        /// <summary>
        /// update existing record of book table
        /// </summary>
        private void SaveBookChanges()
        {
            string sqlUpdateBook = $@"
                                      UPDATE Book
                                      SET 
                                        ISBN = {txtISBN.Text.Trim()},
                                        Title = '{DataAccess.SQLFix(txtTitle.Text.Trim())}',
                                        Description = '{DataAccess.SQLFix(txtDescription.Text.Trim())}',
                                        Edition = '{DataAccess.SQLFix(txtEdition.Text.Trim())}',
                                        PublicateDate = '{dtpPublicateDate.Value}',
                                        Publisher = '{DataAccess.SQLFix(txtPublisher.Text.Trim())}',
                                        Price = {txtPrice.Text.Trim()},
                                        Available = {(chkAvailable.Checked ? 1 : 0)},
                                        CategoryId = {cmbCategory.SelectedValue}
                                      WHERE BookId = {currentBookId}";

            sqlUpdateBook = DataAccess.SQLCleaner(sqlUpdateBook);

            if (IsSameBook())
            {
                int rowsAffected = DataAccess.ExecuteNonQuery(sqlUpdateBook);
                if (rowsAffected == 1)
                {
                    MessageBox.Show("Book updated");
                }
                else
                {
                    MessageBox.Show("The database reported no rows affected.");
                }
            }
        }

        /// <summary>
        /// delete existing record in book table
        /// </summary>
        private void DeleteBook()
        {
            string sqlNumBookinList = $"SELECT BookId FROM BooksAuthors WHERE BookId = {currentBookId}";
            int numBookinList = Convert.ToInt32(DataAccess.GetValue(sqlNumBookinList));

            if(numBookinList == 0)
            {
                string sqlDeleteBook = $@"DELETE FROM Book WHERE BookId = {currentBookId}";

                int rowsAffected = DataAccess.ExecuteNonQuery(sqlDeleteBook);

                if (rowsAffected == 1)
                {
                    ProgressBar();
                    MessageBox.Show("Book deleted");
                    GetFirstBook();
                    NavigationButtonManagement();
                }
                else
                {
                    MessageBox.Show("The database reported no rows affected.");
                }
            }
            else
            {
                MessageBox.Show("This book could not be deleted because it belongs to author list");
            }
        }
        #endregion

        #region Retrieves

        /// <summary>
        /// fill the category combobox
        /// </summary>
        private void LoadCategory()
        {
            DataTable dtCategory = DataAccess.GetData("SELECT CategoryId, CategoryName FROM Category");
            UT.BindComboBox(cmbCategory, dtCategory, "CategoryName", "CategoryId");
        }

        /// <summary>
        /// retrieve first book and display information
        /// </summary>
        private void GetFirstBook()
        {
            currentBookId = Convert.ToInt32(DataAccess.GetValue("SELECT TOP(1) BookId FROM Book ORDER BY Title"));
            LoadBookDetails();
        }

        /// <summary>
        /// display book details and assign book id for navigation
        /// </summary>
        private void LoadBookDetails()
        {
            errProvider.Clear();

            string sqlBookById = $"SELECT * FROM Book WHERE BookId = '{currentBookId}' ORDER BY Title";

            string sqlNav = $@"
                                SELECT 
	                                (SELECT TOP(1) BookId FROM Book ORDER BY Title) AS FirstID,
	                                (SELECT TOP(1) BookId FROM Book ORDER BY Title DESC) AS LastID,
	                                q.PreviousID,
	                                q.NextID,
	                                q.RowNumber,
	                                (SELECT COUNT(*) FROM Book) AS NumOfBooks
                                FROM 
	                                (SELECT BookId, 
			                                Title, 
			                                LEAD(BookId) OVER (ORDER BY Title) AS NextID,
			                                LAG(BookId) OVER (ORDER BY Title) AS PreviousID,
			                                ROW_NUMBER() OVER (ORDER BY Title) As RowNumber
		                                FROM Book
	                                ) AS q
                                WHERE q.BookId = '{currentBookId}'
                                ORDER BY Title";

            string[] sqlStatements = new string[] { sqlBookById, sqlNav };
            DataSet ds = DataAccess.GetData(sqlStatements);

            DataRow selectedBook = ds.Tables["Table"].Rows[0];

            txtISBN.Text = selectedBook["ISBN"].ToString();
            txtTitle.Text = selectedBook["Title"].ToString();
            txtDescription.Text = selectedBook["Description"].ToString();
            txtEdition.Text = selectedBook["Edition"].ToString();
            dtpPublicateDate.Value = (DateTime)selectedBook["PublicateDate"];
            txtPrice.Text = Convert.ToDecimal(selectedBook["Price"]).ToString("N2");
            chkAvailable.Checked = (bool)selectedBook["Available"];
            cmbCategory.SelectedValue = selectedBook["CategoryId"];
            txtPublisher.Text = selectedBook["Publisher"].ToString();

            numberOfBooks = Convert.ToInt32(ds.Tables["Table1"].Rows[0]["NumOfBooks"]);
            firstBookId = Convert.ToInt32(ds.Tables["Table1"].Rows[0]["FirstID"]);
            lastBookId = Convert.ToInt32(ds.Tables["Table1"].Rows[0]["LastID"]);
            previousBookId = ds.Tables["Table1"].Rows[0]["PreviousID"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["PreviousID"]) : (int?)null;
            nextBookId = ds.Tables["Table1"].Rows[0]["NextID"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["NextID"]) : (int?)null;
            currentRecord = Convert.ToInt32(ds.Tables["Table1"].Rows[0]["RowNumber"]);

            DisplayCurrentPosition();
        }

        #endregion

        #region [Navigation Helpers]
        /// <summary>
        /// change the book ID for navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Navigation_Handler(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnFirst":
                    currentBookId = firstBookId;
                    break;
                case "btnLast":
                    currentBookId = lastBookId;
                    break;
                case "btnPrevious":
                    currentBookId = previousBookId.Value;

                    break;
                case "btnNext":
                    currentBookId = nextBookId.Value;
                    break;
            }

            LoadBookDetails();
            NavigationButtonManagement();
        }

        /// <summary>
        /// if there is no previous/next record, disable navigation buttons.
        /// </summary>
        private void NavigationButtonManagement()
        {
            btnPrevious.Enabled = previousBookId != null;
            btnNext.Enabled = nextBookId != null;
        }

        /// <summary>
        /// change nagivation buttons' enable status
        /// </summary>
        /// <param name="enableState"></param>
        private void NavigationState(bool enableState)
        {
            btnFirst.Enabled = enableState;
            btnLast.Enabled = enableState;
            btnNext.Enabled = enableState;
            btnPrevious.Enabled = enableState;
        }

        #endregion

        #region Helper
        /// <summary>
        /// display current position in the parent form
        /// </summary>
        private void DisplayCurrentPosition()
        {
            ((mdiForm)this.MdiParent).StatusStipLabel.Text = $"{currentRecord} of {numberOfBooks} books";
        }

        /// <summary>
        /// Animate the progrss bar
        /// This is UI thread blocking, however, that is ok for this application
        /// </summary>
        private void ProgressBar()
        {
            ((mdiForm)this.MdiParent).ProgressBar.Visible = true;
            ((mdiForm)this.MdiParent).StatusStipLabe2.Text = "Processing...";
            ((mdiForm)this.MdiParent).ProgressBar.Value = 0;

            while (((mdiForm)this.MdiParent).ProgressBar.Value < ((mdiForm)this.MdiParent).ProgressBar.Maximum)
            {
                Thread.Sleep(10);
                ((mdiForm)this.MdiParent).ProgressBar.Value += 1;
            }

             ((mdiForm)this.MdiParent).StatusStipLabe2.Text = "Processed";
            ((mdiForm)this.MdiParent).ProgressBar.Visible = false;
        }

        #endregion

        #region Validating
        /// <summary>
        /// ComboBox Validating Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            string cmbName = cmb.Tag.ToString();

            string errMsg = null;

            if (cmb.SelectedIndex == -1 || String.IsNullOrEmpty(cmb.SelectedValue.ToString()))
            {
                errMsg = $"{cmbName} is required";
                e.Cancel = true;
            }

            errProvider.SetError(cmb, errMsg);
        }

        /// <summary>
        /// TextBox Validating event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            string txtBoxName = txt.Tag.ToString();
            string errMsg = null;

            if (txt.Text == string.Empty)
            {
                errMsg = $"{txtBoxName} is required";
                e.Cancel = true;
            }

            else if (txt.Name == "txtISBN" || txt.Name == "txtPrice")
            {
                if (!IsNumeric(txt.Text))
                {
                    errMsg = $"{txtBoxName} is not numeric";
                    e.Cancel = true;
                }
            }

            errProvider.SetError(txt, errMsg);
        }

        /// <summary>
        /// validating if input is numeric
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool IsNumeric(string value)
        {
            return Double.TryParse(value, out double d);
        }

        /// <summary>
        /// check the same book exists in the table
        /// </summary>
        /// <returns></returns>
        private bool IsSameBook()
        {
            DataTable dt = DataAccess.GetData($"SELECT * FROM Book WHERE Title = '{txtTitle.Text}' AND Edition = '{txtEdition.Text}' AND PublicateDate = '{dtpPublicateDate.Value}'");
            DataTable dt2 = DataAccess.GetData($"SELECT * FROM Book WHERE ISBN = '{txtISBN.Text}'");

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("The same book exists in the DataBase.");
                return false;
            }

            if (dt2.Rows.Count > 0)
            {
                MessageBox.Show("The same ISBN exists in the Database. Please check the ISBN.");
                return false;
            }

            return true;

        }

        /// <summary>
        /// display overview in parent form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMaintenanceBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((mdiForm)this.MdiParent).RefreshParent();
        }

        #endregion

    }
}
