//Author : Soyoung Kim
//Date : 6/2/2020
//Purpose : Project-Database-Driven-Application

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
    public partial class frmBrowseBooks : Form
    {
        int currentRecord;
        int numberOfBooks;
        int numberOfAuthors;

        public frmBrowseBooks()
        {
            InitializeComponent();
        }

        private void frmBrowseBook_Load(object sender, EventArgs e)
        {
            LoadBook();
            LoadCategory();
            GenerateYear();
        }

        #region Event

        /// <summary>
        /// when user select book in the combobox, load book details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTitle_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                LoadBookDetail();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// when user select category, load books that belong to the category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                chkAvailable.Checked = false;
                cmbYear.SelectedIndex = -1;
                LoadBook();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// when user click the filter button, load book again 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                LoadBook();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        #endregion

        #region Retrieves

        /// <summary>
        /// fill the category list
        /// </summary>
        private void LoadCategory()
        {
            DataTable dtCategory = DataAccess.GetData("SELECT CategoryId, CategoryName FROM Category");
            UT.FillListControl(lstCategory, "CategoryName", "CategoryId", dtCategory, true, "All");
        }

        /// <summary>
        /// Load books according to user selection
        ///  if the user selects the filter option, filter the result based on criteria
        /// </summary>
        private void LoadBook()
        {
            string sqlLoadBook = "SELECT BookId, Title + ' - ' + Edition AS Title FROM Book WHERE 0=0";

            if(lstCategory.SelectedIndex > 0)
            {
                sqlLoadBook += $" AND CategoryId = {lstCategory.SelectedValue}";
            }

            if(cmbYear.SelectedIndex > 0)
            {
                sqlLoadBook += $" AND (PublicateDate BETWEEN '{cmbYear.SelectedItem}-01-01' AND '{cmbYear.SelectedItem}-12-31')";
            }

            if(chkAvailable.Checked)
            {
                sqlLoadBook += $" AND Available = 1";
            }

            sqlLoadBook += " ORDER BY Title";

            DataTable dtBook = DataAccess.GetData(sqlLoadBook);

            if(dtBook.Rows.Count > 0)
            {
                UT.FillListControl(cmbTitle, "Title", "BookId", dtBook);
                numberOfBooks = dtBook.Rows.Count;
                LoadBookDetail();
            }
            else
            {
                dgvAuthors.Visible = false;
                lbTitle.Text = string.Empty;
                lbISBN.Text = string.Empty;
                lbCategory.Text = string.Empty;
                lbPublisher.Text = string.Empty;
                lbPrice.Text = string.Empty;
                lbNumOfAuthor.Text = string.Empty;
                cmbTitle.DataSource = null;
                ((mdiForm)this.MdiParent).StatusStipLabel.Text = "No records";
                MessageBox.Show("There is no book in the category");
            }
        }

        /// <summary>
        /// display detail information of book use selected
        /// </summary>
        private void LoadBookDetail()
        {
            string sql = $@"
                            SELECT Title, ISBN, CategoryName, Publisher + ' (' + CONVERT(VARCHAR, YEAR(publicateDate)) + ')' AS Publisher, Price 
		                            FROM Book
		                            INNER JOIN Category
		                            ON Book.CategoryId = Category.CategoryId
		                            WHERE BookId = '{cmbTitle.SelectedValue}'";

            sql = DataAccess.SQLCleaner(sql);
            DataTable dt = DataAccess.GetData(sql);

            if(dt.Rows.Count > 0)
            {
                lbTitle.Text = dt.Rows[0]["Title"].ToString();
                lbISBN.Text = dt.Rows[0]["ISBN"].ToString();
                lbCategory.Text = dt.Rows[0]["CategoryName"].ToString();
                lbPublisher.Text = dt.Rows[0]["Publisher"].ToString();
                lbPrice.Text = Convert.ToDecimal(dt.Rows[0]["Price"]).ToString("C");

                DataTable dtAuthors = DataAccess.GetData($"SELECT AuthorId FROM BooksAuthors WHERE BookId = {cmbTitle.SelectedValue}");
                string authorIds = string.Join(",", dtAuthors.AsEnumerable().Select(a => a["AuthorId"]));
                DataTable dtAuthorList = DataAccess.GetData($"SELECT FirstName + ISNULL(' '+ MiddleName, '') + ' ' + LastName, ContactNumber, Award, NumOfBooks FROM Author WHERE AuthorId IN ({authorIds}) ORDER BY FirstName, MiddleName, LastName");

                if(dtAuthorList.Rows.Count > 0)
                {
                    dgvAuthors.Visible = true;
                    dgvAuthors.ReadOnly = true;
                    dgvAuthors.BackgroundColor = Color.White;
                    dgvAuthors.DataSource = dtAuthorList;
                    dgvAuthors.AutoResizeColumns();

                    dgvAuthors.Columns[0].HeaderText = "Name";
                    dgvAuthors.Columns[1].HeaderText = "Contact Number";
                    dgvAuthors.Columns[3].HeaderText = "Published Books";
                }
                numberOfAuthors = dtAuthorList.Rows.Count;
                currentRecord = cmbTitle.SelectedIndex + 1;
                lbNumOfAuthor.Text = $"Number of Authors: {numberOfAuthors}";
                ((mdiForm)this.MdiParent).StatusStipLabel.Text = $"{currentRecord} of {numberOfBooks} books with {numberOfAuthors} authors";
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
        private void frmBrowseBooks_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((mdiForm)this.MdiParent).RefreshParent();
        }

        /// <summary>
        /// generate years in combobox to filter books
        /// </summary>
        private void GenerateYear()
        {
            cmbYear.Items.Add("");

            for(int i = 1990; i < DateTime.Now.Year + 1; i++)
            {
                cmbYear.Items.Add(i);
            }
        }
        #endregion


    }
}
