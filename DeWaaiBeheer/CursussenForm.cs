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
        private DatabaseMethods dm = new DatabaseMethods();
        public frmCourses()
        {
            InitializeComponent();
            FillListBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReadTextbox();
            
        }

        public void FillListBox()
        {
            lstCursussen.DataSource = dm.getCursussen();
            lstCursussen.DisplayMember = "Title";
            lstCursussen.ValueMember = "ID";

        }

        public void ReadTextbox()
        {
            String Title = txtTitle.Text;
            String Text = txtText.Text;
            String Price = txtPrice.Text;
            String Img = txtImg.Text;
        }
    }
}
