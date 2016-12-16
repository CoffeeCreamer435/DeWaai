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

        public frmNewUser()
        {
            InitializeComponent();

            users = new BindingSource();

            cmbFunction.Items.Insert(0, "Cursist");
            cmbFunction.Items.Insert(1, "Instructeur");
            cmbFunction.Items.Insert(2, "Admin");
        }

        private void frmNewUser_Load(object sender, EventArgs e)
        {
            cmbFunction.SelectedIndex = 0;
        }

        #region User methods
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var input = txtEmail.Text;
            var function = cmbFunction.SelectedItem.ToString();

            Users user = new Users();
            Instructors instructor = new Instructors();

            if (!String.IsNullOrEmpty(txtFirstname.Text) && !String.IsNullOrEmpty(txtSurname.Text) && !String.IsNullOrEmpty(txtStreet.Text) && !String.IsNullOrEmpty(txtHousenr.Text) && !String.IsNullOrEmpty(txtZip.Text) && !String.IsNullOrEmpty(txtCity.Text) && !String.IsNullOrEmpty(txtCountry.Text) && !String.IsNullOrEmpty(txtMobile.Text) && !String.IsNullOrEmpty(txtEmail.Text) && !String.IsNullOrEmpty(txtPass.Text))
            {
                if (input != user.Email || input != instructor.Email)
                {
                    switch (function)
                    {
                        case "Cursist":               
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
                            user.Created = DateTime.Now;
                            user.Function = "Cursist";

                            //Save user to database
                            db.AddUser(user);
                            db.SaveChanges();
                            Program.users.updateListbox();
                            break;

                        case "Instructeur":
                            if (!String.IsNullOrEmpty(txtDescription.Text))
                            {
                                instructor.Firstname = txtFirstname.Text;
                                instructor.Insertion = txtInsertion.Text;
                                instructor.Surname = txtSurname.Text;
                                instructor.Street = txtStreet.Text;
                                instructor.HouseNumber = txtHousenr.Text;
                                instructor.Zip = txtZip.Text;
                                instructor.City = txtCity.Text;
                                instructor.Country = txtCountry.Text;
                                instructor.Telephone = txtTelephonenumber.Text;
                                instructor.Mobile = txtMobile.Text;
                                instructor.Email = txtEmail.Text;
                                instructor.Password = txtPass.Text;
                                instructor.Description = txtDescription.Text;                      

                                //Save instructor to database
                                db.AddInstructor(instructor);
                                db.SaveChanges();
                                Program.instructors.updateListbox();
                            }                      
                            else
                            {
                                MessageBox.Show("U heeft de beschrijving vergeten!");
                            }
                            break;

                        case "Admin":
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
                            user.Created = DateTime.Now;
                            user.Function = "Admin";

                            //Save user to database
                            db.AddUser(user);
                            db.SaveChanges();
                            Program.users.updateListbox();
                            break;
                            
                    }
                    MessageBox.Show("Gebruiker is succesvol toegevoegd!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Dit email bestaat al!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("U heeft een aantal verplichte velden niet ingevuld!");
            }
        }

        #endregion

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
