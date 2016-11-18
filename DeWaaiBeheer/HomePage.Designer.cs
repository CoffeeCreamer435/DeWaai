namespace DeWaaiBeheer
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
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnInscriptions = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.msName = new System.Windows.Forms.MenuStrip();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.msName.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.btnReviews, 1, 2);
            this.tlpMain.Controls.Add(this.btnCourses, 0, 2);
            this.tlpMain.Controls.Add(this.btnInscriptions, 1, 1);
            this.tlpMain.Controls.Add(this.btnUsers, 0, 1);
            this.tlpMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.818929F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.09053F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.09053F));
            this.tlpMain.Size = new System.Drawing.Size(848, 448);
            this.tlpMain.TabIndex = 0;
            // 
            // btnReviews
            // 
            this.btnReviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.btnReviews.Location = new System.Drawing.Point(427, 244);
            this.btnReviews.Name = "btnReviews";
            this.btnReviews.Size = new System.Drawing.Size(418, 201);
            this.btnReviews.TabIndex = 3;
            this.btnReviews.Text = "Overzichten";
            this.btnReviews.UseVisualStyleBackColor = true;
            // 
            // btnCourses
            // 
            this.btnCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.btnCourses.Location = new System.Drawing.Point(3, 244);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(418, 201);
            this.btnCourses.TabIndex = 2;
            this.btnCourses.Text = "Cursussen";
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnInscriptions
            // 
            this.btnInscriptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInscriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.btnInscriptions.Location = new System.Drawing.Point(427, 38);
            this.btnInscriptions.Name = "btnInscriptions";
            this.btnInscriptions.Size = new System.Drawing.Size(418, 200);
            this.btnInscriptions.TabIndex = 1;
            this.btnInscriptions.Text = "Inschrijvingen";
            this.btnInscriptions.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.btnUsers.Location = new System.Drawing.Point(3, 38);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(418, 200);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "Gebruikers";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.60287F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.39713F));
            this.tableLayoutPanel1.Controls.Add(this.msName, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(418, 29);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // msName
            // 
            this.msName.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem});
            this.msName.Location = new System.Drawing.Point(0, 0);
            this.msName.Name = "msName";
            this.msName.Size = new System.Drawing.Size(153, 29);
            this.msName.TabIndex = 0;
            this.msName.Text = "menuStrip1";
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myAccountToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.nameToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(117, 25);
            this.nameToolStripMenuItem.Text = "Name";
            // 
            // myAccountToolStripMenuItem
            // 
            this.myAccountToolStripMenuItem.Name = "myAccountToolStripMenuItem";
            this.myAccountToolStripMenuItem.Size = new System.Drawing.Size(265, 50);
            this.myAccountToolStripMenuItem.Text = "My account";
            this.myAccountToolStripMenuItem.Click += new System.EventHandler(this.myAccountToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(265, 50);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(265, 50);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 448);
            this.Controls.Add(this.tlpMain);
            this.MainMenuStrip = this.msName;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.frnHome_Load);
            this.tlpMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.msName.ResumeLayout(false);
            this.msName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnReviews;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnInscriptions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.MenuStrip msName;
        public System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem myAccountToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

