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
        private DatabaseMethods db = new DatabaseMethods();
        private BindingSource binding;
        private Instructors inst;

        public frmInstructorsPage()
        {
            InitializeComponent();
            tlpNavigation.Hide();

            inst = new Instructors();
            binding = new BindingSource { DataSource = db.getInstructors() };

            lstUsers.DataSource = binding;
            lstUsers.ValueMember = "ID";
            lstUsers.DisplayMember = "Fullname";
        }
      
        private void frmInstructorsPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblNavigation_MouseEnter(object sender, EventArgs e)
        {
            lblNavigation.Font = new Font(lblNavigation.Font.Name, lblNavigation.Font.SizeInPoints, FontStyle.Underline);
        }

        private void lblNavigation_MouseLeave(object sender, EventArgs e)
        {
            lblNavigation.Font = new Font(lblNavigation.Font.Name, lblNavigation.Font.SizeInPoints, FontStyle.Regular);
        }

        private void lblNavigation_Click(object sender, EventArgs e)
        {
            tlpNavigation.Show();
        }

        #region SideMenu buttons
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome home = new frmHome();
            home.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsersPage frmUsers = new frmUsersPage();
            frmUsers.Show();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCoursesPage frmCourses = new frmCoursesPage();
            frmCourses.Show();
        }

        private void btnFleets_Click(object sender, EventArgs e)
        {
            this.Hide();
            VlotenPage frmFleets = new VlotenPage();
            frmFleets.Show();
        }
        #endregion

        #region User methods
        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Close();
            frmNewUser frmNewUsers = new frmNewUser();
            frmNewUsers.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            if (MessageBox.Show("Weet u zeker dat u deze instructeur wilt verwijderen?", "Informatie", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                for (int i = lstUsers.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    if (lstUsers.SelectedItem != null)
                    {
                        db.RemoveInstructor(id);
                        db.SaveChanges();

                        lstUsers.DataSource = null;
                        binding = new BindingSource { DataSource = db.getInstructors() };
                        lstUsers.DataSource = binding;
                        lstUsers.DisplayMember = "Fullname";
                    }
                }
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            MessageBox.Show("De gegevens zijn succesvol gewijzigd!");
        }
        #endregion

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Instructors instructor = lstUsers.SelectedItem as Instructors;
            resetInstructorsBySelected(instructor);
        }

        private void resetInstructorsBySelected(Instructors instructor)
        {
            if (instructor != null)
            {
                txtId.DataBindings.Clear();
                txtFirstname.DataBindings.Clear();
                txtInsertion.DataBindings.Clear();
                txtSurname.DataBindings.Clear();
                txtStreet.DataBindings.Clear();
                txtHousenr.DataBindings.Clear();
                txtZip.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtTelephonenumber.DataBindings.Clear();
                txtMobile.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPass.DataBindings.Clear();
                txtDescription.DataBindings.Clear();

                txtId.DataBindings.Add("Text", instructor, "ID");
                txtFirstname.DataBindings.Add("Text", instructor, "Firstname");
                txtInsertion.DataBindings.Add("Text", instructor, "Insertion");
                txtSurname.DataBindings.Add("Text", instructor, "Surname");
                txtStreet.DataBindings.Add("Text", instructor, "Street");
                txtHousenr.DataBindings.Add("Text", instructor, "Housenumber");
                txtZip.DataBindings.Add("Text", instructor, "Zip");
                txtCity.DataBindings.Add("Text", instructor, "City");
                txtCountry.DataBindings.Add("Text", instructor, "Country");
                txtTelephonenumber.DataBindings.Add("Text", instructor, "Telephone");
                txtMobile.DataBindings.Add("Text", instructor, "Mobile");
                txtEmail.DataBindings.Add("Text", instructor, "Email");
                txtPass.DataBindings.Add("Text", instructor, "Password");
                txtDescription.DataBindings.Add("Text", instructor, "Description");
            }
        }

        public void updateListbox()
        {
            lstUsers.DataSource = null;
            lstUsers.DataSource = db.getInstructors();
            lstUsers.DisplayMember = "Fullname";
        }
    }
}
