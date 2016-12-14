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
    public partial class frmUsers : Form
    {
        private DatabaseMethods db = new DatabaseMethods();
        private BindingSource binding;
        private Users user;

        public frmUsers()
        {
            InitializeComponent();
            tlpNavigation.Hide();

            user = new Users();
            binding = new BindingSource { DataSource = db.getUsers() };

            lstUsers.DataSource = binding;
            lstUsers.ValueMember = "ID";
            lstUsers.DisplayMember = "Fullname";

            cmbFunction.Text = "Cursist";
            cmbFunction.Text = "Instructeur";
        }       

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Users user = lstUsers.SelectedItem as Users;
            lstUsers.DataSource = db.getUsers();
            resetUsersBySelected(user);           
        }

        private void resetUsersBySelected(Users user)
        {
            if (user != null)
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

                txtId.DataBindings.Add("Text", user, "ID");
                txtFirstname.DataBindings.Add("Text", user, "Firstname");
                txtInsertion.DataBindings.Add("Text", user, "Insertion");
                txtSurname.DataBindings.Add("Text", user, "Surname");
                txtStreet.DataBindings.Add("Text", user, "Street");
                txtHousenr.DataBindings.Add("Text", user, "Housenumber");
                txtZip.DataBindings.Add("Text", user, "Zip");
                txtCity.DataBindings.Add("Text", user, "City");
                txtCountry.DataBindings.Add("Text", user, "Country");
                txtTelephonenumber.DataBindings.Add("Text", user, "Telephone");
                txtMobile.DataBindings.Add("Text", user, "Mobile");
                txtEmail.DataBindings.Add("Text", user, "Email");
                txtPass.DataBindings.Add("Text", user, "Password");
            }
        }


        #region User methods

        private void btnNew_Click(object sender, EventArgs e)
        {
            Program.newUser.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            if (MessageBox.Show("Weet u zeker dat u deze gebruiker wilt verwijderen?", "Informatie", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                for (int i = lstUsers.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    if (lstUsers.SelectedItem != null)
                    {
                        db.RemoveUser(id);
                        db.SaveChanges();

                        lstUsers.DataSource = null;
                        binding = new BindingSource { DataSource = db.getUsers() };
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

        #region Menu buttons
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.home.Show();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.courses.Show();
        }

        private void btnInstructors_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.instructors.Show();
        }

        private void btnFleets_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.vloten.Show();
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
        private void lblNavigation_Click(object sender, EventArgs e)
        {
            tlpNavigation.Show();
        }
        #endregion

        private void frmUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

