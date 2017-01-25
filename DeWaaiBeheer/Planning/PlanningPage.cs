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
    public partial class PlanningPage : Form
    {
        DatabaseMethods db = new DatabaseMethods();
        public PlanningPage()
        {
            InitializeComponent();
        }

        #region Fill ListBox
        public void FillListBox(System.DateTime Date)
        {
            BindingSource inschrijvingen = new BindingSource { DataSource = db.getAcceptRegistrations(Date) };
            lstPlanning.DataSource = inschrijvingen;
            lstPlanning.ValueMember = "ID";
            lstPlanning.DisplayMember = "Display";
        }

        #endregion

        private void FillTextboxes(Registrations registration)
        {
            if (registration != null)
            {
                txtNaam.DataBindings.Clear();
                txtInvoice.DataBindings.Clear();
                txtGeboektemaand.DataBindings.Clear();
                txtCursus.DataBindings.Clear();
                txtVloot.DataBindings.Clear();
                txtDate.DataBindings.Clear();

                int CourseID = registration.CourseID.Value;
                txtCursus.DataBindings.Add("Text", db.GetCoursesbyID(registration.CourseID.Value), "Name");
                txtNaam.DataBindings.Add("Text", db.getRegistrationUsersByID(registration.UserID.Value), "Firstname");
                txtInvoice.DataBindings.Add("Text", registration, "InvoiceID");
                txtVloot.DataBindings.Add("Text", db.getFleetByID(CourseID), "Name");
                txtGeboektemaand.DataBindings.Add("Text", registration, "Booking_month");
                txtDate.DataBindings.Add("Text", registration, "Date");
            }
        }
        private void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            System.DateTime Date = MonthCalendar.SelectionStart.Date;
            FillListBox(Date);
            
       }

        private void lstPlanning_MouseClick(object sender, MouseEventArgs e)
        {
            String ID = lstPlanning.SelectedValue.ToString();
            int IDint = Convert.ToInt32(ID);
            FillTextboxes(db.GetRegistrationsByID(IDint));
        }

        private void lblNavigation_Click(object sender, EventArgs e)
        {
            tblNavigation.Visible = true;
        }

        #region SideMenu Buttons
        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHome home = new frmHome();
            home.Show();
        }

        private void btnRecensies_Click(object sender, EventArgs e)
        {
            this.Close();
            frmReviews reviews = new frmReviews();
            reviews.Show();
        }

        private void btnRcensies_Click(object sender, EventArgs e)
        {
            this.Close();
            frmReviews reviews = new frmReviews();
            reviews.Show();
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

        private void btnInschrijvingen_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTenders inschrijvingen = new frmTenders();
            inschrijvingen.Show();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCoursesPage cursus = new frmCoursesPage();
            cursus.Show();
        }

        #endregion


    }
}
