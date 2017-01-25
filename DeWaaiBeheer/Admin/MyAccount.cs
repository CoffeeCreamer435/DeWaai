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
    public partial class frmMyAccount : Form
    {
        /// <summary>
        /// Gets or sets the methods in this class.
        /// </summary>
        private DatabaseMethods db = new DatabaseMethods();

        public frmMyAccount()
        {
            InitializeComponent();

            cmbFunction.Items.Insert(0, "Cursist");
            cmbFunction.Items.Insert(1, "Instructeur");
            cmbFunction.Items.Insert(2, "Admin");
        }

        private void frmMyAccount_Load(object sender, EventArgs e)
        {
            var inst = db.getInstructors().FirstOrDefault(x => x.ID == Program.userId);

            if (inst == null)
            {
                foreach (Users us in db.GetUsersById(Program.userId))
                {
                    txtFirstname.Text = us.Firstname;
                    txtInsertion.Text = us.Insertion;
                    txtSurname.Text = us.Surname;
                    txtStreet.Text = us.Street;
                    txtHousenr.Text = us.HouseNumber;
                    txtZip.Text = us.Zip;
                    txtCity.Text = us.City;
                    txtCountry.Text = us.Country;
                    txtTelephonenumber.Text = us.Telephone;
                    txtMobile.Text = us.Mobile;
                    txtEmail.Text = us.Email;
                    txtPass.Text = us.Password;
                    cmbFunction.Text = us.Function;

                }
            }
            else
            {
                foreach (Instructors i in db.GetInstructorById(Program.userId))
                {
                    txtFirstname.Text = i.Firstname;
                    txtInsertion.Text = i.Insertion;
                    txtSurname.Text = i.Surname;
                    txtStreet.Text = i.Street;
                    txtHousenr.Text = i.HouseNumber;
                    txtZip.Text = i.Zip;
                    txtCity.Text = i.City;
                    txtCountry.Text = i.Country;
                    txtTelephonenumber.Text = i.Telephone;
                    txtMobile.Text = i.Mobile;
                    txtEmail.Text = i.Email;
                    txtPass.Text = i.Password;
                    cmbFunction.Text = "Instructeur";
                    txtDescription.Text = i.Description;
                }
            }                        
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            foreach (Users us in db.GetUsersById(Program.userId))
            {
                us.Firstname = txtFirstname.Text;
                us.Insertion = txtInsertion.Text;
                us.Surname = txtSurname.Text;
                us.Street = txtStreet.Text;
                us.HouseNumber = Convert.ToString(txtHousenr.Text);
                us.Zip = txtZip.Text;
                us.City = txtCity.Text;
                us.Country = txtCountry.Text;
                us.Telephone = Convert.ToString(txtTelephonenumber.Text);
                us.Mobile = txtMobile.Text;
                us.Email = txtEmail.Text;
                us.Password = txtPass.Text;
                us.Function = Convert.ToString(cmbFunction.SelectedItem);               
                us.Updated = DateTime.Now;

                db.SaveChanges();
                break;
            }
            MessageBox.Show("Gegevens zijn gewijzigd!");

            
        }
    }
}
