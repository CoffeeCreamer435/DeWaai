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
    public partial class frmTenders : Form
    {
        DatabaseMethods db = new DatabaseMethods();
        public frmTenders()
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
        private void lstInschrijvingen_MouseClick(object sender, MouseEventArgs e)
        {
            Registrations registration = lstInschrijvingen.SelectedItem as Registrations;
            int ID = Convert.ToInt32(lstInschrijvingen.SelectedValue);
            if (ID != 0)
            {
                FillRegistration(db.GetRegistrationsByID(ID));
            }
            FillInschrijvingenList();
        }
        #endregion

        #region filling txtboxes with data
        private void  FillRegistration(Registrations registration)
        {
            if (registration != null)
            {
                txtNaam.DataBindings.Clear();
                txtInvoice.DataBindings.Clear();
                txtGeboektemaand.DataBindings.Clear();
                lblCursus.DataBindings.Clear();
                lblRegID.DataBindings.Clear();
                cmbCursus.DataBindings.Clear();

                cmbCursus.DataBindings.Add("Text", db.GetCoursesbyID(registration.CourseID.Value), "Name");
                lblRegID.DataBindings.Add("Text", registration, "ID");
                lblCursus.DataBindings.Add("Text", registration, "CourseID");
                txtNaam.DataBindings.Add("Text", db.getRegistrationUsersByID(registration.UserID.Value), "Firstname");
                txtInvoice.DataBindings.Add("Text", registration, "InvoiceID");
                txtGeboektemaand.DataBindings.Add("Text", registration, "Booking_month");
            }
        }
        #endregion

        private void btnAccepteren_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(lstInschrijvingen.SelectedValue);
            Registrations registration = db.GetRegistrationsByID(ID);
            registration.Accepted = 1;
            db.SaveChanges();
        }

        private void btnWeigeren_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(lstInschrijvingen.SelectedValue);
            db.RemoveRegistrationByID(ID);
            db.SaveChanges();
            FillInschrijvingenList();
        }
    }
}
