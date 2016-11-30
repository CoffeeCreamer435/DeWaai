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
    public partial class InstructeurPage : Form
    {
        DatabaseMethods db = new DatabaseMethods();
        public InstructeurPage()
        {
            InitializeComponent();
            fillComboCursusbox();
            fillListBox();
        }

        public void fillListBox()
        {
            lstInstructeurs.DataSource = db.GetInstructors();
            lstInstructeurs.ValueMember = "ID";
            lstInstructeurs.DisplayMember = "Name";
        }

        public void fillComboCursusbox()
        {
            cmbCursussen.DataSource = db.getCourses();
            cmbCursussen.ValueMember = "ID";
            cmbCursussen.DisplayMember = "Title";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        #region SideMenu Buttons
        private void btnCourses_Click(object sender, EventArgs e)
        {
            //CoursesAddEditPage users = new CoursesAddEditPage();
            //users.Show();
            //this.Close();

        }

        private void btnFleet_Click(object sender, EventArgs e)
        {
            VlotenPage vloten = new VlotenPage();
            vloten.Show();
            this.Close();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUsers users = new frmUsers();
            users.Show();
            this.Close();
        }

        #endregion
        private void btnNew_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
