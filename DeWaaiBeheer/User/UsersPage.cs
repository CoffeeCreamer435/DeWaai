using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DeWaaiBeheer
{
    public partial class frmUsersPage : Form
    {
        private CultureInfo ci = CultureInfo.InstalledUICulture;
        private DatabaseMethods db = new DatabaseMethods();
        private BindingSource binding;
        private Users user;

        public frmUsersPage()
        {
            InitializeComponent();
            tlpNavigation.Hide();

            user = new Users();
            binding = new BindingSource { DataSource = db.getUsers() };

            lstUsers.DataSource = binding;
            lstUsers.ValueMember = "ID";
            lstUsers.DisplayMember = "Fullname";

            cmbFunction.Items.Insert(0, "Cursist");
            cmbFunction.Items.Insert(1, "Instructeur");
            cmbFunction.Items.Insert(2, "Admin");
        }       

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Users user = lstUsers.SelectedItem as Users;           
            resetUsersBySelected(user);           
        }

        #region Methods
        public void updateListbox()
        {
            lstUsers.DataSource = null;
            lstUsers.DataSource = db.getUsers();
            lstUsers.DisplayMember = "Fullname";
        }
        #endregion

        #region Resetbinding
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
                cmbFunction.DataBindings.Clear();

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
                cmbFunction.DataBindings.Add("Text", user, "Function");
            }
        }
        #endregion

        #region User methods

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNewUser frmNewUsers = new frmNewUser();
            frmNewUsers.Show();
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
            int id = Convert.ToInt32(txtId.Text);

            foreach (Users u in db.GetUserByID(id))
            {
                u.Updated = DateTime.Now;
                break;
            }
            db.SaveChanges();

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

        private void btnCourses_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCoursesPage frmCourses = new frmCoursesPage();
            frmCourses.Show();
        }

        private void btnInstructors_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInstructorsPage frmInstructors = new frmInstructorsPage();
            frmInstructors.Show();
        }

        private void btnFleets_Click(object sender, EventArgs e)
        {
            this.Hide();
            VlotenPage frmFleets = new VlotenPage();
            frmFleets.Show();
        }

        private void btnPlanning_Click(object sender, EventArgs e)
        {
            this.Close();
            PlanningPage form = new PlanningPage();
            form.Show();
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

        #region Export to excel
        private void llUserExport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            // Prompt the user to enter a path/filename to save an example Excel file to
            saveFileDialog1.FileName = "Gebruikers.xlsx";
            saveFileDialog1.Filter = "Excel 2007 files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.OverwritePrompt = false;

            //  If the user hit Cancel, then abort!
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            string TargetFilename = saveFileDialog1.FileName;

            //  Step 1: Create a DataSet, and put some sample data in it
            DataSet ds = CreateData();

            //  Step 2: Create the Excel file
            try
            {
                CreateExcelFile.CreateExcelDocument(ds, TargetFilename);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is iets fouts gegaan, probeer het later opnieuw!.\r\nException: " + ex.Message);
                return;
            }

            //  Step 3:  Let's open our new Excel file and shut down this application.
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(TargetFilename);
            p.Start();

            this.Close();

            CreateData();
        }
        #endregion

        #region Create data for Excel
        private DataSet CreateData()
        {
            List<Users> us = db.getUsers().ToList();
            //  Create a sample DataSet, containing three DataTables.
            //  (Later, this will save to Excel as three Excel worksheets.)
            //
            DataSet ds = new DataSet();

            //  Create the first table of sample data
            DataTable dtUsers = new DataTable("Users");
            dtUsers.Columns.Add("ID", Type.GetType("System.Decimal"));
            dtUsers.Columns.Add("Voornaam", Type.GetType("System.String"));
            dtUsers.Columns.Add("Tussenvoegsel", Type.GetType("System.String"));
            dtUsers.Columns.Add("Achternam", Type.GetType("System.String"));
            dtUsers.Columns.Add("Straat", Type.GetType("System.String"));
            dtUsers.Columns.Add("Huisnummer", Type.GetType("System.String"));
            dtUsers.Columns.Add("Postcode", Type.GetType("System.String"));
            dtUsers.Columns.Add("Woonplaats", Type.GetType("System.String"));
            dtUsers.Columns.Add("Land", Type.GetType("System.String"));
            dtUsers.Columns.Add("Telefoonnummer", Type.GetType("System.String"));
            dtUsers.Columns.Add("Mobiel", Type.GetType("System.String"));
            dtUsers.Columns.Add("Email", Type.GetType("System.String"));
            dtUsers.Columns.Add("Functie", Type.GetType("System.String"));
            dtUsers.Columns.Add("Aangemaakt op", Type.GetType("System.DateTime"));

            foreach (var user in us)
            {
                dtUsers.Rows.Add(new object[] { user.ID, user.Firstname, user.Insertion, user.Surname, user.Street, user.HouseNumber, user.Zip, user.City, user.Country, user.Telephone, user.Mobile, user.Email, user.Function, user.Created});
            }
            ds.Tables.Add(dtUsers);

            return ds;
        }
        #endregion   
    }
}

