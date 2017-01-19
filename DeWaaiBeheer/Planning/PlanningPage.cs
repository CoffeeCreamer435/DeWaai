using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeWaaiBeheer.Planning
{
    public partial class PlanningPage : Form
    {
        DatabaseMethods db = new DatabaseMethods();
        public PlanningPage()
        {
            InitializeComponent();
            FillListBox();
        }

        #region Fill ListBox
        public void FillListBox()
        {
            BindingSource inschrijvingen = new BindingSource { DataSource = db.getAcceptRegistrations() };
            lstPlanning.DataSource = inschrijvingen;
            lstPlanning.ValueMember = "ID";
            lstPlanning.DisplayMember = "Display";
        }

        public void FillCalendar()
        {
            BindingSource courses = new BindingSource { DataSource = db.getCourses() };
            //MonthCalendar.DataBindings = courses;
        }

        #endregion

        private void FillTextboxes(Registrations registration)
        {
            if (registration != null)
            {
                txtNaam.DataBindings.Clear();
                txtInvoice.DataBindings.Clear();
                txtGeboektemaand.DataBindings.Clear();
                cmbCursus.DataBindings.Clear();

                int usersid = registration.UserID.Value;
                txtInvoice.DataBindings.Add("Text", registration, "InvoiceID");
                txtNaam.DataBindings.Add("Text", db.getUserByID(registration.UserID.Value), "Firstname");
            }
        }
        private void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            System.DateTime Date = MonthCalendar.SelectionStart.Date;
            FillTextboxes(db.getRegistrationByDate(Date));
            
       } 
    }
}
