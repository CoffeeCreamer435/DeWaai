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
        public InschrijvingenPage()
        {
            InitializeComponent();
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
    }
}
