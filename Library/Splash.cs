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

namespace Library
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            lbProductName.Text = Application.ProductName;
            lbVersion.Text = Application.ProductVersion;
            lbCompanyName.Text = Application.CompanyName;
            
            lbProductName.Parent = pictureBox1;
            lbVersion.Parent = pictureBox1;
            lbCompanyName.Parent = pictureBox1;

            lbProductName.BackColor = Color.Transparent;
            lbVersion.BackColor = Color.Transparent;
            lbCompanyName.BackColor = Color.Transparent;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
