using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Validation;

namespace DeWaaiBeheer
{
    public partial class frmHome : Form
    {
        private DatabaseMethods db = new DatabaseMethods();
       
        public frmHome()
        {
            InitializeComponent();
            myAccountToolStripMenuItem.Text = ("Mijn account");
            logoutToolStripMenuItem.Text = ("Uitloggen");
            nameToolStripMenuItem.Text = ("Admin paneel");
        }

        private void frnHome_Load(object sender, EventArgs e)
        {
            BindingSource binding = new BindingSource { DataSource = db.getCourse() };
            cmbCourses.DataSource = binding;
            cmbCourses.DisplayMember = "Name";
        }

        private void cmbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource user = new BindingSource { DataSource = db.getUsersByCourse() };
            lstNewCharts.DataSource = user;
            lstNewCharts.DisplayMember = "ID";
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
            Application.Exit();
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

        private void btnInstructors_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.instructors.Show();
        }

        private void btnReviews_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnFleets_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.vloten.Show();
        }

        private void btnTenders_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.inschrijvingen.Show();
        }
    }
}
