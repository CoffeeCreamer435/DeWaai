using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeWaaiBeheer.Overzicht
{
    public partial class OverzichtPage : Form
    {
        
        DatabaseMethods db = new DatabaseMethods();
        
        public OverzichtPage()
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
            lstRecensies.DataSource = db.getNotApprovedFeedback();
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

    }
}
