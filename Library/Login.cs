//Author : Soyoung Kim
//Date : 6/2/2020
//Purpose : Project-Database-Driven-Application

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + " - Login";
            txtUserName.Text = "admin";
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                object userName = DataAccess.GetValue($"SELECT Password FROM Login WHERE UserName = '{txtUserName.Text}'");

                if(userName == null || txtPassword.Text.Trim() != userName.ToString())
                {
                    MessageBox.Show("Login failed");
                }

                else
                {
                    DialogResult = DialogResult.OK;
                }
               
            }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

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

            errorProvider1.SetError(txt, errMsg);
        }
    }
}
