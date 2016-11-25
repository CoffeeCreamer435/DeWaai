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
    public partial class UserOverzichtPage : Form
    {
        u480787545_dewaaEntities ef = new u480787545_dewaaEntities();
        public UserOverzichtPage()
        {
            InitializeComponent();
        }

        public void FillListCursussen()
        {
            lstCursussen.DataSource = ef.Courses.ToList();
            lstCursussen.ValueMember = "ID";
            lstCursussen.DisplayMember = "Name";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ef.SaveChanges();
        }

        private void btnInstrucors_Click(object sender, EventArgs e)
        {
            InstructeurPage instructors = new InstructeurPage();
            instructors.Show();
            this.Close();
        }
    }
}
