using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class mdiForm : Form
    {
        public ToolStripStatusLabel StatusStipLabel
        {
            get { return toolStripStatusLabel1; }
            set { toolStripStatusLabel1 = value; }
        }

        public ToolStripStatusLabel StatusStipLabe2
        {
            get { return toolStripStatusLabel2; }
            set { toolStripStatusLabel2 = value; }
        }
        public ProgressBar ProgressBar
        {
            get { return prgBar; }
            set { prgBar = value; }
        }

        public mdiForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// display child form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowNewForm(object sender, EventArgs e)
        {
            try
            {
                Form childForm = null;
                ToolStripMenuItem m = (ToolStripMenuItem)sender;

                switch (m.Tag)
                {
                    case "Book":
                        childForm = new frmMaintenanceBook();
                        break;
                    case "Author":
                        childForm = new frmMaintenanceAuthor();
                        break;
                    case "AuthorList":
                        childForm = new frmMaintenanceBookAuthorList();
                        break;
                    case "BrowseBooks":
                        childForm = new frmBrowseBooks();
                        break;
                    case "BrowseAuthors":
                        childForm = new frmBrowseAuthors();
                        break;
                }

                if (childForm != null)
                {
                    foreach (Form f in this.MdiChildren)
                    {
                        if (f.GetType() == childForm.GetType())
                        {
                            f.Activate();
                            return;
                        }
                    }
                }

                childForm.MdiParent = this;
                panel1.Visible = false;
                childForm.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// display child form by button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowNewFormByBtn(object sender, EventArgs e)
        {
            try
            {
                Form childForm = null;
                CircularButton btn = (CircularButton)sender;

                switch (btn.Tag)
                {
                    case "Book":
                        childForm = new frmMaintenanceBook();
                        break;
                    case "Author":
                        childForm = new frmMaintenanceAuthor();
                        break;
                    case "AuthorList":
                        childForm = new frmMaintenanceBookAuthorList();
                        break;
                    case "BrowseBooks":
                        childForm = new frmBrowseBooks();
                        break;
                    case "BrowseAuthors":
                        childForm = new frmBrowseAuthors();
                        break;
                }

                if (childForm != null)
                {
                    foreach (Form f in this.MdiChildren)
                    {
                        if (f.GetType() == childForm.GetType())
                        {
                            f.Activate();
                            return;
                        }
                    }
                }

                childForm.MdiParent = this;
                panel1.Visible = false;
                childForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void mdiForm_Load(object sender, EventArgs e)
        {
            Splash mySplash = new Splash();
            Login myLogin = new Login();

            mySplash.ShowDialog();

            if (mySplash.DialogResult != DialogResult.OK)
            {
                this.Close();
            }

            else
            {
                myLogin.ShowDialog();
            }

            if (myLogin.DialogResult == DialogResult.OK)
            {
                this.Show();
                ShowOverView();


                foreach (Control ctrl in this.Controls)
                {
                    if(ctrl is MdiClient)
                    {
                        ctrl.BackColor = Color.Linen;
                    }
                }
                toolStripStatusLabel1.Text = "Ready..";
            }

            else
            {
                this.Close();
            }
        }

        /// <summary>
        /// display overview of library database
        /// </summary>
        private void ShowOverView()
        {
            panel1.Visible = true;
            int numOfBooks = Convert.ToInt32(DataAccess.GetValue("SELECT COUNT(*) FROM Book"));
            int numOfAuthors = Convert.ToInt32(DataAccess.GetValue("SELECT COUNT(*) FROM Author"));
            decimal totalPrice = Convert.ToInt32(DataAccess.GetValue("SELECT SUM(Price) FROM Book"));
            int numOfAvailable = Convert.ToInt32(DataAccess.GetValue("SELECT COUNT(*) FROM Book WHERE Available = 1"));

            lbTotalBooks.Text = numOfBooks.ToString();
            lbTotalAuthors.Text = numOfAuthors.ToString();
            lbTotalPrice.Text = totalPrice.ToString("C");
            lbAvailable.Text = numOfAvailable.ToString();
        }

        /// <summary>
        /// display overview when all child form are closed
        /// </summary>
        public void RefreshParent()
        {
            int openChildFormCount = Application.OpenForms.Cast<Form>().Count(openForm => openForm.IsMdiChild);
            if(openChildFormCount == 0)
            {
                ShowOverView();
                toolStripStatusLabel1.Text = "Ready..";
                toolStripStatusLabel2.Text = "";
            }
        }
    }
}
