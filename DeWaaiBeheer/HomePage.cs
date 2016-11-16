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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnVerder_Click(object sender, EventArgs e)
        {
            Overzicht overzicht = new Overzicht();
            overzicht.Show();
            this.Hide();
        }
    }
}
