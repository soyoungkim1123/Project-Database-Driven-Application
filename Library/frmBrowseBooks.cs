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
            cmbYear.Enabled = false;
        }

        #region Event

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

        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                chkAvailable.Checked = false;
                chkYear.Checked = false;
                LoadBook();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

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

        private void LoadCategory()
        {
            DataTable dtCategory = DataAccess.GetData("SELECT CategoryId, CategoryName FROM Category");
            UT.FillListControl(lstCategory, "CategoryName", "CategoryId", dtCategory, true, "All");
        }

        private void LoadBook()
        {
            string sqlLoadBook = "SELECT BookId, Title + ' - ' + Edition AS Title FROM Book";

            if(lstCategory.SelectedIndex > 0)
            {
                sqlLoadBook += $" WHERE CategoryId = {lstCategory.SelectedValue}";
            }

            if(cmbYear.SelectedIndex > 0)
            {
                if(lstCategory.SelectedIndex == 0)
                {
                    sqlLoadBook += $" WHERE PublicateDate BETWEEN '{cmbYear.SelectedItem}-01-01' AND '{cmbYear.SelectedItem}-12-31'";
                }
                else
                {
                    sqlLoadBook += $" AND (PublicateDate BETWEEN '{cmbYear.SelectedItem}-01-01' AND '{cmbYear.SelectedItem}-12-31')";
                }
            }

            if(chkAvailable.Checked)
            {
                if (lstCategory.SelectedIndex == 0 && (cmbYear.SelectedIndex < 1 || !chkYear.Checked))
                {
                    sqlLoadBook += $" WHERE Available = 1";
                }
                else
                {
                    sqlLoadBook += $" AND Available = 1";
                }
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
                cmbTitle.DataSource = null;
                ((mdiForm)this.MdiParent).StatusStipLabel.Text = "No records";
                MessageBox.Show("There is no book in the category");
            }
        }

        private void LoadBookDetail()
        {
            string sql = $@"
                            SELECT  Title, ISBN, CategoryName, Publisher, Price 
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
        private void frmBrowseBooks_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((mdiForm)this.MdiParent).RefreshParent();
        }

        private void GenerateYear()
        {
            cmbYear.Items.Add("");

            for(int i = 1990; i < DateTime.Now.Year + 1; i++)
            {
                cmbYear.Items.Add(i);
            }
        }
        #endregion

        private void chkYear_CheckedChanged(object sender, EventArgs e)
        {
            cmbYear.Enabled = chkYear.Checked;
            if(cmbYear.Enabled == false)
            {
                cmbYear.SelectedIndex = 0;
            }
        }


    }
}
