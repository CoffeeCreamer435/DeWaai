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

            foreach (Courses co in db.getCourses())
            {
                if (!String.IsNullOrEmpty(txtName.Text) || !String.IsNullOrEmpty(txtDescription.Text) || !String.IsNullOrEmpty(dtpDate.Text) || !String.IsNullOrEmpty(txtPrice.Text) || !String.IsNullOrEmpty(txtAmount.Text) || !String.IsNullOrEmpty(txtColor.Text))
                {
                    if (name != co.Name)
                    {
                        co.Name = txtName.Text;
                        co.Description = txtDescription.Text;
                        co.Date = date;
                        co.Price = Convert.ToInt32(txtPrice.Text);
                        co.Amount = Convert.ToInt32(txtAmount.Text);
                        co.Color = txtColor.Text;
                      
                        db.AddCourse(co);
                        db.SaveChanges();

                        MessageBox.Show("Cursus is succesvol toegevoegd!");
                        this.Close();
                        break;

                    }
                    else
                    {
                        MessageBox.Show("Deze cursus bestaat al!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("U heeft een aantal verplichte velden niet ingevuld!");
                    break;
                }

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
