﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeWaaiBeheer
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            ControlBox = false;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {          
            (this.Owner as frmHome).tlpMain.Show();
            (this.Owner as frmHome).lblUsername.Text = ("Emre");
            this.Close();

        }
    }
}
