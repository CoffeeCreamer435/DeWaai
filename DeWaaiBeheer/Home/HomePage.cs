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
        private DatabaseMethods db = new DatabaseMethods();

        public frmHome()
        {
            InitializeComponent();
            FillCursussenList();
            fillComboCursussen();
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
            Application.Exit();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            CoursesAddEditPage users = new CoursesAddEditPage();
            users.Show();
            this.Hide();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.users.ShowDialog();
        }

        public void FillCursussenList()
        {
            lstNewCharts.DataSource = db.getCourses();
            lstNewCharts.ValueMember = "ID";
            lstNewCharts.DisplayMember = "Title";
        }

        public void fillComboCursussen()
        {
            cmbCourses.DataSource = db.getCourses();
            cmbCourses.ValueMember = "ID";
            cmbCourses.DisplayMember = "Title";
        }

        private void cmbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            Courses course = cmbCourses.SelectedItem as Courses;
            BindingSource user = new BindingSource { DataSource = db.getUsersByCourse(course.ID) };
            cmbCourses.DataSource = user;
            cmbCourses.DisplayMember = "Title";
            ResetList(course);
        }

        private void ResetList(Courses course)
        {
            lstNewCharts.DataBindings.Clear();

            lstNewCharts.DataBindings.Add(new Binding("Text", course, "Title"));
        }
    }
}
