//Author : Soyoung Kim
//Date : 6/2/2020
//Purpose : Project-Database-Driven-Application

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
    public partial class frmMaintenanceAuthor : Form
    {
        int currentAuthorId;

        int currentRecord;
        int firstAuthorId;
        int lastAuthorId;
        int numberOfAuthors;
        int? previousAuthorId;
        int? nextAuthorId;

        bool createNewRecord;

        public frmMaintenanceAuthor()
        {
            InitializeComponent();
        }

        private void frmMaintenanceAuthor_Load(object sender, EventArgs e)
        {
            LoadCategory();
            GetFirstAuthor();
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
            try
            {
                ((mdiForm)this.MdiParent).StatusStipLabel.Text = "Adding a new author";
                ((mdiForm)this.MdiParent).StatusStipLabe2.Text = "";
                UT.ClearControls(grpAuthorInfo.Controls);
                UT.ClearControls(grpCareer.Controls);
                UT.ClearControls(grpPublishedWork.Controls);

                rdoMale.Checked = true;

                LoadCategory();

                btnUpdate.Text = "Create";
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                createNewRecord = true;

                NavigationState(false);

                grpPublishedWork.Enabled = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
           
        }

        /// <summary>
        /// display author detail again and enable buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                LoadAuthorDetails();
                btnUpdate.Text = "Update";
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                createNewRecord = false;

                NavigationState(true);
                NavigationButtonManagement();
                grpPublishedWork.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
           
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
                        CreateAuthor();
                    }

                    else
                    {
                        SaveAuthorChanges();
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
        /// call delete author method. prompt confirmation message box before delete.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are ou sure you wish to delete this author?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DeleteAuthor();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        #endregion

        #region NonQuery Exection
        /// <summary>
        /// insert new record into author table
        /// </summary>
        private void CreateAuthor()
        {
            string middleName = txtMiddleName.Text.Trim() == "" ? "NULL" : "'" + txtMiddleName.Text.Trim() + "'";
            string award = txtAward.Text.Trim() == "" ? "NULL" : "'" + DataAccess.SQLFix(txtAward.Text.Trim()) + "'";

            string sqlInsertBook = $@"
                                      INSERT INTO Author
                                      (
                                        FirstName,
                                        LastName,
                                        MiddleName,
                                        Gender,
                                        Award,
                                        ContactNumber,
                                        NumOfBooks,
                                        MainCategory
                                      )
                                      VALUES
                                      (
                                        '{txtFirstName.Text.Trim()}',
                                        '{txtLastName.Text.Trim()}',
                                        {middleName},
                                        '{(rdoFemale.Checked == true ? 'F' : rdoMale.Checked == true ? 'M' : 'N')}',
                                        {award},
                                        '{txtContactNumber.Text.Trim()}',
                                        {txtNumOfBooks.Text.Trim()},
                                        {cmbMainCategory.SelectedValue.ToString()}
                                      )";

            sqlInsertBook = DataAccess.SQLCleaner(sqlInsertBook);

            int rowsAffected = DataAccess.ExecuteNonQuery(sqlInsertBook);
            if (rowsAffected == 1)
            {
                MessageBox.Show("Author created");
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnUpdate.Text = "Update";
                createNewRecord = false;
                GetFirstAuthor();
            }

            else
            {
                MessageBox.Show("The database reported no rows affected");
            }


            NavigationState(true);
        }

        /// <summary>
        /// update existing record of author table
        /// </summary>
        private void SaveAuthorChanges()
        {
            string middleName = txtMiddleName.Text.Trim() == "" ? "NULL" : "'" + txtMiddleName.Text.Trim() + "'";
            string award = txtAward.Text.Trim() == "" ? "NULL" : "'" + DataAccess.SQLFix(txtAward.Text.Trim()) + "'";

            string sqlUpdateAuthor = $@"
                                      UPDATE Author
                                      SET 
                                        FirstName = '{txtFirstName.Text.Trim()}',
                                        LastName = '{txtLastName.Text.Trim()}',
                                        MiddleName = {middleName},
                                        Gender = '{(rdoFemale.Checked == true ? 'F' : rdoMale.Checked == true ? 'M' : 'N')}',
                                        Award = {award},
                                        ContactNumber = '{txtContactNumber.Text.Trim()}',
                                        NumOfBooks = {txtNumOfBooks.Text.Trim()},
                                        MainCategory = {cmbMainCategory.SelectedValue.ToString()}
                                      WHERE AuthorId = {currentAuthorId}";

            sqlUpdateAuthor = DataAccess.SQLCleaner(sqlUpdateAuthor);

            int rowsAffected = DataAccess.ExecuteNonQuery(sqlUpdateAuthor);
            if (rowsAffected == 1)
            {
                MessageBox.Show("Author updated");
            }
            else
            {
                MessageBox.Show("The database reported no rows affected.");
            }
        }

        /// <summary>
        /// delete existing record in author table
        /// </summary>
        private void DeleteAuthor()
        {
            string sqlNumAuthorinList = $"SELECT AuthorId FROM BooksAuthors WHERE AuthorId = {currentAuthorId}";
            int numAuthorinList = Convert.ToInt32(DataAccess.GetValue(sqlNumAuthorinList));

            if (numAuthorinList == 0)
            {
                string sqlDeleteAuthor = $@"DELETE FROM Author WHERE AuthorId = {currentAuthorId}";

                int rowsAffected = DataAccess.ExecuteNonQuery(sqlDeleteAuthor);

                if (rowsAffected == 1)
                {
                    ProgressBar();
                    MessageBox.Show("Author deleted");
                    GetFirstAuthor();
                    NavigationButtonManagement();
                }
                else
                {
                    MessageBox.Show("The database reported no rows affected.");
                }
            }
            else
            {
                MessageBox.Show("This author could not be deleted because it belongs to book list");
            }
        }
        #endregion

        #region Retrieves
        /// <summary>
        /// fill the category combobox
        /// </summary>
        private void LoadCategory()
        {
            DataTable dtMainCategory = DataAccess.GetData("SELECT CategoryId, CategoryName FROM Category");
            UT.BindComboBox(cmbMainCategory, dtMainCategory, "CategoryName", "CategoryId");
        }

        /// <summary>
        /// retrieve first author and display information
        /// </summary>
        private void GetFirstAuthor()
        {
            currentAuthorId = Convert.ToInt32(DataAccess.GetValue("SELECT TOP(1) AuthorId FROM Author ORDER BY FirstName, LastName"));
            LoadAuthorDetails();
        }

        /// <summary>
        /// display author details and assign author id for navigation
        /// </summary>
        private void LoadAuthorDetails()
        {
            errProvider.Clear();

            string sqlAuthorById = $"SELECT * FROM Author WHERE AuthorId = '{currentAuthorId}' ORDER BY FirstName, LastName";

            string sqlNav = $@"
                                SELECT 
	                                (SELECT TOP(1) AuthorId FROM Author ORDER BY FirstName, LastName) AS FirstID,
	                                (SELECT TOP(1) AuthorId FROM Author ORDER BY FirstName DESC, LastName DESC) AS LastID,
	                                q.PreviousID,
	                                q.NextID,
	                                q.RowNumber,
	                                (SELECT COUNT(*) FROM Author) AS NumOfAuthors
                                FROM 
	                                (SELECT AuthorId, 
			                                FirstName,
                                            LastName,
			                                LEAD(AuthorId) OVER (ORDER BY FirstName, LastName) AS NextID,
			                                LAG(AuthorId) OVER (ORDER BY FirstName, LastName) AS PreviousID,
			                                ROW_NUMBER() OVER (ORDER BY FirstName, LastName) As RowNumber
		                                FROM Author
	                                ) AS q
                                WHERE q.AuthorId = '{currentAuthorId}'
                                ORDER BY FirstName, LastName";

            sqlNav = DataAccess.SQLCleaner(sqlNav);

            string[] sqlStatements = new string[] { sqlAuthorById, sqlNav };
            DataSet ds = DataAccess.GetData(sqlStatements);

            DataRow selectedAuthor = ds.Tables["Table"].Rows[0];

            txtFirstName.Text = selectedAuthor["FirstName"].ToString();
            txtLastName.Text = selectedAuthor["LastName"].ToString();
            txtMiddleName.Text = selectedAuthor["MiddleName"].ToString();
            txtContactNumber.Text = selectedAuthor["ContactNumber"].ToString();

            switch (selectedAuthor["Gender"])
            {
                case "M":
                    rdoMale.Checked = true;
                    break;
                case "F":
                    rdoFemale.Checked = true;
                    break;
                default:
                    rdoNonBinary.Checked = true;
                    break;
            }

            txtNumOfBooks.Text = selectedAuthor["NumOfBooks"].ToString();
            cmbMainCategory.SelectedValue = selectedAuthor["MainCategory"];
            txtAward.Text = selectedAuthor["Award"].ToString();


            numberOfAuthors = Convert.ToInt32(ds.Tables["Table1"].Rows[0]["NumOfAuthors"]);
            firstAuthorId = Convert.ToInt32(ds.Tables["Table1"].Rows[0]["FirstID"]);
            lastAuthorId = Convert.ToInt32(ds.Tables["Table1"].Rows[0]["LastID"]);
            previousAuthorId = ds.Tables["Table1"].Rows[0]["PreviousID"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["PreviousID"]) : (int?)null;
            nextAuthorId = ds.Tables["Table1"].Rows[0]["NextID"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["NextID"]) : (int?)null;
            currentRecord = Convert.ToInt32(ds.Tables["Table1"].Rows[0]["RowNumber"]);

            GetLatestBooks();
            DisplayCurrentPosition();
        }

        /// <summary>
        /// display the latest book of selected author
        /// </summary>
        private void GetLatestBooks()
        {
            string sqlLatestBook = $@"
                                        SELECT TOP(1) b.Title, b.PublicateDate, c.CategoryName FROM BooksAuthors as ba
	                                        INNER JOIN Book AS b
	                                        ON b.BookId = ba.BookId
	                                        INNER JOIN Category AS c
	                                        ON b.CategoryId = c.CategoryId
	                                    WHERE AuthorId = {currentAuthorId}
	                                    ORDER BY b.PublicateDate DESC";

            sqlLatestBook = DataAccess.SQLCleaner(sqlLatestBook);

            DataTable dtLatestBook = DataAccess.GetData(sqlLatestBook);

            if(dtLatestBook.Rows.Count > 0)
            {
                grpPublishedWork.Enabled = true;
                txtTitle.Text = dtLatestBook.Rows[0]["Title"].ToString();
                txtPublicateDate.Text = ((DateTime)dtLatestBook.Rows[0]["PublicateDate"]).ToString("dd/MM/yyyy");
                txtCategory.Text = dtLatestBook.Rows[0]["CategoryName"].ToString();
            }
            else
            {
                grpPublishedWork.Enabled = false;
                txtTitle.Text = "";
                txtCategory.Text = "";
                txtPublicateDate.Text = "";
            }


        }

        #endregion

        #region [Navigation Helpers]
        /// <summary>
        /// change the author ID for navigation
        /// display author information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Navigation_Handler(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnFirst":
                    currentAuthorId = firstAuthorId;
                    break;
                case "btnLast":
                    currentAuthorId = lastAuthorId;
                    break;
                case "btnPrevious":
                    currentAuthorId = previousAuthorId.Value;
                    break;
                case "btnNext":
                    currentAuthorId = nextAuthorId.Value;
                    break;
            }

            LoadAuthorDetails();
            NavigationButtonManagement();
        }

        /// <summary>
        /// if there is no previous/next record, disable navigation buttons.
        /// </summary>
        private void NavigationButtonManagement()
        {
            btnPrevious.Enabled = previousAuthorId != null;
            btnNext.Enabled = nextAuthorId != null;
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
            ((mdiForm)this.MdiParent).StatusStipLabel.Text = $"{currentRecord} of {numberOfAuthors} authors";
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

            else if (txt.Name == "txtNumOfBooks")
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
        /// display overview in parent form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMaintenanceAuthor_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((mdiForm)this.MdiParent).RefreshParent();
        }

        #endregion


    }
}
