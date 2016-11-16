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
            this.lblUsername = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
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
            this.tlpMain.Controls.Add(this.lblUsername, 0, 0);
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
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(3, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(418, 35);
            this.lblUsername.TabIndex = 4;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 448);
            this.Controls.Add(this.tlpMain);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.frnHome_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnReviews;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnInscriptions;
        public System.Windows.Forms.Label lblUsername;
    }
}

