using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeWaaiBeheer.Inschrijvingen
{
    public partial class InschrijvingenPage : Form
    {
        DatabaseMethods db = new DatabaseMethods();
        //private BindingSource UserbyRegistration;
        public InschrijvingenPage()
        {
            InitializeComponent();
            FillInschrijvingenList();
        }

        private void lblNavigation_Click(object sender, EventArgs e)
        {
            if (tblNavigation.Visible == true)
            {
                tblNavigation.Visible = false;
            }
            else
            {
                tblNavigation.Visible = true;
            }
        }

        #region FillListboxes
        public void FillInschrijvingenList()
        {
            //BindingSource UsersbyRegistration = new BindingSource { DataSource = db.getUsersbyRegistration() };
           // lstInschrijvingen.DataSource = UsersbyRegistration;
            //lstInschrijvingen.DisplayMember = "FullName";
        }
        #endregion

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.home.Show();
        }
    }
}
