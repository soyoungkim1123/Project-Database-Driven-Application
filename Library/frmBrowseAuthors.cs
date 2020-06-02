using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UT = Library.UIUtilities;

namespace Library
{
    public partial class frmBrowseAuthors : Form
    {
        int currentRecord;
        int numberOfBooks;
        int numberOfAuthors;

        public frmBrowseAuthors()
        {
            InitializeComponent();
        }

        private void frmBrowseAuthors_Load(object sender, EventArgs e)
        {
            LoadAuthor();
            LoadCategory();
        }
        #region Event

        /// <summary>
        /// display author detail according to user selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbAuthor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                LoadAuthorDetail();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// load author list in the specific category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadAuthor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        #endregion
        #region Retrieves

        /// <summary>
        /// fill category in the list
        /// </summary>
        private void LoadCategory()
        {
            DataTable dtCategory = DataAccess.GetData("SELECT CategoryId, CategoryName FROM Category");
            UT.FillListControl(lstCategory, "CategoryName", "CategoryId", dtCategory, true, "All");
        }

        /// <summary>
        /// load author according to user selection
        /// </summary>
        private void LoadAuthor()
        {
            string sqlAuthor = "SELECT AuthorId, FirstName + ISNULL(' '+ MiddleName, '') + ' ' + LastName AS FullName FROM Author";

            if (lstCategory.SelectedIndex > 0)
            {
                sqlAuthor += $" WHERE MainCategory = {lstCategory.SelectedValue}";
            }

            sqlAuthor += " ORDER BY FirstName, MiddleName, LastName";

            DataTable dtAuthor = DataAccess.GetData(sqlAuthor);

            if (dtAuthor.Rows.Count > 0)
            {
                UT.FillListControl(cmbAuthor, "FullName", "AuthorId", dtAuthor);
                numberOfAuthors = dtAuthor.Rows.Count;
                LoadAuthorDetail();
            }
            else
            {
                dgvBooks.Visible = false;
                lbFullName.Text = string.Empty;
                lbContactNumber.Text = string.Empty;
                lbAward.Text = string.Empty;
                lbNumOfBook.Text = string.Empty;
                cmbAuthor.DataSource = null;
                ((mdiForm)this.MdiParent).StatusStipLabel.Text = "No records";
                MessageBox.Show("There is no author in the category");
            }

        }

        /// <summary>
        /// display author's information
        /// </summary>
        private void LoadAuthorDetail()
        {
            string sql = $@"
                            SELECT AuthorId, FirstName + ISNULL(' '+ MiddleName, '') + ' ' + LastName AS FullName, 
                                   ContactNumber, 
                                   Award, 
                                   NumOfBooks 
                            FROM Author 
                            WHERE AuthorId = {cmbAuthor.SelectedValue}";

            sql = DataAccess.SQLCleaner(sql);
            DataTable dt = DataAccess.GetData(sql);

            if (dt.Rows.Count > 0)
            {
                lbFullName.Text = dt.Rows[0]["FullName"].ToString();
                lbContactNumber.Text = dt.Rows[0]["ContactNumber"].ToString();
                lbAward.Text = dt.Rows[0]["Award"] == DBNull.Value ? "None" : dt.Rows[0]["Award"].ToString();

                DataTable dtBooks = DataAccess.GetData($"SELECT BookId FROM BooksAuthors WHERE AuthorId = {cmbAuthor.SelectedValue}");
                string bookIds = string.Join(",", dtBooks.AsEnumerable().Select(a => a["BookId"]));
                string sqlList = $@"
                                    SELECT Title, PublicateDate, Publisher, CategoryName 
                                    FROM Book 
                                    INNER JOIN Category 
                                    ON Book.CategoryId = Category.CategoryId 
                                    WHERE BookId IN ({bookIds}) 
                                    ORDER BY Title";

                sqlList = DataAccess.SQLCleaner(sqlList);
                DataTable dtBookList = DataAccess.GetData(sqlList);

                if (dtBookList.Rows.Count > 0)
                {
                    dgvBooks.Visible = true;
                    dgvBooks.ReadOnly = true;
                    dgvBooks.BackgroundColor = Color.White;
                    dgvBooks.DataSource = dtBookList;
                    dgvBooks.AutoResizeColumns();

                    dgvBooks.Columns[0].HeaderText = "Book Title";
                    dgvBooks.Columns[1].HeaderText = "Publication Date";
                    dgvBooks.Columns[3].HeaderText = "Category";

                    dgvBooks.Columns[1].DefaultCellStyle.Format = "MM/dd/yyyy";
                }
                
                numberOfBooks = dgvBooks.Rows.Count;
                currentRecord = cmbAuthor.SelectedIndex + 1;
                lbNumOfBook.Text = $"Number of Books: {numberOfBooks}";
                ((mdiForm)this.MdiParent).StatusStipLabel.Text = $"{currentRecord} of {numberOfAuthors} authors with {numberOfBooks} books";
            }

            else
            {
                MessageBox.Show("There is no record");
            }
        }
        #endregion

        #region Helper

        /// <summary>
        /// to display overview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBrowseAuthors_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((mdiForm)this.MdiParent).RefreshParent();
        }
        #endregion

    }
}
