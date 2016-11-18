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
                (this.Owner as frmHome).tlpMain.Show();
                (this.Owner as frmHome).nameToolStripMenuItem.Text = (user.FirstName);
                (this.Owner as frmHome).myAccountToolStripMenuItem.Text = ("Mijn account");
                (this.Owner as frmHome).logoutToolStripMenuItem.Text = ("Uitloggen");

                this.Close();
            }
            else
            {
                MessageBox.Show("Onjuiste gegevens!");
            }

            

        }
    }
}
