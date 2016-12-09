namespace DeWaaiBeheer
{
    partial class frmNewCourse
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNew = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Prijs:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 27);
            this.label7.TabIndex = 13;
            this.label7.Text = "Datum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Naam:";
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(134, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(251, 20);
            this.txtName.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.tableLayoutPanel1.SetRowSpan(this.label2, 2);
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Beschrijving:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(134, 33);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.tableLayoutPanel1.SetRowSpan(this.txtDescription, 3);
            this.txtDescription.Size = new System.Drawing.Size(251, 151);
            this.txtDescription.TabIndex = 19;
            // 
            // txtPrice
            // 
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrice.Location = new System.Drawing.Point(134, 217);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(251, 20);
            this.txtPrice.TabIndex = 21;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kleur:";
            // 
            // txtColor
            // 
            this.txtColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtColor.Location = new System.Drawing.Point(134, 274);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(251, 20);
            this.txtColor.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "Vrije plaatsen:";
            // 
            // txtAmount
            // 
            this.txtAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAmount.Location = new System.Drawing.Point(134, 246);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(251, 20);
            this.txtAmount.TabIndex = 31;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 257F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPrice, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtColor, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtAmount, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnNew, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.dtpDate, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.217854F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.62651F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.672525F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.65367F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.135765F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.813745F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.47141F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.48798F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.920544F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(388, 336);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnNew
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnNew, 2);
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.Location = new System.Drawing.Point(3, 305);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(382, 28);
            this.btnNew.TabIndex = 32;
            this.btnNew.Text = "Toevoegen";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDate.Location = new System.Drawing.Point(134, 190);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(251, 20);
            this.dtpDate.TabIndex = 33;
            // 
            // frmNewCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 336);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmNewCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nieuwe cursus";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}