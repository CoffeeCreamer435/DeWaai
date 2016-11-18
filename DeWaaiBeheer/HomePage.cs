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
    public partial class frmHome : Form
    {  
        public frmHome()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void frnHome_Load(object sender, EventArgs e)
        {
            tlpMain.Hide();
            Program.login.Owner = this;
            Program.login.Show();
        }

        /// <summary>
        /// Gets the my account form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void myAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.account.ShowDialog();
        }

        /// <summary>
        /// Logs out from user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.home.Owner = this;
            Program.login.Show();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            Program.courses.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Program.users.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
