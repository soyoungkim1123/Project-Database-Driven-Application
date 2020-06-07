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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            this.Text = "About " + Application.ProductName;
            lbAppName.Text = Application.ProductName;
            lbVersion.Text = Application.ProductVersion;
            lbDeveloperName.Text = Application.CompanyName;
            lbCopyRight.Text = "All rights reserved.";
            lbDate.Text = "2020-06-07";
            lbPurpose.Text = "Database Programming Project";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((mdiForm)this.MdiParent).RefreshParent();
        }
    }
}
