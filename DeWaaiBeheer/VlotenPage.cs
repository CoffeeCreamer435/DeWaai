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
        u480787545_dewaaEntities ef = new u480787545_dewaaEntities();
        public VlotenPage()
        {
            InitializeComponent();
            fillVlotenBox();
            fillBootSoortenBox();
        }

        public void fillVlotenBox()
        {
            lstVloot.DataSource = ef.Fleet.ToList();
            lstVloot.DisplayMember = "Name";
            lstVloot.ValueMember = "ID";
        }

        public void fillBootSoortenBox()
        {
            lstBootSoorten.DataSource = ef.Types.ToList();
            lstBootSoorten.DisplayMember = "Name";
            lstBootSoorten.ValueMember = "ID";

        }
    }
}
