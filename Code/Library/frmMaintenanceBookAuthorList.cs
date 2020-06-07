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
    public partial class frmMaintenanceBookAuthorList : Form
    {
        private int currentBookId = 0;
        private int currentAuthorId = 0;

        private int firstBookId = 0;
        private int firstAuthorId = 0;

        private int lastBookId = 0;
        private int lastAuthorId = 0;

        private int? nextBookId = 0;
        private int? nextAuthorId = 0;

        private int? previousBookId = 0;
        private int? previousAuthorId = 0;

        private const int MAX_AUTHORS = 3;

        bool createNewRecord = false;
        private int currentRecord = 0;
        private int numOfList = 0;

        public frmMaintenanceBookAuthorList()
        {
            InitializeComponent();
        }

        private void frmBookAuthorList_Load(object sender, EventArgs e)
        {
            LoadCategory();
            Setup(false);
        }

        #region Event

        /// <summary>
        /// get data according to category selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetRecords_Click(object sender, EventArgs e)
        {
            try
            {
                this.AutoValidate = AutoValidate.Disable;
                LoadBook();
                LoadAuthor();
                Setup(true);
                GetFirstList();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// clear all controls and change text in the update button when user click add button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ((mdiForm)this.MdiParent).StatusStipLabel.Text = "Adding a new record";
                ((mdiForm)this.MdiParent).StatusStipLabe2.Text = "";
                cmbBook.SelectedIndex = 0;
                cmbAuthor.SelectedIndex = 0;

                LoadCategory();

                btnUpdate.Text = "Create";
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                createNewRecord = true;

                NavigationState(false);
                UT.ClearControls(grpBook.Controls);
                UT.ClearControls(grpAuthor.Controls);
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
                LoadList();
                btnUpdate.Text = "Update";
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                createNewRecord = false;

                NavigationState(true);
                NavigationButtonManagement();
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
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;

                if (ValidateChildren(ValidationConstraints.Enabled))
                {

                    ProgressBar();

                    if (createNewRecord)
                    {
                        CreateList();
                    }

                    else
                    {
                        SaveListChanges();
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
        /// call delete method. prompt confirmation message box before delete.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to delete this Book&Author List?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DeleteList();
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
        }

        /// <summary>
        /// display book information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbBook.SelectedIndex > 0)
                {
                    LoadBookInfo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// display author information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbAuthor.SelectedIndex > 0)
                {
                    LoadAuthorInfo();
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
        /// insert new record into BooksAuthors table
        /// </summary>
        private void CreateList()
        {
            if (IsSameList())
            {
                string sqlInsertList = $@"INSERT INTO BooksAuthors
                                        (BookId, AuthorId)
                                      VALUES
                                        ({cmbBook.SelectedValue}, {cmbAuthor.SelectedValue})";

                sqlInsertList = DataAccess.SQLCleaner(sqlInsertList);

                int rowsAffected = DataAccess.ExecuteNonQuery(sqlInsertList);
                if (rowsAffected == 1)
                {
                    MessageBox.Show("List created");
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    btnUpdate.Text = "Update";
                    createNewRecord = false;
                    GetFirstList();
                }

                else
                {
                    MessageBox.Show("The database reported no rows affected");
                }

            }
            NavigationState(true);
        }

        /// <summary>
        /// update existing record of BooksAuthors table
        /// </summary>
        private void SaveListChanges()
        {

            string sqlUpdateList = $@"
                                      UPDATE BooksAuthors
                                      SET BookId = {cmbBook.SelectedValue}, AuthorId = {cmbAuthor.SelectedValue}                                       
                                      WHERE BookId = {currentBookId} AND AuthorId = {currentAuthorId}";

            sqlUpdateList = DataAccess.SQLCleaner(sqlUpdateList);
            int rowsAffected = DataAccess.ExecuteNonQuery(sqlUpdateList);
            if (rowsAffected == 1)
            {
                MessageBox.Show("List updated");
            }
            else
            {
                MessageBox.Show("The database reported no rows affected.");
            }
        }

        /// <summary>
        /// delete existing record in BooksAuthors table
        /// </summary>
        private void DeleteList()
        {
            string sqlDeleteList = $@"DELETE FROM BooksAuthors WHERE BookId = {currentBookId} AND AuthorId = {currentAuthorId}";

            int rowsAffected = DataAccess.ExecuteNonQuery(sqlDeleteList);

            if (rowsAffected == 1)
            {
                ProgressBar();
                MessageBox.Show("List deleted");
                GetFirstList();
                NavigationButtonManagement();
            }
            else
            {
                MessageBox.Show("The database reported no rows affected.");
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
            UT.FillListControl(cmbCategory, "CategoryName", "CategoryId", dtCategory, true, "All");
        }

        /// <summary>
        /// fill the books combobox
        /// </summary>
        private void LoadBook()
        {
            DataTable dtBook = DataAccess.GetData("SELECT BookId, Title FROM Book");
            UT.BindComboBox(cmbBook, dtBook, "Title", "BookId");
        }

        /// <summary>
        /// fill the authors combobox
        /// </summary>
        private void LoadAuthor()
        {
            DataTable dtAuthor = DataAccess.GetData("SELECT AuthorId, FirstName + ISNULL(' '+ MiddleName, '') + ' ' + LastName AS WholeName FROM Author  ORDER BY LastName, FirstName");
            UT.BindComboBox(cmbAuthor, dtAuthor, "WholeName", "AuthorId");
        }

        /// <summary>
        /// retrieve first author and book
        /// </summary>
        private void GetFirstList()
        {
            string sql = $@"SELECT TOP(1) ba.BookId, ba.AuthorId FROM BooksAuthors AS ba
                                INNER JOIN Book AS b
                                ON ba.BookId = b.BookId";

            if (cmbCategory.SelectedIndex > 0)
            {
                sql += $" WHERE b.CategoryId = {cmbCategory.SelectedValue}";
            }

            DataTable firstList = DataAccess.GetData(DataAccess.SQLCleaner(sql));
            if (firstList.Rows.Count > 0)
            {
                currentBookId = Convert.ToInt32(firstList.Rows[0]["BookId"]);
                currentAuthorId = Convert.ToInt32(firstList.Rows[0]["AuthorId"]);

                firstBookId = currentBookId;
                firstAuthorId = currentAuthorId;

                LoadList();
                NavigationButtonManagement();
            }
            else
            {
                ((mdiForm)this.MdiParent).StatusStipLabel.Text = "Status";
                MessageBox.Show("The list no longer exists");
            }

        }

        /// <summary>
        /// display list and assign id for navigation
        /// </summary>
        private void LoadList()
        {
            errProvider.Clear();

            string sqlNav;
            string sqlListByIds = $@"SELECT 
                                        ba.BookId, 
                                        ba.AuthorId
                                    FROM BooksAuthors AS ba
                                    INNER JOIN Book AS b
                                    ON ba.BookId = b.BookId
                                    WHERE ba.BookId = {currentBookId} AND ba.AuthorId = {currentAuthorId}";

            if (cmbCategory.SelectedIndex > 0)
            {
                sqlListByIds += $" AND b.CategoryId = {cmbCategory.SelectedValue}";
                sqlNav = $@"
                            SELECT 
                            (SELECT TOP(1) BooksAuthors.BookId AS FirstBookId FROM BooksAuthors
                                            INNER JOIN Book
                                            ON BooksAuthors.BookId = Book.BookId
				                            WHERE Book.CategoryId = {cmbCategory.SelectedValue}
				                            ) AS FirstBookId,
                            (SELECT TOP(1) AuthorId AS FirstAuthorId FROM BooksAuthors
                                            INNER JOIN Book
                                            ON BooksAuthors.BookId = Book.BookId
				                            WHERE Book.CategoryId = {cmbCategory.SelectedValue}
				                            ) AS FirstAuthorId,
                            q.PreviousBookId, q.PreviousAuthorId, q.NextBookId, q.NextAuthorId, q.RowNumber,
                            (SELECT TOP(1) BooksAuthors.BookId AS FirstBookId FROM BooksAuthors
                                            INNER JOIN Book
                                            ON BooksAuthors.BookId = Book.BookId
				                            WHERE Book.CategoryId = {cmbCategory.SelectedValue} 
				                            ORDER BY BooksAuthors.BookId DESC, AuthorId DESC) AS LastBookId,
                            (SELECT TOP(1) AuthorId AS FirstAuthorId FROM BooksAuthors
                                            INNER JOIN Book
                                            ON BooksAuthors.BookId = Book.BookId
				                            WHERE Book.CategoryId = {cmbCategory.SelectedValue}
				                            ORDER BY BooksAuthors.BookId DESC, AuthorId DESC) AS LastAuthorId,
                            (SELECT COUNT(*) FROM BooksAuthors INNER JOIN Book
                                            ON BooksAuthors.BookId = Book.BookId
				                            WHERE Book.CategoryId = {cmbCategory.SelectedValue}) AS NumOfLists
                            FROM	
                            (
	                            SELECT BooksAuthors.BookId, BooksAuthors.AuthorId, Book.CategoryId,
			                            LEAD(BooksAuthors.BookId) OVER (ORDER BY BooksAuthors.BookId) AS NextBookId,
			                            LEAD(BooksAuthors.AuthorId) OVER (ORDER BY BooksAuthors.BookID) AS NextAuthorId,
			                            LAG(BooksAuthors.BookId) OVER (ORDER BY BooksAuthors.BookId) AS PreviousBookId,
			                            LAG(BooksAuthors.AuthorId) OVER (ORDER BY BooksAuthors.BookId) AS PreviousAuthorId,
			                            ROW_NUMBER() OVER (ORDER BY BooksAuthors.BookId) AS 'RowNumber'
			                            FROM BooksAuthors
                                            INNER JOIN Book
                                            ON BooksAuthors.BookId = Book.BookId
			                            WHERE Book.CategoryId = {cmbCategory.SelectedValue}
				                            ) AS q
                            WHERE q.bookId = {currentBookId} AND q.AuthorId = {currentAuthorId}
                            ORDER BY q.BookId, q.AuthorId";
            }

            else
            {
                sqlNav = $@"
                            SELECT 
                            (SELECT TOP(1) BookId AS FirstBookId FROM BooksAuthors) AS FirstBookId,
                            (SELECT TOP(1) AuthorId AS FirstAuthorId FROM BooksAuthors) AS FirstAuthorId,
                            q.PreviousBookId, q.PreviousAuthorId, q.NextBookId, q.NextAuthorId, q.RowNumber,
                            (SELECT TOP(1) BookId AS FirstBookId FROM BooksAuthors
				                            ORDER BY BookId DESC, AuthorId DESC) AS LastBookId,
                            (SELECT TOP(1) AuthorId AS FirstAuthorId FROM BooksAuthors
				                            ORDER BY BookId DESC, AuthorId DESC) AS LastAuthorId,
                            (SELECT COUNT(*) FROM BooksAuthors) AS NumOfLists
                            FROM	
                            (
	                            SELECT BooksAuthors.BookId, BooksAuthors.AuthorId,
			                            LEAD(BooksAuthors.BookId) OVER (ORDER BY BooksAuthors.BookId) AS NextBookId,
			                            LEAD(BooksAuthors.AuthorId) OVER (ORDER BY BooksAuthors.BookID) AS NextAuthorId,
			                            LAG(BooksAuthors.BookId) OVER (ORDER BY BooksAuthors.BookId) AS PreviousBookId,
			                            LAG(BooksAuthors.AuthorId) OVER (ORDER BY BooksAuthors.BookId) AS PreviousAuthorId,
			                            ROW_NUMBER() OVER (ORDER BY BooksAuthors.BookId) AS 'RowNumber'
			                            FROM BooksAuthors) AS q
                            WHERE q.bookId = {currentBookId} AND q.AuthorId = {currentAuthorId}
                            ORDER BY q.BookId, q.AuthorId";
            }


            string[] sqlStatements = new string[] { DataAccess.SQLCleaner(sqlListByIds), DataAccess.SQLCleaner(sqlNav) };
            DataSet ds = DataAccess.GetData(sqlStatements);

            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow selectedList = ds.Tables["Table"].Rows[0];

                cmbBook.SelectedValue = selectedList["BookId"];
                cmbAuthor.SelectedValue = selectedList["AuthorId"];


                numOfList = Convert.ToInt32(ds.Tables["Table1"].Rows[0]["NumOfLists"]);

                firstBookId = Convert.ToInt32(ds.Tables["Table1"].Rows[0]["FirstBookId"]);
                firstAuthorId = Convert.ToInt32(ds.Tables["Table1"].Rows[0]["FirstAuthorId"]);

                lastBookId = Convert.ToInt32(ds.Tables["Table1"].Rows[0]["LastBookId"]);
                lastAuthorId = Convert.ToInt32(ds.Tables["Table1"].Rows[0]["LastAuthorId"]);

                previousBookId = ds.Tables["Table1"].Rows[0]["PreviousBookId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["PreviousBookId"]) : (int?)null;
                previousAuthorId = ds.Tables["Table1"].Rows[0]["PreviousAuthorId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["PreviousAuthorId"]) : (int?)null;

                nextBookId = ds.Tables["Table1"].Rows[0]["NextBookId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["NextBookId"]) : (int?)null;
                nextAuthorId = ds.Tables["Table1"].Rows[0]["NextAuthorId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["NextAuthorId"]) : (int?)null;

                currentRecord = Convert.ToInt32(ds.Tables["Table1"].Rows[0]["RowNumber"]);

                DisplayCurrentPosition();
            }

            else
            {
                ((mdiForm)this.MdiParent).StatusStipLabel.Text = "No records";
                MessageBox.Show("The list no longer exists");
            }
        }

        private void LoadBookInfo()
        {
            errProvider.Clear();

            string sqlBookInfo = $@"SELECT 
                                        b.Publisher, 
                                        CONVERT(VARCHAR(10), b.PublicateDate, 103) AS PublicationDate,
                                        (SELECT COUNT(*) FROM BooksAuthors WHERE BookId = {cmbBook.SelectedValue}) AS NumOfAuthor
                                    FROM Book AS b
                                    WHERE b.BookId = {cmbBook.SelectedValue}";

            DataTable dtDetails = DataAccess.GetData(DataAccess.SQLCleaner(sqlBookInfo));

            txtPublisher.Text = dtDetails.Rows[0]["Publisher"].ToString();
            txtPublicationDate.Text = dtDetails.Rows[0]["PublicationDate"].ToString();
            txtNumOfAuthor.Text = dtDetails.Rows[0]["NumOfAuthor"].ToString();
        }

        private void LoadAuthorInfo()
        {
            errProvider.Clear();

            string sqlAuthorInfo = $@"SELECT 
                                        a.ContactNumber, 
                                        c.CategoryName,
                                        a.NumOfBooks
                                    FROM Author AS a
                                    INNER JOIN Category AS c
                                    ON a.MainCategory = c.CategoryId
                                    WHERE a.AuthorId = {cmbAuthor.SelectedValue}";

            DataTable dtDetails = DataAccess.GetData(DataAccess.SQLCleaner(sqlAuthorInfo));

            txtPhoneNumber.Text = dtDetails.Rows[0]["ContactNumber"].ToString();
            txtCategory.Text = dtDetails.Rows[0]["CategoryName"].ToString();
            txtNumOfBook.Text = dtDetails.Rows[0]["NumOfBooks"].ToString();
        }

        #endregion

        #region [Navigation Helpers]
        /// <summary>
        /// change the book ID and author ID for navigation
        /// display information 
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
                    currentBookId = firstBookId;
                    break;
                case "btnLast":
                    currentAuthorId = lastAuthorId;
                    currentBookId = lastBookId;
                    break;
                case "btnPrevious":
                    currentAuthorId = previousAuthorId.Value;
                    currentBookId = previousBookId.Value;
                    break;
                case "btnNext":
                    currentAuthorId = nextAuthorId.Value;
                    currentBookId = nextBookId.Value;
                    break;
            }

            LoadList();
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
            ((mdiForm)this.MdiParent).StatusStipLabel.Text = $"{currentRecord} of {numOfList} lists";
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

        /// <summary>
        /// button&combobox enable status setup
        /// </summary>
        /// <param name="state"></param>
        private void Setup(bool state)
        {
            NavigationState(state);
            cmbAuthor.Enabled = state;
            cmbBook.Enabled = state;
            btnAdd.Enabled = state;
            btnCancel.Enabled = state;
            btnDelete.Enabled = state;
            btnUpdate.Enabled = state;
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
        /// check the same list exists in the table 
        /// </summary>
        /// <returns></returns>
        private bool IsSameList()
        {
            int NumOfAuthors = Convert.ToInt32(DataAccess.GetValue($"SELECT COUNT(*) FROM BooksAuthors WHERE BookId = {cmbBook.SelectedValue}"));

            string sql = $"SELECT * FROM BooksAuthors WHERE BookId = {cmbBook.SelectedValue} AND AuthorId = {cmbAuthor.SelectedValue}";

            DataTable dt = DataAccess.GetData(sql);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("The same record cannot exist in the database. Please check book and author again.");
                return false;
            }

            if (NumOfAuthors == 3)
            {
                MessageBox.Show("The author cannot be assigned over capacity. Book can have up to 3 authors");
                return false;
            }

            return true;
        }

        /// <summary>
        /// display overview in parent form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBookAuthorList_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((mdiForm)this.MdiParent).RefreshParent();
        }


        #endregion

      
    }
}
