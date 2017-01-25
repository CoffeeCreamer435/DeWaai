namespace DeWaaiBeheer
{
    partial class frmInstructorsPage
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
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtTelephonenumber = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtHousenr = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtInsertion = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblNavigation = new System.Windows.Forms.Label();
            this.tlpNavigation = new System.Windows.Forms.TableLayoutPanel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnRegistrations = new System.Windows.Forms.Button();
            this.btnReviews = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnFleets = new System.Windows.Forms.Button();
            this.btnPlanning = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstUsers
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lstUsers, 3);
            this.lstUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(3, 32);
            this.lstUsers.Name = "lstUsers";
            this.tableLayoutPanel1.SetRowSpan(this.lstUsers, 13);
            this.lstUsers.Size = new System.Drawing.Size(243, 371);
            this.lstUsers.TabIndex = 7;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(273, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 29);
            this.label10.TabIndex = 5;
            this.label10.Text = "Wachtwoord:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(273, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 29);
            this.label9.TabIndex = 5;
            this.label9.Text = "Email:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(273, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 29);
            this.label8.TabIndex = 5;
            this.label8.Text = "Mobiel:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(273, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "Telefoonnummer:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(273, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Land:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(273, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Postcode + Plaats:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(273, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Straat + Huisnr:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(273, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Achternaam:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(273, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tussevoegsel:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(273, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Voornaam:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPass
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtPass, 3);
            this.txtPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPass.Location = new System.Drawing.Point(383, 322);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(260, 20);
            this.txtPass.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtEmail, 3);
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.Location = new System.Drawing.Point(383, 293);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtMobile
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtMobile, 3);
            this.txtMobile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMobile.Location = new System.Drawing.Point(383, 264);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(260, 20);
            this.txtMobile.TabIndex = 9;
            // 
            // txtTelephonenumber
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtTelephonenumber, 3);
            this.txtTelephonenumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTelephonenumber.Location = new System.Drawing.Point(383, 235);
            this.txtTelephonenumber.Name = "txtTelephonenumber";
            this.txtTelephonenumber.Size = new System.Drawing.Size(260, 20);
            this.txtTelephonenumber.TabIndex = 8;
            // 
            // txtCountry
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtCountry, 3);
            this.txtCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCountry.Location = new System.Drawing.Point(383, 206);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(260, 20);
            this.txtCountry.TabIndex = 7;
            // 
            // txtZip
            // 
            this.txtZip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZip.Location = new System.Drawing.Point(383, 177);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(83, 20);
            this.txtZip.TabIndex = 5;
            // 
            // txtCity
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtCity, 2);
            this.txtCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCity.Location = new System.Drawing.Point(472, 177);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(171, 20);
            this.txtCity.TabIndex = 6;
            // 
            // txtStreet
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtStreet, 2);
            this.txtStreet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStreet.Location = new System.Drawing.Point(383, 148);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(221, 20);
            this.txtStreet.TabIndex = 3;
            // 
            // txtHousenr
            // 
            this.txtHousenr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHousenr.Location = new System.Drawing.Point(610, 148);
            this.txtHousenr.Name = "txtHousenr";
            this.txtHousenr.Size = new System.Drawing.Size(33, 20);
            this.txtHousenr.TabIndex = 4;
            // 
            // txtSurname
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtSurname, 3);
            this.txtSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSurname.Location = new System.Drawing.Point(383, 119);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(260, 20);
            this.txtSurname.TabIndex = 2;
            // 
            // txtInsertion
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtInsertion, 3);
            this.txtInsertion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInsertion.Location = new System.Drawing.Point(383, 90);
            this.txtInsertion.Name = "txtInsertion";
            this.txtInsertion.Size = new System.Drawing.Size(260, 20);
            this.txtInsertion.TabIndex = 1;
            // 
            // txtFirstname
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtFirstname, 3);
            this.txtFirstname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirstname.Location = new System.Drawing.Point(383, 61);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(260, 20);
            this.txtFirstname.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label11.Location = new System.Drawing.Point(273, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 29);
            this.label11.TabIndex = 12;
            this.label11.Text = "Gebruikersnummer:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtId
            // 
            this.txtId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtId.Location = new System.Drawing.Point(383, 32);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(83, 20);
            this.txtId.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 13;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.7332723F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.191567F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.08249F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.157654F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.64895F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.574702F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.283226F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.8249313F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.8066F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.59853F));
            this.tableLayoutPanel1.Controls.Add(this.lstUsers, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label13, 11, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstCourses, 11, 1);
            this.tableLayoutPanel1.Controls.Add(this.label14, 5, 12);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 6, 12);
            this.tableLayoutPanel1.Controls.Add(this.label10, 5, 11);
            this.tableLayoutPanel1.Controls.Add(this.txtPass, 6, 11);
            this.tableLayoutPanel1.Controls.Add(this.label9, 5, 10);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 6, 10);
            this.tableLayoutPanel1.Controls.Add(this.label8, 5, 9);
            this.tableLayoutPanel1.Controls.Add(this.label7, 5, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtMobile, 6, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtTelephonenumber, 6, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtCountry, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtZip, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtCity, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtStreet, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtHousenr, 8, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.label4, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtSurname, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtInsertion, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtFirstname, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtId, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNew, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.btnEdit, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 2, 14);
            this.tableLayoutPanel1.Controls.Add(this.label15, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label16, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label17, 12, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNavigation, 12, 1);
            this.tableLayoutPanel1.Controls.Add(this.tlpNavigation, 12, 2);
            this.tableLayoutPanel1.Controls.Add(this.label18, 9, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 15;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1091, 438);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label12, 3);
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.DarkCyan;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(243, 29);
            this.label12.TabIndex = 18;
            this.label12.Text = "Instructeurs";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.DarkCyan;
            this.label13.Location = new System.Drawing.Point(672, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(221, 29);
            this.label13.TabIndex = 19;
            this.label13.Text = "Selecteer cursus";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstCourses
            // 
            this.lstCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.Location = new System.Drawing.Point(672, 32);
            this.lstCourses.Name = "lstCourses";
            this.tableLayoutPanel1.SetRowSpan(this.lstCourses, 13);
            this.lstCourses.Size = new System.Drawing.Size(221, 371);
            this.lstCourses.TabIndex = 20;
            this.lstCourses.SelectedIndexChanged += new System.EventHandler(this.lstCourses_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(273, 348);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 29);
            this.label14.TabIndex = 24;
            this.label14.Text = "Beschrijving:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtDescription, 3);
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(383, 351);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.tableLayoutPanel1.SetRowSpan(this.txtDescription, 2);
            this.txtDescription.Size = new System.Drawing.Size(260, 52);
            this.txtDescription.TabIndex = 25;
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.Location = new System.Drawing.Point(3, 409);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(77, 26);
            this.btnNew.TabIndex = 21;
            this.btnNew.Text = "Nieuw";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.Location = new System.Drawing.Point(86, 409);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(77, 26);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Wijzig";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(169, 409);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 26);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Verwijder";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label15, 4);
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.DarkCyan;
            this.label15.Location = new System.Drawing.Point(273, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(370, 29);
            this.label15.TabIndex = 26;
            this.label15.Text = "Gegevens";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.DarkCyan;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(260, 29);
            this.label16.Name = "label16";
            this.tableLayoutPanel1.SetRowSpan(this.label16, 13);
            this.label16.Size = new System.Drawing.Size(7, 377);
            this.label16.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.DarkCyan;
            this.label17.Location = new System.Drawing.Point(899, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(189, 29);
            this.label17.TabIndex = 28;
            this.label17.Text = "Navigeer";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNavigation
            // 
            this.lblNavigation.AutoSize = true;
            this.lblNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNavigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavigation.Location = new System.Drawing.Point(899, 29);
            this.lblNavigation.Name = "lblNavigation";
            this.lblNavigation.Size = new System.Drawing.Size(189, 29);
            this.lblNavigation.TabIndex = 29;
            this.lblNavigation.Text = "▼";
            this.lblNavigation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNavigation.Click += new System.EventHandler(this.lblNavigation_Click);
            this.lblNavigation.MouseEnter += new System.EventHandler(this.lblNavigation_MouseEnter);
            this.lblNavigation.MouseLeave += new System.EventHandler(this.lblNavigation_MouseLeave);
            // 
            // tlpNavigation
            // 
            this.tlpNavigation.ColumnCount = 1;
            this.tlpNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNavigation.Controls.Add(this.btnHome, 0, 0);
            this.tlpNavigation.Controls.Add(this.btnRegistrations, 0, 1);
            this.tlpNavigation.Controls.Add(this.btnReviews, 0, 2);
            this.tlpNavigation.Controls.Add(this.btnUsers, 0, 3);
            this.tlpNavigation.Controls.Add(this.btnCourses, 0, 4);
            this.tlpNavigation.Controls.Add(this.btnFleets, 0, 5);
            this.tlpNavigation.Controls.Add(this.btnPlanning, 0, 6);
            this.tlpNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNavigation.Location = new System.Drawing.Point(899, 61);
            this.tlpNavigation.Name = "tlpNavigation";
            this.tlpNavigation.RowCount = 7;
            this.tableLayoutPanel1.SetRowSpan(this.tlpNavigation, 12);
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpNavigation.Size = new System.Drawing.Size(189, 342);
            this.tlpNavigation.TabIndex = 30;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(183, 42);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnRegistrations
            // 
            this.btnRegistrations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegistrations.Location = new System.Drawing.Point(3, 51);
            this.btnRegistrations.Name = "btnRegistrations";
            this.btnRegistrations.Size = new System.Drawing.Size(183, 42);
            this.btnRegistrations.TabIndex = 0;
            this.btnRegistrations.Text = "Inschrijvingen";
            this.btnRegistrations.UseVisualStyleBackColor = true;
            this.btnRegistrations.Click += new System.EventHandler(this.btnRegistrations_Click);
            // 
            // btnReviews
            // 
            this.btnReviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReviews.Location = new System.Drawing.Point(3, 99);
            this.btnReviews.Name = "btnReviews";
            this.btnReviews.Size = new System.Drawing.Size(183, 42);
            this.btnReviews.TabIndex = 0;
            this.btnReviews.Text = "Recensies";
            this.btnReviews.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsers.Location = new System.Drawing.Point(3, 147);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(183, 42);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "Klanten";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCourses.Location = new System.Drawing.Point(3, 195);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(183, 42);
            this.btnCourses.TabIndex = 0;
            this.btnCourses.Text = "Cursussen";
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnFleets
            // 
            this.btnFleets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFleets.Location = new System.Drawing.Point(3, 243);
            this.btnFleets.Name = "btnFleets";
            this.btnFleets.Size = new System.Drawing.Size(183, 42);
            this.btnFleets.TabIndex = 0;
            this.btnFleets.Text = "Vloten";
            this.btnFleets.UseVisualStyleBackColor = true;
            this.btnFleets.Click += new System.EventHandler(this.btnFleets_Click);
            // 
            // btnPlanning
            // 
            this.btnPlanning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlanning.Location = new System.Drawing.Point(3, 291);
            this.btnPlanning.Name = "btnPlanning";
            this.btnPlanning.Size = new System.Drawing.Size(183, 48);
            this.btnPlanning.TabIndex = 1;
            this.btnPlanning.Text = "Planning";
            this.btnPlanning.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.DarkCyan;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(649, 29);
            this.label18.Name = "label18";
            this.tableLayoutPanel1.SetRowSpan(this.label18, 13);
            this.label18.Size = new System.Drawing.Size(8, 377);
            this.label18.TabIndex = 31;
            // 
            // frmInstructorsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 438);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmInstructorsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bestaande instructeurs";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlpNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtTelephonenumber;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtHousenr;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtInsertion;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblNavigation;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TableLayoutPanel tlpNavigation;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnRegistrations;
        private System.Windows.Forms.Button btnReviews;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnFleets;
        private System.Windows.Forms.Button btnPlanning;
    }
}