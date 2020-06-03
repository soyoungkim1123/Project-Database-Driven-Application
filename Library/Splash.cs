﻿//Author : Soyoung Kim
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
            label1.Text = Application.ProductName;
            label2.Text = Application.ProductVersion;
            label3.Text = Application.CompanyName;
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
