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
    public partial class frmInstructorsPage : Form
    {
        public frmInstructorsPage()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Program.newUser.ShowDialog();
        }

        private void btnHomepage_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.home.Show();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.courses.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.users.Show();
        }

        private void frmInstructorsPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
