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
    public partial class frmCourses : Form
    {
        DatabaseMethods db = new DatabaseMethods();
        public frmCourses()
        {
            InitializeComponent();
            FillListCursussen();
        }
        #region FillList
        public void FillListCursussen()
        {
            lstCursussen.DataSource = db.getCourses();
            lstCursussen.ValueMember = "ID";
            lstCursussen.DisplayMember = "Title";
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        #region Mernu Buttons
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


        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUsers users = new frmUsers();
            users.Show();
            this.Hide();
        }
        #endregion
        private void btnNew_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
