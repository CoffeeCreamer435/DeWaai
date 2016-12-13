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
    public partial class frmNewUser : Form
    { 
        private DatabaseMethods db = new DatabaseMethods();
        private BindingSource users;
        private Users user;

        public frmNewUser()
        {
            InitializeComponent();
            user = new Users();
            users = new BindingSource();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var input = txtEmail.Text;

            foreach (Users us in db.getUsers())
            {
                if(!String.IsNullOrEmpty(txtFirstname.Text) || !String.IsNullOrEmpty(txtSurname.Text) || !String.IsNullOrEmpty(txtStreet.Text) || !String.IsNullOrEmpty(txtHousenr.Text) || !String.IsNullOrEmpty(txtZip.Text) || !String.IsNullOrEmpty(txtCity.Text) || !String.IsNullOrEmpty(txtCountry.Text) || !String.IsNullOrEmpty(txtMobile.Text) || !String.IsNullOrEmpty(txtEmail.Text) || !String.IsNullOrEmpty(txtPass.Text))
                {
                    if (input != us.Email)
                    {     
                        user.Firstname = txtFirstname.Text;
                        user.Insertion = txtInsertion.Text;
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
                        this.Close();
                        break;

                    }
                    else
                    {
                        MessageBox.Show("Dit email bestaat al!", "Informatie", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("U heeft een aantal verplichte velden niet ingevuld!");
                    break;
                }
                
            }
        }
      
        private void txtTelephonenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(sender, e);
        }

        private void txtHousenr_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(sender, e);
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(sender, e);
        }

        #region Methods
        public void NumberOnly(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
