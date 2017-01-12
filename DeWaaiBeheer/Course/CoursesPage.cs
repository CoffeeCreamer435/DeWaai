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
    public partial class frmCoursesPage : Form
    {
        private static DatabaseMethods db = new DatabaseMethods();

        private BindingSource courses = new BindingSource { DataSource = db.getCourses() };
        private Courses course = new Courses();

        public frmCoursesPage()
        {
            InitializeComponent();
            tlpNavigation.Hide();         
            
            lstCourses.DataSource = courses;
            lstCourses.ValueMember = "ID";
            lstCourses.DisplayMember = "Name";                    
        }

        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {       
            Courses course = lstCourses.SelectedItem as Courses;
            ResetList(course);          
        }
                 

        public void ResetList(Courses course)
        {
            if (course != null)
            {
                txtCoursenumber.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtDescription.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtAmount.DataBindings.Clear();
                //dtpDate.DataBindings.Clear();

                txtCoursenumber.DataBindings.Add("Text", course, "ID");
                txtName.DataBindings.Add("Text", course, "Name");
                txtDescription.DataBindings.Add("Text", course, "Description");
                txtPrice.DataBindings.Add("Text", course, "Price");
                txtAmount.DataBindings.Add("Text", course, "Amount");
                //dtpDate.DataBindings.Add("Text", course, "Date");
            }                 
        }   

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(sender, e);
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(sender, e);
        }   

        private void lblNavigation_Click(object sender, EventArgs e)
        {
            tlpNavigation.Show();
        }

        #region User methods
        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNewCourse frmNewCourse = new frmNewCourse();
            frmNewCourse.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCoursenumber.Text);

            if (MessageBox.Show("Weet u zeker dat u '" + txtName.Text + "' wilt verwijderen?", "Informatie", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                for (int i = lstCourses.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    if (lstCourses.SelectedItem != null)
                    {
                        db.RemoveCourse(id);
                        db.SaveChanges();

                        lstCourses.DataSource = null;
                        courses = new BindingSource { DataSource = db.getCourses() };
                        lstCourses.DataSource = courses;
                        lstCourses.DisplayMember = "Name";
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string date = dtpDate.Value.ToShortDateString();
            int id = Convert.ToInt32(txtCoursenumber.Text);

            foreach (Courses co in db.GetCoursesbyID(id))
            {
                co.Date = date;
                co.Updated = DateTime.Now;
                db.SaveChanges();
                break;
            }

            MessageBox.Show("De gegevens zijn succesvol gewijzigd!");
        }
        #endregion

        #region SideMenu buttons
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome home = new frmHome();
            home.Show();
        }

        private void btnCharts_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnRegistrations_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsersPage frmUsers = new frmUsersPage();
            frmUsers.Show();
        }

        private void btnInstructors_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInstructorsPage frmInstructor = new frmInstructorsPage();
            frmInstructor.Show();
        }  

        private void btnFleets_Click(object sender, EventArgs e)
        {
            this.Hide();
            VlotenPage frmFleets = new VlotenPage();
            frmFleets.Show();
        }
        #endregion

        #region Methods
        public void NumberOnly(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Navigation label methods
        private void lblNavigation_MouseEnter(object sender, EventArgs e)
        {
            lblNavigation.Font = new Font(lblNavigation.Font.Name, lblNavigation.Font.SizeInPoints, FontStyle.Underline);
        }

        private void lblNavigation_MouseLeave(object sender, EventArgs e)
        {
            lblNavigation.Font = new Font(lblNavigation.Font.Name, lblNavigation.Font.SizeInPoints, FontStyle.Regular);
        }
        #endregion

        #region Listbox method
        public void updateListbox()
        {
            lstCourses.DataSource = null;
            lstCourses.DataSource = db.getCourses();
            lstCourses.DisplayMember = "Name";
        }
        #endregion
    }
}
