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
    public partial class VlotenPage : Form
    {
        DatabaseMethods db = new DatabaseMethods();
        public VlotenPage()
        {
            InitializeComponent();
            fillVlotenBox();
            fillBootSoortenBox();
        }

        public void fillVlotenBox()
        {
            lstVloot.DataSource = db.getFleet();
            lstVloot.DisplayMember = "Name";
            lstVloot.ValueMember = "ID";
        }

        public void fillBootSoortenBox()
        {
            lstBootSoorten.DataSource = db.GetBoatTypes();
            lstBootSoorten.DisplayMember = "Name";
            lstBootSoorten.ValueMember = "ID";

        }

        private void btnVlootSave_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        private void btnBootSave_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

      
        private void btnFleet_Click(object sender, EventArgs e)
        {

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {

        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            CoursesAddEditPage users = new CoursesAddEditPage();
            users.Show();
            this.Close();
        }

        private void btnInstrucors_Click(object sender, EventArgs e)
        {
            InstructeurPage instructors = new InstructeurPage();
            instructors.Show();
            this.Close();
        }
    }
}
