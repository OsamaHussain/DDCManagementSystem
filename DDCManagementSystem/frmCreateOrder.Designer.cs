namespace DDCManagementSystem
{
    partial class frmCreateOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.grpServies = new System.Windows.Forms.GroupBox();
            this.qtyTowel = new System.Windows.Forms.NumericUpDown();
            this.qtyOther = new System.Windows.Forms.NumericUpDown();
            this.chkOther = new System.Windows.Forms.CheckBox();
            this.chkTowel = new System.Windows.Forms.CheckBox();
            this.qtyShoes = new System.Windows.Forms.NumericUpDown();
            this.qtySweater = new System.Windows.Forms.NumericUpDown();
            this.qtyHoodie = new System.Windows.Forms.NumericUpDown();
            this.chkShoes = new System.Windows.Forms.CheckBox();
            this.chkSweater = new System.Windows.Forms.CheckBox();
            this.chkHoodie = new System.Windows.Forms.CheckBox();
            this.qtyCoat = new System.Windows.Forms.NumericUpDown();
            this.qtySocks = new System.Windows.Forms.NumericUpDown();
            this.chkSocks = new System.Windows.Forms.CheckBox();
            this.chkCoat = new System.Windows.Forms.CheckBox();
            this.qtyJacket = new System.Windows.Forms.NumericUpDown();
            this.qty2Piece = new System.Windows.Forms.NumericUpDown();
            this.qty3Piece = new System.Windows.Forms.NumericUpDown();
            this.chkJacket = new System.Windows.Forms.CheckBox();
            this.chk2Piece = new System.Windows.Forms.CheckBox();
            this.chk3Piece = new System.Windows.Forms.CheckBox();
            this.qtyShirt = new System.Windows.Forms.NumericUpDown();
            this.qtyUndergarments = new System.Windows.Forms.NumericUpDown();
            this.chkUndergarments = new System.Windows.Forms.CheckBox();
            this.chkShirt = new System.Windows.Forms.CheckBox();
            this.qtyPant = new System.Windows.Forms.NumericUpDown();
            this.qtyKameez = new System.Windows.Forms.NumericUpDown();
            this.qtyShalwar = new System.Windows.Forms.NumericUpDown();
            this.chkPant = new System.Windows.Forms.CheckBox();
            this.chkKameez = new System.Windows.Forms.CheckBox();
            this.chkShalwar = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.cmbCustomerPhone = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.grpServies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyTowel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyOther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyShoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtySweater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyHoodie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyCoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtySocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyJacket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty2Piece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty3Piece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyShirt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyUndergarments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyPant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyKameez)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyShalwar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.btnPlaceOrder);
            this.panel1.Controls.Add(this.grpServies);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 462);
            this.panel1.TabIndex = 0;
            this.panel1.Tag = "sfasdas";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Font = new System.Drawing.Font("Gabriola", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(12, 395);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPlaceOrder.Size = new System.Drawing.Size(776, 55);
            this.btnPlaceOrder.TabIndex = 31;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // grpServies
            // 
            this.grpServies.Controls.Add(this.qtyTowel);
            this.grpServies.Controls.Add(this.qtyOther);
            this.grpServies.Controls.Add(this.chkOther);
            this.grpServies.Controls.Add(this.chkTowel);
            this.grpServies.Controls.Add(this.qtyShoes);
            this.grpServies.Controls.Add(this.qtySweater);
            this.grpServies.Controls.Add(this.qtyHoodie);
            this.grpServies.Controls.Add(this.chkShoes);
            this.grpServies.Controls.Add(this.chkSweater);
            this.grpServies.Controls.Add(this.chkHoodie);
            this.grpServies.Controls.Add(this.qtyCoat);
            this.grpServies.Controls.Add(this.qtySocks);
            this.grpServies.Controls.Add(this.chkSocks);
            this.grpServies.Controls.Add(this.chkCoat);
            this.grpServies.Controls.Add(this.qtyJacket);
            this.grpServies.Controls.Add(this.qty2Piece);
            this.grpServies.Controls.Add(this.qty3Piece);
            this.grpServies.Controls.Add(this.chkJacket);
            this.grpServies.Controls.Add(this.chk2Piece);
            this.grpServies.Controls.Add(this.chk3Piece);
            this.grpServies.Controls.Add(this.qtyShirt);
            this.grpServies.Controls.Add(this.qtyUndergarments);
            this.grpServies.Controls.Add(this.chkUndergarments);
            this.grpServies.Controls.Add(this.chkShirt);
            this.grpServies.Controls.Add(this.qtyPant);
            this.grpServies.Controls.Add(this.qtyKameez);
            this.grpServies.Controls.Add(this.qtyShalwar);
            this.grpServies.Controls.Add(this.chkPant);
            this.grpServies.Controls.Add(this.chkKameez);
            this.grpServies.Controls.Add(this.chkShalwar);
            this.grpServies.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpServies.ForeColor = System.Drawing.Color.White;
            this.grpServies.Location = new System.Drawing.Point(12, 191);
            this.grpServies.Name = "grpServies";
            this.grpServies.Size = new System.Drawing.Size(776, 198);
            this.grpServies.TabIndex = 30;
            this.grpServies.TabStop = false;
            this.grpServies.Text = "Order Processing";
            this.grpServies.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // qtyTowel
            // 
            this.qtyTowel.Location = new System.Drawing.Point(719, 124);
            this.qtyTowel.Name = "qtyTowel";
            this.qtyTowel.Size = new System.Drawing.Size(40, 27);
            this.qtyTowel.TabIndex = 63;
            // 
            // qtyOther
            // 
            this.qtyOther.Location = new System.Drawing.Point(719, 157);
            this.qtyOther.Name = "qtyOther";
            this.qtyOther.Size = new System.Drawing.Size(40, 27);
            this.qtyOther.TabIndex = 62;
            // 
            // chkOther
            // 
            this.chkOther.AutoSize = true;
            this.chkOther.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOther.Location = new System.Drawing.Point(554, 155);
            this.chkOther.Name = "chkOther";
            this.chkOther.Size = new System.Drawing.Size(161, 27);
            this.chkOther.TabIndex = 61;
            this.chkOther.Text = "Other Washables";
            this.chkOther.UseVisualStyleBackColor = true;
            // 
            // chkTowel
            // 
            this.chkTowel.AutoSize = true;
            this.chkTowel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTowel.Location = new System.Drawing.Point(554, 122);
            this.chkTowel.Name = "chkTowel";
            this.chkTowel.Size = new System.Drawing.Size(73, 27);
            this.chkTowel.TabIndex = 60;
            this.chkTowel.Text = "Towel";
            this.chkTowel.UseVisualStyleBackColor = true;
            // 
            // qtyShoes
            // 
            this.qtyShoes.Location = new System.Drawing.Point(719, 92);
            this.qtyShoes.Name = "qtyShoes";
            this.qtyShoes.Size = new System.Drawing.Size(40, 27);
            this.qtyShoes.TabIndex = 59;
            // 
            // qtySweater
            // 
            this.qtySweater.Location = new System.Drawing.Point(719, 59);
            this.qtySweater.Name = "qtySweater";
            this.qtySweater.Size = new System.Drawing.Size(40, 27);
            this.qtySweater.TabIndex = 58;
            // 
            // qtyHoodie
            // 
            this.qtyHoodie.Location = new System.Drawing.Point(719, 26);
            this.qtyHoodie.Name = "qtyHoodie";
            this.qtyHoodie.Size = new System.Drawing.Size(40, 27);
            this.qtyHoodie.TabIndex = 57;
            // 
            // chkShoes
            // 
            this.chkShoes.AutoSize = true;
            this.chkShoes.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShoes.Location = new System.Drawing.Point(554, 90);
            this.chkShoes.Name = "chkShoes";
            this.chkShoes.Size = new System.Drawing.Size(75, 27);
            this.chkShoes.TabIndex = 56;
            this.chkShoes.Text = "Shoes";
            this.chkShoes.UseVisualStyleBackColor = true;
            // 
            // chkSweater
            // 
            this.chkSweater.AutoSize = true;
            this.chkSweater.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSweater.Location = new System.Drawing.Point(554, 57);
            this.chkSweater.Name = "chkSweater";
            this.chkSweater.Size = new System.Drawing.Size(92, 27);
            this.chkSweater.TabIndex = 55;
            this.chkSweater.Text = "Sweater";
            this.chkSweater.UseVisualStyleBackColor = true;
            // 
            // chkHoodie
            // 
            this.chkHoodie.AutoSize = true;
            this.chkHoodie.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHoodie.Location = new System.Drawing.Point(553, 24);
            this.chkHoodie.Name = "chkHoodie";
            this.chkHoodie.Size = new System.Drawing.Size(84, 27);
            this.chkHoodie.TabIndex = 54;
            this.chkHoodie.Text = "Hoodie";
            this.chkHoodie.UseVisualStyleBackColor = true;
            // 
            // qtyCoat
            // 
            this.qtyCoat.Location = new System.Drawing.Point(432, 124);
            this.qtyCoat.Name = "qtyCoat";
            this.qtyCoat.Size = new System.Drawing.Size(40, 27);
            this.qtyCoat.TabIndex = 53;
            // 
            // qtySocks
            // 
            this.qtySocks.Location = new System.Drawing.Point(432, 157);
            this.qtySocks.Name = "qtySocks";
            this.qtySocks.Size = new System.Drawing.Size(40, 27);
            this.qtySocks.TabIndex = 52;
            // 
            // chkSocks
            // 
            this.chkSocks.AutoSize = true;
            this.chkSocks.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSocks.Location = new System.Drawing.Point(281, 157);
            this.chkSocks.Name = "chkSocks";
            this.chkSocks.Size = new System.Drawing.Size(73, 27);
            this.chkSocks.TabIndex = 51;
            this.chkSocks.Text = "Socks";
            this.chkSocks.UseVisualStyleBackColor = true;
            // 
            // chkCoat
            // 
            this.chkCoat.AutoSize = true;
            this.chkCoat.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCoat.Location = new System.Drawing.Point(281, 124);
            this.chkCoat.Name = "chkCoat";
            this.chkCoat.Size = new System.Drawing.Size(64, 27);
            this.chkCoat.TabIndex = 50;
            this.chkCoat.Text = "Coat";
            this.chkCoat.UseVisualStyleBackColor = true;
            // 
            // qtyJacket
            // 
            this.qtyJacket.Location = new System.Drawing.Point(432, 92);
            this.qtyJacket.Name = "qtyJacket";
            this.qtyJacket.Size = new System.Drawing.Size(40, 27);
            this.qtyJacket.TabIndex = 49;
            // 
            // qty2Piece
            // 
            this.qty2Piece.Location = new System.Drawing.Point(432, 59);
            this.qty2Piece.Name = "qty2Piece";
            this.qty2Piece.Size = new System.Drawing.Size(40, 27);
            this.qty2Piece.TabIndex = 48;
            // 
            // qty3Piece
            // 
            this.qty3Piece.Location = new System.Drawing.Point(432, 26);
            this.qty3Piece.Name = "qty3Piece";
            this.qty3Piece.Size = new System.Drawing.Size(40, 27);
            this.qty3Piece.TabIndex = 47;
            // 
            // chkJacket
            // 
            this.chkJacket.AutoSize = true;
            this.chkJacket.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkJacket.Location = new System.Drawing.Point(281, 92);
            this.chkJacket.Name = "chkJacket";
            this.chkJacket.Size = new System.Drawing.Size(75, 27);
            this.chkJacket.TabIndex = 46;
            this.chkJacket.Text = "Jacket";
            this.chkJacket.UseVisualStyleBackColor = true;
            // 
            // chk2Piece
            // 
            this.chk2Piece.AutoSize = true;
            this.chk2Piece.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk2Piece.Location = new System.Drawing.Point(281, 59);
            this.chk2Piece.Name = "chk2Piece";
            this.chk2Piece.Size = new System.Drawing.Size(116, 27);
            this.chk2Piece.TabIndex = 45;
            this.chk2Piece.Text = "2 Piece Suit";
            this.chk2Piece.UseVisualStyleBackColor = true;
            // 
            // chk3Piece
            // 
            this.chk3Piece.AutoSize = true;
            this.chk3Piece.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk3Piece.Location = new System.Drawing.Point(280, 26);
            this.chk3Piece.Name = "chk3Piece";
            this.chk3Piece.Size = new System.Drawing.Size(116, 27);
            this.chk3Piece.TabIndex = 44;
            this.chk3Piece.Text = "3 Piece Suit";
            this.chk3Piece.UseVisualStyleBackColor = true;
            // 
            // qtyShirt
            // 
            this.qtyShirt.Location = new System.Drawing.Point(161, 124);
            this.qtyShirt.Name = "qtyShirt";
            this.qtyShirt.Size = new System.Drawing.Size(40, 27);
            this.qtyShirt.TabIndex = 43;
            // 
            // qtyUndergarments
            // 
            this.qtyUndergarments.Location = new System.Drawing.Point(161, 157);
            this.qtyUndergarments.Name = "qtyUndergarments";
            this.qtyUndergarments.Size = new System.Drawing.Size(40, 27);
            this.qtyUndergarments.TabIndex = 42;
            // 
            // chkUndergarments
            // 
            this.chkUndergarments.AutoSize = true;
            this.chkUndergarments.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUndergarments.Location = new System.Drawing.Point(10, 157);
            this.chkUndergarments.Name = "chkUndergarments";
            this.chkUndergarments.Size = new System.Drawing.Size(150, 27);
            this.chkUndergarments.TabIndex = 41;
            this.chkUndergarments.Text = "Undergarments";
            this.chkUndergarments.UseVisualStyleBackColor = true;
            // 
            // chkShirt
            // 
            this.chkShirt.AutoSize = true;
            this.chkShirt.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShirt.Location = new System.Drawing.Point(10, 124);
            this.chkShirt.Name = "chkShirt";
            this.chkShirt.Size = new System.Drawing.Size(65, 27);
            this.chkShirt.TabIndex = 40;
            this.chkShirt.Text = "Shirt";
            this.chkShirt.UseVisualStyleBackColor = true;
            // 
            // qtyPant
            // 
            this.qtyPant.Location = new System.Drawing.Point(161, 92);
            this.qtyPant.Name = "qtyPant";
            this.qtyPant.Size = new System.Drawing.Size(40, 27);
            this.qtyPant.TabIndex = 39;
            // 
            // qtyKameez
            // 
            this.qtyKameez.Location = new System.Drawing.Point(161, 59);
            this.qtyKameez.Name = "qtyKameez";
            this.qtyKameez.Size = new System.Drawing.Size(40, 27);
            this.qtyKameez.TabIndex = 38;
            // 
            // qtyShalwar
            // 
            this.qtyShalwar.Location = new System.Drawing.Point(161, 26);
            this.qtyShalwar.Name = "qtyShalwar";
            this.qtyShalwar.Size = new System.Drawing.Size(40, 27);
            this.qtyShalwar.TabIndex = 37;
            // 
            // chkPant
            // 
            this.chkPant.AutoSize = true;
            this.chkPant.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPant.Location = new System.Drawing.Point(10, 92);
            this.chkPant.Name = "chkPant";
            this.chkPant.Size = new System.Drawing.Size(64, 27);
            this.chkPant.TabIndex = 33;
            this.chkPant.Text = "Pant";
            this.chkPant.UseVisualStyleBackColor = true;
            // 
            // chkKameez
            // 
            this.chkKameez.AutoSize = true;
            this.chkKameez.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKameez.Location = new System.Drawing.Point(10, 59);
            this.chkKameez.Name = "chkKameez";
            this.chkKameez.Size = new System.Drawing.Size(89, 27);
            this.chkKameez.TabIndex = 32;
            this.chkKameez.Text = "Kameez";
            this.chkKameez.UseVisualStyleBackColor = true;
            // 
            // chkShalwar
            // 
            this.chkShalwar.AutoSize = true;
            this.chkShalwar.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShalwar.Location = new System.Drawing.Point(9, 26);
            this.chkShalwar.Name = "chkShalwar";
            this.chkShalwar.Size = new System.Drawing.Size(91, 27);
            this.chkShalwar.TabIndex = 31;
            this.chkShalwar.Text = "Shalwar";
            this.chkShalwar.UseVisualStyleBackColor = true;
            this.chkShalwar.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCustomerPhone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCustomerAddress);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.txtCustomerEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 122);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Customer Name";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(533, 67);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(228, 27);
            this.txtCustomerAddress.TabIndex = 28;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(136, 33);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(224, 27);
            this.txtCustomerName.TabIndex = 19;
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(533, 31);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(228, 27);
            this.txtCustomerEmail.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(396, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Customer Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Customer Phone #";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(396, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Customer Email";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.labelDashboard);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 60);
            this.panel3.TabIndex = 14;
            // 
            // labelDashboard
            // 
            this.labelDashboard.AutoSize = true;
            this.labelDashboard.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelDashboard.ForeColor = System.Drawing.Color.White;
            this.labelDashboard.Location = new System.Drawing.Point(256, 8);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(296, 49);
            this.labelDashboard.TabIndex = 0;
            this.labelDashboard.Text = "Create New Order";
            // 
            // cmbCustomerPhone
            // 
            this.cmbCustomerPhone.FormattingEnabled = true;
            this.cmbCustomerPhone.Location = new System.Drawing.Point(139, 70);
            this.cmbCustomerPhone.Name = "cmbCustomerPhone";
            this.cmbCustomerPhone.Size = new System.Drawing.Size(221, 27);
            this.cmbCustomerPhone.TabIndex = 29;
            this.cmbCustomerPhone.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerPhone_SelectedIndexChanged);
            this.cmbCustomerPhone.SelectedValueChanged += new System.EventHandler(this.cmbCustomerPhone_SelectedValueChanged);
            this.cmbCustomerPhone.TextChanged += new System.EventHandler(this.cmbCustomerPhone_TextChanged);
            // 
            // frmCreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCreateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dubai Dry Cleaning | Create New Order";
            this.panel1.ResumeLayout(false);
            this.grpServies.ResumeLayout(false);
            this.grpServies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyTowel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyOther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyShoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtySweater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyHoodie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyCoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtySocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyJacket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty2Piece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty3Piece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyShirt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyUndergarments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyPant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyKameez)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyShalwar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.GroupBox grpServies;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkPant;
        private System.Windows.Forms.CheckBox chkKameez;
        private System.Windows.Forms.CheckBox chkShalwar;
        private System.Windows.Forms.NumericUpDown qtyShalwar;
        private System.Windows.Forms.NumericUpDown qtyShirt;
        private System.Windows.Forms.NumericUpDown qtyUndergarments;
        private System.Windows.Forms.CheckBox chkUndergarments;
        private System.Windows.Forms.CheckBox chkShirt;
        private System.Windows.Forms.NumericUpDown qtyPant;
        private System.Windows.Forms.NumericUpDown qtyKameez;
        private System.Windows.Forms.NumericUpDown qtyTowel;
        private System.Windows.Forms.NumericUpDown qtyOther;
        private System.Windows.Forms.CheckBox chkOther;
        private System.Windows.Forms.CheckBox chkTowel;
        private System.Windows.Forms.NumericUpDown qtyShoes;
        private System.Windows.Forms.NumericUpDown qtySweater;
        private System.Windows.Forms.NumericUpDown qtyHoodie;
        private System.Windows.Forms.CheckBox chkShoes;
        private System.Windows.Forms.CheckBox chkSweater;
        private System.Windows.Forms.CheckBox chkHoodie;
        private System.Windows.Forms.NumericUpDown qtyCoat;
        private System.Windows.Forms.NumericUpDown qtySocks;
        private System.Windows.Forms.CheckBox chkSocks;
        private System.Windows.Forms.CheckBox chkCoat;
        private System.Windows.Forms.NumericUpDown qtyJacket;
        private System.Windows.Forms.NumericUpDown qty2Piece;
        private System.Windows.Forms.NumericUpDown qty3Piece;
        private System.Windows.Forms.CheckBox chkJacket;
        private System.Windows.Forms.CheckBox chk2Piece;
        private System.Windows.Forms.CheckBox chk3Piece;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.ComboBox cmbCustomerPhone;
    }
}