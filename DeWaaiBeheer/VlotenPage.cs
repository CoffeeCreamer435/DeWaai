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
            fillComboStatus();
            fillComboSoorten();
        }

        #region FillingCombo/Lists
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

        public void fillComboSoorten()
        {
            cmbSoortSchip.DataSource = db.GetBoatTypes();
            cmbSoortSchip.ValueMember = "ID";
            cmbSoortSchip.DisplayMember = "Name";
        }

        public void fillComboStatus()
        {
            cmbStatus.DataSource = db.getFleet();
            cmbStatus.ValueMember = "Status";
            cmbStatus.DisplayMember = "Status";
        }
        #endregion

        private void btnVlootSave_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        private void btnBootSave_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        #region SideMenu Buttons

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUsers users = new frmUsers();
            users.Show();
            this.Close();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            //CoursesAddEditPage users = new CoursesAddEditPage();
            //users.Show();
            //this.Close();
        }

        private void btnInstrucors_Click(object sender, EventArgs e)
        {
            InstructeurPage instructors = new InstructeurPage();
            instructors.Show();
            this.Close();
        }
        #endregion
    }
}
