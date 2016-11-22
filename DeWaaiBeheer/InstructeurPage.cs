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
    public partial class InstructeurPage : Form
    {
        u480787545_dewaaEntities ef = new u480787545_dewaaEntities();
        public InstructeurPage()
        {
            InitializeComponent();
        }

        public void fillListBox()
        {
            lstInstructeurs.DataSource = ef.Instructors.ToList();
            lstInstructeurs.ValueMember = "ID";
            lstInstructeurs.DisplayMember = "Name";
        }
    }
}
