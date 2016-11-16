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
    public partial class frmHome : Form
    {
        
        public frmHome()
        {
            InitializeComponent();
        }

        private void frnHome_Load(object sender, EventArgs e)
        {
            tlpMain.Hide();
            Program.login.Owner = this;
            Program.login.ShowDialog();
        }
    }
}
