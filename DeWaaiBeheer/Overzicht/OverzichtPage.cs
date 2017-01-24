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
    public partial class frmReviews : Form
    {
        
        DatabaseMethods db = new DatabaseMethods();
        
        public frmReviews()
        {
            InitializeComponent();
            FillListbox();
        }

        public void FillListbox()
        {
            lstRecensies.DataSource = db.getNotApprovedFeedback();
            lstRecensies.ValueMember = "ID";
        }

        private void lstRecensies_Format(object sender, ListControlConvertEventArgs e)
        {
            string Title = ((CustomerFeedback)e.ListItem).Title.ToString();
            string Description = ((CustomerFeedback)e.ListItem).Description.ToString();
            string Name = ((CustomerFeedback)e.ListItem).Name.ToString();
            String Date = ((CustomerFeedback)e.ListItem).Date.ToString();
            String Stars = ((CustomerFeedback)e.ListItem).Stars.ToString();
            String Approved = ((CustomerFeedback)e.ListItem).Approved.ToString();

            e.Value = Name + " - " + Title + " Sterren: " + Stars;
        }

        #region fillRecensies
        private void FillRecensies(CustomerFeedback feedback)
        {
            if (feedback != null)
            {

                //cmbStatus.DataBindings.Clear();
                txtNaam.DataBindings.Clear();
                txtTitle.DataBindings.Clear();
                txtMessage.DataBindings.Clear();
                txtStars.DataBindings.Clear();
                lbltest.DataBindings.Clear();

                //cmbStatus.DataBindings.Add("Text", registration, "Status");
                txtNaam.DataBindings.Add("Text", feedback, "Name");
                txtTitle.DataBindings.Add("Text", feedback, "Title");
                txtMessage.DataBindings.Add("Text", feedback, "Description");
                txtStars.DataBindings.Add("Text", feedback, "Stars");
                lbltest.DataBindings.Add("Text", feedback, "ID");
            }   
        }
        #endregion

        private void lstRecensies_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerFeedback feedback = lstRecensies.SelectedItem as CustomerFeedback;
            FillRecensies(feedback);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(lbltest.Text);
            foreach (CustomerFeedback fb in db.getFeedbackById(ID))
            {
                fb.Approved = true;
                db.SaveChanges();
                break;
            }
            lstRecensies_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(lbltest.Text);
            foreach (CustomerFeedback fb in db.getFeedbackById(ID))
            {
                db.RemoveFeedback(ID);
                lstRecensies_SelectedIndexChanged(this, EventArgs.Empty);
            }
        }

        #region SideMenu Buttons

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Close();
            frmUsersPage frmUsers = new frmUsersPage();
            frmUsers.Show();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCoursesPage frmCourses = new frmCoursesPage();
            frmCourses.Show();
        }

        private void btnInstrucors_Click(object sender, EventArgs e)
        {
            this.Close();
            frmInstructorsPage frmInstructors = new frmInstructorsPage();
            frmInstructors.Show();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHome home = new frmHome();
            home.Show();
        }

        private void btnInschrijvingen_Click(object sender, EventArgs e)
        {
            this.Close();
            frmInstructorsPage inschrijvingen = new frmInstructorsPage();
            inschrijvingen.Show();
        }

        private void btnFleet_Click(object sender, EventArgs e)
        {
            this.Close();
            VlotenPage vloten = new VlotenPage();
            vloten.Show();
        }

        private void btnPlanning_Click(object sender, EventArgs e)
        {
            this.Close();
            PlanningPage planning = new PlanningPage();
            planning.Show();
        }
        #endregion

        private void lblNavigation_Click(object sender, EventArgs e)
        {
            if (tblNavigation.Visible == false)
            {
                tblNavigation.Visible = true;
            }
            else
            {
                tblNavigation.Visible = false;
            }
        }
    }

 
    }

