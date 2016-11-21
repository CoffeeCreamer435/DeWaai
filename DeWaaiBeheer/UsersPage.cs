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

        public frmUsers()
        {
            InitializeComponent();

            this.lstUsers.SelectedIndexChanged += lstUsers_SelectedIndexChanged;

            BindingSource users = new BindingSource { DataSource = db.getUsers() };
            lstUsers.DataSource = users;
            lstUsers.DisplayMember = "Firstname";
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Users user = lstUsers.SelectedItem as Users;
            BindingSource data = new BindingSource { DataSource = db.getUsers() };

            if(user != null)
            {
                BaseBinding = new BindingSource { DataSource = db.getUsers() };
            }
           
            this.NavBinding.BindingSource = BaseBinding;

            ResetUsers();
        }

        private void ResetUsers()
        {
            this.txtFirstname.DataBindings.Clear();
            this.txtInsertion.DataBindings.Clear();
            this.txtSurname.DataBindings.Clear();
            this.txtStreet.DataBindings.Clear();
            this.txtHousenr.DataBindings.Clear();
            this.txtCity.DataBindings.Clear();
            this.txtCountry.DataBindings.Clear();
            this.txtTelephonenumber.DataBindings.Clear();
            this.txtMobile.DataBindings.Clear();
            this.txtEmail.DataBindings.Clear();
            this.txtPass.DataBindings.Clear();
            this.txtRepeatPass.DataBindings.Clear();

            this.txtFirstname.DataBindings.Add("Text", BaseBinding, "Firstname");
            //this.txtInsertion.DataBindings.Add("Text", BaseBinding, "Insertion");
            this.txtSurname.DataBindings.Add("Text", BaseBinding, "Surname");
            this.txtStreet.DataBindings.Add("Text", BaseBinding, "FirstName");
            this.txtHousenr.DataBindings.Add("Text", BaseBinding, "FirstName");
            this.txtCity.DataBindings.Add("Text", BaseBinding, "FirstName");
            this.txtCountry.DataBindings.Add("Text", BaseBinding, "FirstName");
            this.txtTelephonenumber.DataBindings.Add("Text", BaseBinding, "FirstName");
            this.txtMobile.DataBindings.Add("Text", BaseBinding, "FirstName");
            this.txtEmail.DataBindings.Add("Text", BaseBinding, "FirstName");
            this.txtPass.DataBindings.Add("Text", BaseBinding, "FirstName");
            this.txtRepeatPass.DataBindings.Add("Text", BaseBinding, "FirstName");
        }
    }
}
