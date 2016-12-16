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
    public partial class frmNewCourse : Form
    {
        private DatabaseMethods db = new DatabaseMethods();
        private BindingSource courses;
        private Courses course;

        public frmNewCourse()
        {
            InitializeComponent();
            course = new Courses();
            courses = new BindingSource();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string date = dtpDate.Value.ToShortDateString();
            string name = txtName.Text;

            if (!String.IsNullOrEmpty(txtName.Text) && !String.IsNullOrEmpty(txtDescription.Text) && !String.IsNullOrEmpty(txtPrice.Text) && !String.IsNullOrEmpty(txtAmount.Text) && !String.IsNullOrEmpty(txtColor.Text))
            {
                if (name != course.Name)
                {
                    course.Name = txtName.Text;
                    course.Description = txtDescription.Text;
                    course.Date = date;
                    course.Price = Convert.ToInt32(txtPrice.Text);
                    course.Amount = Convert.ToInt32(txtAmount.Text);
                    course.Color = txtColor.Text;

                    db.AddCourse(course);
                    db.SaveChanges();
                    Program.courses.updateListbox();

                    MessageBox.Show("Cursus is succesvol toegevoegd!");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Deze cursus bestaat al!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("U heeft een aantal verplichte velden niet ingevuld!");
            }

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
           NumberOnly(sender, e);
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
           NumberOnly(sender, e);
        }

        public void NumberOnly(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
