﻿using System;
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
    public partial class CursusPage : Form
    {
        u480787545_dewaaEntities ef = new u480787545_dewaaEntities();
        public CursusPage()
        {
            InitializeComponent();
            FillCursussenList();
            fillComboCursussen();
        }

        public void FillCursussenList()
        {
            lstNieuweOverzichten.DataSource = ef.Courses.ToList();
            lstNieuweOverzichten.ValueMember = "ID";
            lstNieuweOverzichten.DisplayMember = "Title";
        }

        public void fillComboCursussen()
        {
            cmbCursussen.DataSource = ef.Courses.ToList();
            cmbCursussen.ValueMember = "ID";
            cmbCursussen.DisplayMember = "Title";
        }

        private void btnAccepteer_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnWeiger_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CursusPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.cursus.Hide();
        }
    }
}
