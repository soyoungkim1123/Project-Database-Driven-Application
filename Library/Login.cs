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
            this.Text = Application.ProductName + "- Login";
            txtUserName.Text = Environment.UserName;
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
                if(txtUserName.Text == Environment.UserName &&
                    txtPassword.Text.Trim().ToLower() == ConfigurationManager.AppSettings["DefaultPassword"].ToString().ToLower())
                {
                    DialogResult = DialogResult.OK;
                }

                else
                {
                    MessageBox.Show("Login failed");
                }
            }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
