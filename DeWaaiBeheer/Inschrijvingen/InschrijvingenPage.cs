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
        #endregion

        #region menu buttons   
        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHome home = new frmHome();
            home.Show();
        }

        private void btnPlanning_Click(object sender, EventArgs e)
        {
            this.Close();
            PlanningPage planning = new PlanningPage();
            planning.Show();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCoursesPage courses = new frmCoursesPage();
            courses.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Close();
            frmUsersPage users = new frmUsersPage();
            users.Show();
        }

        private void btnInstrucors_Click(object sender, EventArgs e)
        {
            this.Close();
            frmInstructorsPage instructors = new frmInstructorsPage();
            instructors.Show();
        }

        private void btnFleet_Click(object sender, EventArgs e)
        {
            this.Close();
            VlotenPage vloten = new VlotenPage();
            vloten.Show();
        }

        private void btnRecensies_Click(object sender, EventArgs e)
        {
            this.Close();
            frmReviews reviews = new frmReviews();
            reviews.Show();
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
                txtDate.DataBindings.Clear();       

                cmbCursus.DataBindings.Add("Text", db.GetCoursesbyID(registration.CourseID.Value), "Name");
                lblRegID.DataBindings.Add("Text", registration, "ID");
                lblCursus.DataBindings.Add("Text", registration, "CourseID");
                txtNaam.DataBindings.Add("Text", db.getRegistrationUsersByID(registration.UserID.Value), "Firstname");
                txtInvoice.DataBindings.Add("Text", registration, "InvoiceID");
                txtGeboektemaand.DataBindings.Add("Text", registration, "Booking_month");
                txtDate.DataBindings.Add("Text", registration, "Date");
            }
        }
        #endregion
        #region Buttons
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

        #endregion
    }
}
