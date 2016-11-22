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
        private BindingSource BaseBinding = null;
        private Users user;


        public frmUsers()
        {
            InitializeComponent();
            user = new Users();
            BindingSource users = new BindingSource { DataSource = db.getUsers() };
            lstUsers.DataSource = users;
            lstUsers.DisplayMember = "Fullname";
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Users user = lstUsers.SelectedItem as Users;

            if (user != null)
            {
                BaseBinding = new BindingSource { DataSource = db.getUsers() };
            }
           
            this.NavBinding.BindingSource = BaseBinding;
            
            resetUsersByNavigator();
        }

        private void resetUsersBySelected(Users user)
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
        private void resetUsersByNavigator()
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

            txtId.DataBindings.Add("Text", BaseBinding, "ID");
            txtFirstname.DataBindings.Add("Text", BaseBinding, "Firstname");
            txtInsertion.DataBindings.Add("Text", BaseBinding, "Insertion");
            txtSurname.DataBindings.Add("Text", BaseBinding, "Surname");
            txtStreet.DataBindings.Add("Text", BaseBinding, "Street");
            txtHousenr.DataBindings.Add("Text", BaseBinding, "Housenumber");
            txtZip.DataBindings.Add("Text", BaseBinding, "Zip");
            txtCity.DataBindings.Add("Text", BaseBinding, "City");
            txtCountry.DataBindings.Add("Text", BaseBinding, "Country");
            txtTelephonenumber.DataBindings.Add("Text", BaseBinding, "Telephone");
            txtMobile.DataBindings.Add("Text", BaseBinding, "Mobile");
            txtEmail.DataBindings.Add("Text", BaseBinding, "Email");
            txtPass.DataBindings.Add("Text", BaseBinding, "Password");
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            if(MessageBox.Show("Weet u zeker dat u deze gebruiker wilt verwijderen?", "Informatie", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                db.RemoveUser(id);
                db.SaveChanges();
            }
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtInsertion.Text))
            {
                user.Fullname = txtFirstname.Text + " " + txtInsertion.Text + " " + txtSurname.Text;
            }
            else
            {
                user.Insertion = txtInsertion.Text;
            }

            db.SaveChanges();
            MessageBox.Show("De gegevens zijn succesvol gewijzigd!");
            lstUsers.DataSource = null;
            lstUsers.DataSource = user.Fullname;
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            var input = txtEmail.Text;

            foreach (Users us in db.getUsers())
            {
                if (input != us.Email)
                {                  
                    if (!String.IsNullOrEmpty(txtInsertion.Text))
                    {
                        user.Fullname = txtFirstname.Text + " " + txtInsertion.Text + " " + txtSurname.Text;
                    }
                    else
                    {
                        user.Insertion = txtInsertion.Text;
                    }

                    user.Fullname = txtFirstname.Text + " " + txtSurname.Text;
                    user.Firstname = txtFirstname.Text;
                    user.Surname = txtSurname.Text;
                    user.Street = txtStreet.Text;
                    user.HouseNumber = txtHousenr.Text;
                    user.Zip = txtZip.Text;
                    user.City = txtCity.Text;
                    user.Country = txtCountry.Text;
                    user.Telephone = txtTelephonenumber.Text;
                    user.Mobile = txtMobile.Text;
                    user.Email = txtEmail.Text;
                    user.Password = txtPass.Text;


                    db.AddUser(user);
                    db.SaveChanges();

                    MessageBox.Show("Gebruiker is succesvol toegevoegd!");
                    lstUsers.Refresh();

                    break;
                }
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(txtId.Text);
            txtId.Text = Convert.ToString(count += user.ID);
        }
    }
}
