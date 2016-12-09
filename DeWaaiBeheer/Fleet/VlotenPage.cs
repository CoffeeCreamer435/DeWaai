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
        private BindingSource vloten;
        private BindingSource boattypes;
        Fleet fleet = new Fleet();
        Types types = new Types();
        private DatabaseMethods db = new DatabaseMethods();

        public VlotenPage()
        {
            InitializeComponent();
            fillVlotenBox();
            fillBootSoortenBox();
            fillComboStatus();
            fillComboSoorten();
           
        }

        #region fillboatbyselectedboat
        private void fillBoatsBySelectedBoat(Fleet fleet)
        {
            if (fleet != null)
            {
                lblID.DataBindings.Clear();
                txtNaamVloot.DataBindings.Clear();
                txtAantal.DataBindings.Clear();
                cmbStatus.DataBindings.Clear();

                lblID.DataBindings.Add("Text", fleet, "ID");
                txtNaamVloot.DataBindings.Add("Text", fleet, "Name");
                txtAantal.DataBindings.Add("Text", fleet, "Amount");
                cmbStatus.DataBindings.Add("Text", fleet, "Status");
            }
        }

        private void FillTypesBySelectedType(Types type)
        {
            if (type != null)
            {
                lblIDTypes.DataBindings.Clear();
                txtNaam.DataBindings.Clear();
                txtCapaciteit.DataBindings.Clear();

                lblIDTypes.DataBindings.Add("Text", type, "ID");
                txtNaam.DataBindings.Add("Text", type, "Name");
                txtCapaciteit.DataBindings.Add("Text", type, "Capacity");
            }
        }
        #endregion  

        #region FillingCombo/Lists
        public void fillVlotenBox()
        {
            lstVloot.DataSource = db.getFleet();
            lstVloot.DisplayMember = "Name";
            lstVloot.ValueMember = "ID";
        }

        public void fillBootSoortenBox()
        {
            lstBootSoorten.DataSource = db.GetBoatTypes();
            lstBootSoorten.DisplayMember = "Name";
            lstBootSoorten.ValueMember = "ID";

        }

        public void fillComboSoorten()
        {
            cmbSoortSchip.DataSource = db.GetBoatTypes();
            cmbSoortSchip.ValueMember = "ID";
            cmbSoortSchip.DisplayMember = "Name";
        }

        public void fillComboStatus()
        {
            cmbStatus.DataSource = db.getFleet();
            cmbStatus.ValueMember = "Status";
            cmbStatus.DisplayMember = "Status";
        }
        #endregion

        #region BoatButtons
        private void btnVlootSave_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            lstBootSoorten_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (lblID.Text != null)
            {
                id = Convert.ToInt32(lblID.Text);
            }
            else
            {
                id = 0;
            }
            if (MessageBox.Show("Weet u zeker dat u deze Vloot wilt verwijderen?", "Informatie", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                for (int i = lstVloot.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    if (lstVloot.SelectedItem != null)
                    {
                        db.RemoveFleet(id);
                        db.SaveChanges();

                        lstVloot.DataSource = null;
                        vloten = new BindingSource { DataSource = db.getFleet() };
                        lstVloot.DataSource = vloten;
                        lstVloot.DisplayMember = "Name";
                        lstBootSoorten_SelectedIndexChanged(this, EventArgs.Empty);
                    }
                }
            }
        }

        private void btnNewFleet_Click(object sender, EventArgs e)
        {
            fleet.Amount = 0;
            fleet.Name = "Voer nieuwe naam in";
            fleet.TypeID = 4;
            fleet.Status = "Gereed";
            db.AddFleet(fleet);
            db.SaveChanges();

            lstBootSoorten_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            lstBootSoorten_SelectedIndexChanged(this, EventArgs.Empty);
        }

        #endregion

        #region SideMenu Buttons

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUsers users = new frmUsers();
            users.Show();
            this.Close();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.courses.Show();
        }

        private void btnInstrucors_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.instructors.Show();
        }
        #endregion

        #region selected index changed
        private void lstVloot_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fleet fleet = lstVloot.SelectedItem as Fleet;
            lstVloot.DataSource = db.getFleet();
            fillBoatsBySelectedBoat(fleet);
        }

        private void lstBootSoorten_SelectedIndexChanged(object sender, EventArgs e)
        {
            Types type = lstBootSoorten.SelectedItem as Types;
            lstBootSoorten.DataSource = db.GetBoatTypes();
            FillTypesBySelectedType(type);
        }

        #endregion

        #region TypesButtons
        private void btnDeleteType_Click(object sender, EventArgs e)
        {
            int id;
            if (lblIDTypes.Text != null)
            {
                id = Convert.ToInt32(lblIDTypes.Text);
            }
            else
            {
                id = 0;
            }
            if (MessageBox.Show("Weet u zeker dat u deze Boot wilt verwijderen?", "Informatie", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                for (int i = lstBootSoorten.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    if (lstBootSoorten.SelectedItem != null)
                    {
                        db.RemoveBoatType(id);
                        db.SaveChanges();

                        lstBootSoorten.DataSource = null;
                        boattypes = new BindingSource { DataSource = db.GetBoatTypes() };
                        lstBootSoorten.DataSource = boattypes;
                        lstBootSoorten.DisplayMember = "Name";

                        lstBootSoorten_SelectedIndexChanged(this, EventArgs.Empty);
                    }
                }
            }
        }
        #endregion

        private void VlotenPage_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #region Boat Type buttons
        private void btnNewType_Click(object sender, EventArgs e)
        {
                types.Name = "Voer nieuwe naam in.";
                types.Capacity = 0;
                db.AddBoatType(types);
                db.SaveChanges();

            lstBootSoorten_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void btnSaveTypes_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            lstBootSoorten_SelectedIndexChanged(this, EventArgs.Empty);
        }
        #endregion
    }
}
