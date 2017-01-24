using System;
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
        /// <summary>
        /// Gets the methods in this class
        /// </summary>
        private DatabaseMethods dm = new DatabaseMethods();

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
            var email = txtEmail.Text;
            var password = txtPassword.Text;
            var user = dm.getUsers().SingleOrDefault(x => x.Email == email && x.Password == password);

            if(user != null && (!String.IsNullOrEmpty(txtEmail.Text) && !String.IsNullOrEmpty(txtPassword.Text)))
            {
                if(user.Function == "Admin")
                {
                    Program.userId = user.ID;
                    Program.username = user.Firstname;

                    this.Hide();
                    frmHome home = new frmHome();                  
                    home.Show();
                }
                else
                {
                    MessageBox.Show("U bent niet bevoegd deze applicatie te gebruiken!");
                }
            }
            else
            {
                MessageBox.Show("Onjuiste gegevens!");
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }

        private void llPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmForgotten form = new frmForgotten();
            form.Show();
        }
    }
}
