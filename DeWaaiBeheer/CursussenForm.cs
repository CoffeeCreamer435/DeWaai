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

        String Title;
        String TextString;
        int Price;
        String Img;

        private DatabaseMethods dm = new DatabaseMethods();
        public frmCourses()
        {
            InitializeComponent();
            FillCursusBox();
            FillNewAanmeldingen();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          ReadTextbox();
            dm.addCursussen(TextString, Price, Title, Img);
        }

        public void FillCursusBox()
        {
            cmbCursussen.DataSource = dm.getCourses().ToList();
            cmbCursussen.DisplayMember = "Title";
            cmbCursussen.ValueMember = "ID";
        }

        public void FillNewAanmeldingen()
        {
            lstAanmeldingen.DataSource = dm.getCourses();
            lstAanmeldingen.DisplayMember = "Title";
            lstAanmeldingen.ValueMember = "ID";
        }

        public void ReadTextbox()
        {
            Title = txtTitle.Text;
            Text = txtText.Text;
            Price = Int32.Parse(txtPrice.Text);
            Img = txtImg.Text;
        }
    }
}
