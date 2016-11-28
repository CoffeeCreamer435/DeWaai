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
    public partial class CoursesAddEditPage : Form
    {
        DatabaseMethods db = new DatabaseMethods();
        public CoursesAddEditPage()
        {
            InitializeComponent();
        }

        public void FillListCursussen()
        {
            lstCursussen.DataSource = db.getCourses();
            lstCursussen.ValueMember = "ID";
            lstCursussen.DisplayMember = "Name";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        private void btnInstrucors_Click(object sender, EventArgs e)
        {
            InstructeurPage instructors = new InstructeurPage();
            instructors.Show();
            this.Close();
        }

        private void btnFleet_Click(object sender, EventArgs e)
        {
            VlotenPage vloten = new VlotenPage();
            vloten.Show();
            this.Close();
        }
    }
}
