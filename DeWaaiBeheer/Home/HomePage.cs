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
            nameToolStripMenuItem.Text = ("Admin");
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
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

        #region SideMenu buttons
        private void btnCourses_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCoursesPage frmCourse = new frmCoursesPage();
            frmCourse.Show();
            
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Close();
            frmUsersPage frmUser = new frmUsersPage();
            frmUser.Show();
        }

        private void btnInstructors_Click(object sender, EventArgs e)
        {
            this.Close();
            frmInstructorsPage frmInstructor = new frmInstructorsPage();
            frmInstructor.Show();
        }

        private void btnCharts_Click(object sender, EventArgs e)
        {
            this.Close();
            Overzicht.OverzichtPage overzicht = new Overzicht.OverzichtPage();
            overzicht.Show();
        }

        private void btnRegistrations_Click(object sender, EventArgs e)
        {
            this.Close();
            Inschrijvingen.InschrijvingenPage inschrijvingen = new Inschrijvingen.InschrijvingenPage();
            inschrijvingen.Show();
        }

        private void btnFleets_Click(object sender, EventArgs e)
        {
            this.Close();
            VlotenPage frmFleets = new VlotenPage();
            frmFleets.Show();
        }
        #endregion

        private void frmHome_Load(object sender, EventArgs e)
        {
            BindingSource registrations = new BindingSource { DataSource = db.getUsersByCourse() };
            lstUsers.DataSource = registrations;
            lstUsers.DisplayMember = "ID";
            //lstUsers.Items.Add(string.Format("{0}       |       {1}       |       {2}", "Emre Atasoy", "11-10-2970", "Gevorderden"));
            //lstUsers.Items.Add(string.Format("{0}       |       {1}       |       {2}", "Emre Atasoy", "11-10-2970", "Gevorderden"));
        }
    }
}
