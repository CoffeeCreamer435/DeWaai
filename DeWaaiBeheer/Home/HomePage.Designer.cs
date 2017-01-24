﻿namespace DeWaaiBeheer
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnReviews = new System.Windows.Forms.Button();
            this.btnTenders = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.msName = new System.Windows.Forms.MenuStrip();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInstructors = new System.Windows.Forms.Button();
            this.btnFleets = new System.Windows.Forms.Button();
            this.tlpDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.btnPlanning = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.msName.SuspendLayout();
            this.tlpDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 5;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.4908F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.04843F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.90142F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.67002F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.88934F));
            this.tlpMain.Controls.Add(this.btnReviews, 4, 3);
            this.tlpMain.Controls.Add(this.btnTenders, 4, 2);
            this.tlpMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlpMain.Controls.Add(this.btnCourses, 4, 4);
            this.tlpMain.Controls.Add(this.btnUsers, 4, 5);
            this.tlpMain.Controls.Add(this.label1, 4, 1);
            this.tlpMain.Controls.Add(this.label2, 0, 1);
            this.tlpMain.Controls.Add(this.btnInstructors, 4, 6);
            this.tlpMain.Controls.Add(this.btnFleets, 4, 7);
            this.tlpMain.Controls.Add(this.tlpDashboard, 0, 2);
            this.tlpMain.Controls.Add(this.label17, 3, 2);
            this.tlpMain.Controls.Add(this.btnPlanning, 4, 8);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 9;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.534246F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.621005F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.32877F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.38486F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.95896F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.95896F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.95896F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.95896F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.96256F));
            this.tlpMain.Size = new System.Drawing.Size(1091, 438);
            this.tlpMain.TabIndex = 0;
            // 
            // btnReviews
            // 
            this.btnReviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReviews.Location = new System.Drawing.Point(787, 119);
            this.btnReviews.Name = "btnReviews";
            this.btnReviews.Size = new System.Drawing.Size(301, 52);
            this.btnReviews.TabIndex = 3;
            this.btnReviews.Text = "Recensies";
            this.btnReviews.UseVisualStyleBackColor = true;
            this.btnReviews.Click += new System.EventHandler(this.btnReviews_Click);
            // 
            // btnTenders
            // 
            this.btnTenders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTenders.Location = new System.Drawing.Point(787, 65);
            this.btnTenders.Name = "btnTenders";
            this.btnTenders.Size = new System.Drawing.Size(301, 48);
            this.btnTenders.TabIndex = 4;
            this.btnTenders.Text = "Inschrijvingen";
            this.btnTenders.Click += new System.EventHandler(this.btnTenders_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tlpMain.SetColumnSpan(this.tableLayoutPanel1, 5);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.60287F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.39713F));
            this.tableLayoutPanel1.Controls.Add(this.msName, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1085, 27);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // msName
            // 
            this.msName.BackColor = System.Drawing.SystemColors.Control;
            this.msName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msName.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem});
            this.msName.Location = new System.Drawing.Point(0, 0);
            this.msName.Name = "msName";
            this.msName.Size = new System.Drawing.Size(397, 27);
            this.msName.TabIndex = 0;
            this.msName.Text = "menuStrip1";
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.BackColor = System.Drawing.Color.DarkCyan;
            this.nameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myAccountToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.nameToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.nameToolStripMenuItem.Text = "Name";
            // 
            // myAccountToolStripMenuItem
            // 
            this.myAccountToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.myAccountToolStripMenuItem.Name = "myAccountToolStripMenuItem";
            this.myAccountToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.myAccountToolStripMenuItem.Text = "My account";
            this.myAccountToolStripMenuItem.Click += new System.EventHandler(this.myAccountToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourses.Location = new System.Drawing.Point(787, 177);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(301, 46);
            this.btnCourses.TabIndex = 4;
            this.btnCourses.Text = "Cursussen";
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Location = new System.Drawing.Point(787, 229);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(301, 46);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "Klanten";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(787, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Overzichten";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tlpMain.SetColumnSpan(this.label2, 3);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(760, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dashboard";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnInstructors
            // 
            this.btnInstructors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInstructors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructors.Location = new System.Drawing.Point(787, 281);
            this.btnInstructors.Name = "btnInstructors";
            this.btnInstructors.Size = new System.Drawing.Size(301, 46);
            this.btnInstructors.TabIndex = 10;
            this.btnInstructors.Text = "Instructeurs";
            this.btnInstructors.UseVisualStyleBackColor = true;
            this.btnInstructors.Click += new System.EventHandler(this.btnInstructors_Click);
            // 
            // btnFleets
            // 
            this.btnFleets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFleets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFleets.Location = new System.Drawing.Point(787, 333);
            this.btnFleets.Name = "btnFleets";
            this.btnFleets.Size = new System.Drawing.Size(301, 46);
            this.btnFleets.TabIndex = 11;
            this.btnFleets.Text = "Vloten";
            this.btnFleets.UseVisualStyleBackColor = true;
            this.btnFleets.Click += new System.EventHandler(this.btnFleets_Click);
            // 
            // tlpDashboard
            // 
            this.tlpDashboard.ColumnCount = 5;
            this.tlpMain.SetColumnSpan(this.tlpDashboard, 3);
            this.tlpDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.21744F));
            this.tlpDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.29749F));
            this.tlpDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.48148F));
            this.tlpDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.14478F));
            this.tlpDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tlpDashboard.Controls.Add(this.lstUsers, 0, 0);
            this.tlpDashboard.Controls.Add(this.btnAccept, 3, 0);
            this.tlpDashboard.Controls.Add(this.btnDelete, 3, 1);
            this.tlpDashboard.Controls.Add(this.lblId, 4, 3);
            this.tlpDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDashboard.Location = new System.Drawing.Point(3, 65);
            this.tlpDashboard.Name = "tlpDashboard";
            this.tlpDashboard.RowCount = 4;
            this.tlpMain.SetRowSpan(this.tlpDashboard, 7);
            this.tlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.45205F));
            this.tlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.54795F));
            this.tlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.36986F));
            this.tlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.35616F));
            this.tlpDashboard.Size = new System.Drawing.Size(760, 370);
            this.tlpDashboard.TabIndex = 12;
            // 
            // lstUsers
            // 
            this.tlpDashboard.SetColumnSpan(this.lstUsers, 3);
            this.lstUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 16;
            this.lstUsers.Location = new System.Drawing.Point(3, 3);
            this.lstUsers.Name = "lstUsers";
            this.tlpDashboard.SetRowSpan(this.lstUsers, 4);
            this.lstUsers.Size = new System.Drawing.Size(402, 364);
            this.lstUsers.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.DarkCyan;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(769, 62);
            this.label17.Name = "label17";
            this.tlpMain.SetRowSpan(this.label17, 6);
            this.label17.Size = new System.Drawing.Size(12, 320);
            this.label17.TabIndex = 13;
            // 
            // btnAccept
            // 
            this.btnAccept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAccept.Location = new System.Drawing.Point(411, 3);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(178, 66);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "Accepteren";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(411, 75);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(178, 70);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Weigeren";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(595, 227);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 13);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "label3";
            // 
            // btnPlanning
            // 
            this.btnPlanning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlanning.Location = new System.Drawing.Point(787, 385);
            this.btnPlanning.Name = "btnPlanning";
            this.btnPlanning.Size = new System.Drawing.Size(301, 50);
            this.btnPlanning.TabIndex = 14;
            this.btnPlanning.Text = "Planning";
            this.btnPlanning.UseVisualStyleBackColor = true;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 438);
            this.Controls.Add(this.tlpMain);
            this.MainMenuStrip = this.msName;
            this.MaximizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.msName.ResumeLayout(false);
            this.msName.PerformLayout();
            this.tlpDashboard.ResumeLayout(false);
            this.tlpDashboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnReviews;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnTenders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInstructors;
        private System.Windows.Forms.Button btnFleets;
        private System.Windows.Forms.TableLayoutPanel tlpDashboard;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.MenuStrip msName;
        public System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem myAccountToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnPlanning;
    }
}

