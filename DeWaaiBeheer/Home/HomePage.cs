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

            
        }

        private void frnHome_Load(object sender, EventArgs e)
        {
            BindingSource course = new BindingSource { DataSource = db.getCourses() };
            cmbCourses.DataSource = course;
            cmbCourses.DisplayMember = "Title";

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
            Application.Exit();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            //CoursesAddEditPage users = new CoursesAddEditPage();
            //users.ShowDialog();
            //this.Hide();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.users.ShowDialog();
        }

        private void cmbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Courses course = cmbCourses.SelectedItem as Courses;
            //BindingSource user = new BindingSource { DataSource = db.getUsersByCourse(course.ID) };
            //cmbCourses.DataSource = user;
            //cmbCourses.DisplayMember = "Fullname";
            //ResetList(course);
        }

        private void ResetList(Courses course)
        {
            lstNewCharts.DataBindings.Clear();

            lstNewCharts.DataBindings.Add(new Binding("Text", course, "Title"));
        }
    }
}
