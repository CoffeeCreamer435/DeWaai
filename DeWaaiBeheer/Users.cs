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
    public partial class frmUsers : Form
    {
        private DatabaseMethods dm = new DatabaseMethods();
        private BindingSource BaseBinding = null;

        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            User customer = lstUsers.SelectedItem as User;
            BindingSource user = new BindingSource { DataSource = dm.getUsers() };
            ResetCijferBinding(cijfer);

        }
    }
}
