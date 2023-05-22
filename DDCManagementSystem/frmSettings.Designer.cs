namespace DDCManagementSystem
{
    partial class frmSettings
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
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btnReports = new FontAwesome.Sharp.IconButton();
            this.btnPricing = new FontAwesome.Sharp.IconButton();
            this.btnCustomers = new FontAwesome.Sharp.IconButton();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelTitleBar2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.btnOrders = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.grdUsers = new System.Windows.Forms.DataGridView();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblCustmerName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelTitleBar2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnDashboard.IconColor = System.Drawing.Color.White;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 30;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 60);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(230, 38);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.btnSettings.IconColor = System.Drawing.Color.White;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.IconSize = 30;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 238);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(230, 35);
            this.btnSettings.TabIndex = 15;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnReports
            // 
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btnReports.IconColor = System.Drawing.Color.White;
            this.btnReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReports.IconSize = 30;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(0, 203);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(230, 35);
            this.btnReports.TabIndex = 13;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnPricing
            // 
            this.btnPricing.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPricing.FlatAppearance.BorderSize = 0;
            this.btnPricing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPricing.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPricing.ForeColor = System.Drawing.Color.White;
            this.btnPricing.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.btnPricing.IconColor = System.Drawing.Color.White;
            this.btnPricing.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPricing.IconSize = 30;
            this.btnPricing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPricing.Location = new System.Drawing.Point(0, 168);
            this.btnPricing.Name = "btnPricing";
            this.btnPricing.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPricing.Size = new System.Drawing.Size(230, 35);
            this.btnPricing.TabIndex = 12;
            this.btnPricing.Text = "Pricing";
            this.btnPricing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPricing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPricing.UseVisualStyleBackColor = true;
            this.btnPricing.Click += new System.EventHandler(this.btnPricing_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.IconChar = FontAwesome.Sharp.IconChar.PersonRays;
            this.btnCustomers.IconColor = System.Drawing.Color.White;
            this.btnCustomers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustomers.IconSize = 30;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.Location = new System.Drawing.Point(0, 133);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCustomers.Size = new System.Drawing.Size(230, 35);
            this.btnCustomers.TabIndex = 11;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogout.IconColor = System.Drawing.Color.White;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 30;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 700);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(230, 34);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dubai Dry Cleaning";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.panelTitleBar2);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(230, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1140, 60);
            this.panelTitleBar.TabIndex = 13;
            // 
            // panelTitleBar2
            // 
            this.panelTitleBar2.Controls.Add(this.panel3);
            this.panelTitleBar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitleBar2.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar2.Name = "panelTitleBar2";
            this.panelTitleBar2.Size = new System.Drawing.Size(1140, 60);
            this.panelTitleBar2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.labelDashboard);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1140, 60);
            this.panel3.TabIndex = 13;
            // 
            // labelDashboard
            // 
            this.labelDashboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDashboard.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelDashboard.ForeColor = System.Drawing.Color.White;
            this.labelDashboard.Location = new System.Drawing.Point(510, 8);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(145, 49);
            this.labelDashboard.TabIndex = 0;
            this.labelDashboard.Text = "Settings";
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnOrders.IconColor = System.Drawing.Color.White;
            this.btnOrders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrders.IconSize = 30;
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(0, 98);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOrders.Size = new System.Drawing.Size(230, 35);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "Orders";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnReports);
            this.panelMenu.Controls.Add(this.btnPricing);
            this.panelMenu.Controls.Add(this.btnCustomers);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnOrders);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.panelMenu.Size = new System.Drawing.Size(230, 749);
            this.panelMenu.TabIndex = 12;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDesktop.Controls.Add(this.button1);
            this.panelDesktop.Controls.Add(this.btnUpdate);
            this.panelDesktop.Controls.Add(this.btnDelete);
            this.panelDesktop.Controls.Add(this.txtID);
            this.panelDesktop.Controls.Add(this.grdUsers);
            this.panelDesktop.Controls.Add(this.lblAddress);
            this.panelDesktop.Controls.Add(this.lblPhone);
            this.panelDesktop.Controls.Add(this.lblCustomerId);
            this.panelDesktop.Controls.Add(this.txtUsername);
            this.panelDesktop.Controls.Add(this.txtRole);
            this.panelDesktop.Controls.Add(this.txtPassword);
            this.panelDesktop.Controls.Add(this.txtFullName);
            this.panelDesktop.Controls.Add(this.lblCustmerName);
            this.panelDesktop.Controls.Add(this.lblEmail);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1370, 749);
            this.panelDesktop.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(915, 590);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(376, 40);
            this.button1.TabIndex = 29;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AllowDrop = true;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1108, 536);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(183, 40);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AllowDrop = true;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(915, 536);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(175, 40);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtID
            // 
            this.txtID.AllowDrop = true;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(918, 175);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(373, 33);
            this.txtID.TabIndex = 17;
            this.txtID.TextChanged += new System.EventHandler(this.txtCustomerId_TextChanged);
            // 
            // grdUsers
            // 
            this.grdUsers.AllowDrop = true;
            this.grdUsers.AllowUserToAddRows = false;
            this.grdUsers.AllowUserToDeleteRows = false;
            this.grdUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdUsers.BackgroundColor = System.Drawing.Color.White;
            this.grdUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsers.Location = new System.Drawing.Point(279, 184);
            this.grdUsers.Margin = new System.Windows.Forms.Padding(2);
            this.grdUsers.Name = "grdUsers";
            this.grdUsers.ReadOnly = true;
            this.grdUsers.RowHeadersWidth = 51;
            this.grdUsers.RowTemplate.Height = 24;
            this.grdUsers.Size = new System.Drawing.Size(606, 471);
            this.grdUsers.TabIndex = 16;
            this.grdUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUsers_CellClick);
            this.grdUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUsers_CellContentClick);
            // 
            // lblAddress
            // 
            this.lblAddress.AllowDrop = true;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(913, 442);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 26);
            this.lblAddress.TabIndex = 27;
            this.lblAddress.Text = "Role";
            // 
            // lblPhone
            // 
            this.lblPhone.AllowDrop = true;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(913, 298);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(101, 26);
            this.lblPhone.TabIndex = 23;
            this.lblPhone.Text = "Username";
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AllowDrop = true;
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerId.Location = new System.Drawing.Point(913, 150);
            this.lblCustomerId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(31, 26);
            this.lblCustomerId.TabIndex = 19;
            this.lblCustomerId.Text = "ID";
            // 
            // txtUsername
            // 
            this.txtUsername.AllowDrop = true;
            this.txtUsername.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(915, 326);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(376, 33);
            this.txtUsername.TabIndex = 22;
            // 
            // txtRole
            // 
            this.txtRole.AllowDrop = true;
            this.txtRole.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.Location = new System.Drawing.Point(915, 470);
            this.txtRole.Margin = new System.Windows.Forms.Padding(2);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(376, 33);
            this.txtRole.TabIndex = 26;
            // 
            // txtPassword
            // 
            this.txtPassword.AllowDrop = true;
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(915, 397);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(376, 33);
            this.txtPassword.TabIndex = 24;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtFullName
            // 
            this.txtFullName.AllowDrop = true;
            this.txtFullName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(915, 248);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(376, 33);
            this.txtFullName.TabIndex = 20;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // lblCustmerName
            // 
            this.lblCustmerName.AllowDrop = true;
            this.lblCustmerName.AutoSize = true;
            this.lblCustmerName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustmerName.Location = new System.Drawing.Point(913, 220);
            this.lblCustmerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustmerName.Name = "lblCustmerName";
            this.lblCustmerName.Size = new System.Drawing.Size(100, 26);
            this.lblCustmerName.TabIndex = 21;
            this.lblCustmerName.Text = "Full Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AllowDrop = true;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(910, 369);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(94, 26);
            this.lblEmail.TabIndex = 25;
            this.lblEmail.Text = "Password";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelDesktop);
            this.Name = "frmSettings";
            this.Text = "Dubai Dry Cleaning | Settings";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnReports;
        private FontAwesome.Sharp.IconButton btnPricing;
        private FontAwesome.Sharp.IconButton btnCustomers;
        private FontAwesome.Sharp.IconButton btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelTitleBar2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelDashboard;
        private FontAwesome.Sharp.IconButton btnOrders;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView grdUsers;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblCustmerName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button button1;
    }
}