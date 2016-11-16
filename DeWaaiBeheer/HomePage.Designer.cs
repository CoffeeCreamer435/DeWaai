namespace DeWaaiBeheer
{
    partial class HomePage
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
            this.btnVerder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerder
            // 
            this.btnVerder.Location = new System.Drawing.Point(310, 104);
            this.btnVerder.Name = "btnVerder";
            this.btnVerder.Size = new System.Drawing.Size(189, 101);
            this.btnVerder.TabIndex = 1;
            this.btnVerder.Text = "Verder";
            this.btnVerder.UseVisualStyleBackColor = true;
            this.btnVerder.Click += new System.EventHandler(this.btnVerder_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 448);
            this.Controls.Add(this.btnVerder);
            this.Name = "HomePage";
            this.Text = "Homepage";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVerder;
    }
}

