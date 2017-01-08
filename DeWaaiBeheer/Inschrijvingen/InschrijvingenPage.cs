using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeWaaiBeheer.Inschrijvingen
{
    public partial class InschrijvingenPage : Form
    {
        DatabaseMethods db = new DatabaseMethods();
        int cursusid;
        //private BindingSource UserbyRegistration;
        public InschrijvingenPage()
        {
            InitializeComponent();
            FillInschrijvingenList();
            FillCursusBox();
        }
        #region side menu lbl
        private void lblNavigation_Click(object sender, EventArgs e)
        {
            if (tblNavigation.Visible == true)
            {
                tblNavigation.Visible = false;
            }
            else
            {
                tblNavigation.Visible = true;
            }
        }
        #endregion
        #region FillListboxes
        public void FillInschrijvingenList()
        {
            BindingSource inschrijvingen = new BindingSource { DataSource = db.getUsersAndCoursesbyRegistration() };
            lstInschrijvingen.DataSource = inschrijvingen;
            lstInschrijvingen.ValueMember = "ID";
            lstInschrijvingen.DisplayMember = "Display";
            
        }

        public void FillCursusBox()
        {
            cmbCursus.DataSource = db.getCourses();
            cmbCursus.ValueMember = "ID";
            cmbCursus.DisplayMember = "Name";
        }
        #endregion
        #region menu buttons   
        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHome home = new frmHome();
            home.Show();
        }
        #endregion
        #region selected index changed
        private void lstInschrijvingen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Registrations registration = lstInschrijvingen.SelectedItem as Registrations;
            //lstInschrijvingen.DataSource = db.getUsersAndCoursesbyRegistration();
            //FillRegistration(registration);
        }
        #endregion

        #region filling txtboxes with data
        private void  FillRegistration(Registrations registration)
        {
            if (registration != null)
            {
                cmbCursus.DataBindings.Clear();
                txtInvoice.DataBindings.Clear();
                txtNaam.DataBindings.Clear();
                dateTimePicker1.DataBindings.Clear();
                txtGeboektemaand.DataBindings.Clear();
                //cmbStatus.DataBindings.Clear();

                cursusid = registration.CourseID.Value;
                cmbCursus.DataBindings.Add("Text", db.GetCoursesbyID(cursusid), "Name");
                txtNaam.DataBindings.Add("Text", registration, "UserID");
                txtInvoice.DataBindings.Add("Text", registration, "InvoiceID");
                txtGeboektemaand.DataBindings.Add("Text", registration, "Booking_Month");
                //cmbStatus.DataBindings.Add("Text", registration, "Status");
            }
        }
        #endregion

        private void btnAccepteren_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(lstInschrijvingen.SelectedValue);
            foreach (Registrations re in db.GetRegistrationsByID(ID))
            {
                re.Accepted = 1;
                db.SaveChanges();
                break;
            }
        }
    }
}
