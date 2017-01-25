using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Validation;

namespace DeWaaiBeheer
{
    public partial class frmHome : Form
    {
        private DatabaseMethods db = new DatabaseMethods();
        private BindingSource registrations;

        public frmHome()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            myAccountToolStripMenuItem.Text = ("Mijn account");
            logoutToolStripMenuItem.Text = ("Uitloggen");
            nameToolStripMenuItem.Text = string.Format("{0}", Program.username);
           
            registrations = new BindingSource { DataSource = db.getUsersByRegistration() };
            lstUsers.ValueMember = "ID";
            lstUsers.DataSource = registrations;
        }

        private void myAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.account.ShowDialog();
        }

        #region SideMenu buttons
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }
        private void btnCourses_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCoursesPage frmCourse = new frmCoursesPage();
            frmCourse.Show();
            
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Close();
            frmUsersPage frmUser = new frmUsersPage();
            frmUser.Show();
        }

        private void btnInstructors_Click(object sender, EventArgs e)
        {
            this.Close();
            frmInstructorsPage frmInstructor = new frmInstructorsPage();
            frmInstructor.Show();
        }

        private void btnReviews_Click(object sender, EventArgs e)
        {
            this.Close();
            frmReviews reviews = new frmReviews();
            reviews.Show();
        }

        private void btnRegistrations_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTenders tenders = new frmTenders();
            tenders.Show();
        }

        private void btnFleets_Click(object sender, EventArgs e)
        {
            this.Close();
            VlotenPage frmFleets = new VlotenPage();
            frmFleets.Show();
        }

        private void btnTenders_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTenders frm = new frmTenders();
            frm.Show();
        }
        private void btnPlanning_Click(object sender, EventArgs e)
        {
            this.Close();
            PlanningPage form = new PlanningPage();
            form.Show();
        }
        #endregion   

        

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Registrations re = lstUsers.SelectedItem as Registrations;
            ResetId(re);
        }

        public void ResetId(Registrations r)
        {
            if(r != null)
            {
                lblId.DataBindings.Clear();

                lblId.DataBindings.Add("Text", r, "ID");
            }         
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //int ID = Convert.ToInt32(lblId.Text);
            //Registrations registration = db.GetRegistrationsByID(ID);
            //registration.Accepted = 1;
            //db.SaveChanges();
        }
    }
}
