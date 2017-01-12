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
            //FillCursusBox();
            //FillStatusBox();
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
           // lstInschrijvingen.DisplayMember = "ID";
        }

        public void FillStatusBox()
        {
            cmbStatus.Items.Add("Goedgekeurd");
            cmbStatus.Items.Add("Afgekeurd");
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
            this.Hide();
            frmHome home = new frmHome();
            home.Show();
        }
        #endregion
        #region selected index changed
        private void lstInschrijvingen_SelectedIndexChanged(object sender, EventArgs e)
        {
            Registrations registration = lstInschrijvingen.SelectedItem as Registrations;
            lstInschrijvingen.DataSource = db.getUsersAndCoursesbyRegistration();
            FillRegistration(registration);
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
                //cmbStatus.DataBindings.Clear();

                cursusid = registration.CourseID.Value;
                cmbCursus.DataBindings.Add("Text", db.GetCoursesbyID(cursusid), "Name");
                txtNaam.DataBindings.Add("Text", registration, "UserID");
                txtInvoice.DataBindings.Add("Text", registration, "InvoiceID");
                //cmbStatus.DataBindings.Add("Text", registration, "Status");
            }
        }
        #endregion
    }
}
