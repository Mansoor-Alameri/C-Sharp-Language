namespace Car_Rental_System_New_Virsion
{
    partial class frm_Rentals
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Rentals));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Mange = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.gp_Search = new System.Windows.Forms.GroupBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Display_Rentals = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Payment = new System.Windows.Forms.Button();
            this.btn_Violations = new System.Windows.Forms.Button();
            this.btn_Release_Car = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gp_Search.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_Title);
            this.panel2.Controls.Add(this.lbl_Date);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1688, 96);
            this.panel2.TabIndex = 31;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.lbl_Title.Location = new System.Drawing.Point(629, 23);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(379, 46);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "MANAGE RENTALS";
            // 
            // lbl_Date
            // 
            this.lbl_Date.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Date.Location = new System.Drawing.Point(1474, 23);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(169, 31);
            this.lbl_Date.TabIndex = 21;
            this.lbl_Date.Text = "12-6-2025";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(1378, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 31);
            this.label11.TabIndex = 20;
            this.label11.Text = "Today : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(13, 408);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1468, 252);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btn_Mange
            // 
            this.btn_Mange.BackColor = System.Drawing.Color.Silver;
            this.btn_Mange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mange.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_Mange.Image = ((System.Drawing.Image)(resources.GetObject("btn_Mange.Image")));
            this.btn_Mange.Location = new System.Drawing.Point(28, 160);
            this.btn_Mange.Name = "btn_Mange";
            this.btn_Mange.Size = new System.Drawing.Size(157, 51);
            this.btn_Mange.TabIndex = 0;
            this.btn_Mange.Text = "Manage";
            this.btn_Mange.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Mange.UseVisualStyleBackColor = false;
            this.btn_Mange.Click += new System.EventHandler(this.btn_Mange_Click);
            // 
            // btn_New
            // 
            this.btn_New.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_New.Image = ((System.Drawing.Image)(resources.GetObject("btn_New.Image")));
            this.btn_New.Location = new System.Drawing.Point(28, 88);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(157, 51);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "New";
            this.btn_New.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_New.UseVisualStyleBackColor = false;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // gp_Search
            // 
            this.gp_Search.Controls.Add(this.btn_Reset);
            this.gp_Search.Controls.Add(this.txt_Search);
            this.gp_Search.Controls.Add(this.label3);
            this.gp_Search.Controls.Add(this.cmb_Display_Rentals);
            this.gp_Search.Controls.Add(this.label2);
            this.gp_Search.Controls.Add(this.btn_Search);
            this.gp_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gp_Search.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.gp_Search.Location = new System.Drawing.Point(13, 96);
            this.gp_Search.Name = "gp_Search";
            this.gp_Search.Size = new System.Drawing.Size(880, 305);
            this.gp_Search.TabIndex = 33;
            this.gp_Search.TabStop = false;
            this.gp_Search.Text = "Search";
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.Silver;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_Reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reset.Image")));
            this.btn_Reset.Location = new System.Drawing.Point(694, 238);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(157, 51);
            this.btn_Reset.TabIndex = 36;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(179, 85);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(222, 38);
            this.txt_Search.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label3.Location = new System.Drawing.Point(78, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 31);
            this.label3.TabIndex = 35;
            this.label3.Text = "Filter :";
            // 
            // cmb_Display_Rentals
            // 
            this.cmb_Display_Rentals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Display_Rentals.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.cmb_Display_Rentals.FormattingEnabled = true;
            this.cmb_Display_Rentals.Items.AddRange(new object[] {
            "All Rentals",
            "Current Rentals",
            "Completed Rentals"});
            this.cmb_Display_Rentals.Location = new System.Drawing.Point(179, 158);
            this.cmb_Display_Rentals.Name = "cmb_Display_Rentals";
            this.cmb_Display_Rentals.Size = new System.Drawing.Size(392, 39);
            this.cmb_Display_Rentals.TabIndex = 34;
            this.cmb_Display_Rentals.SelectionChangeCommitted += new System.EventHandler(this.cmb_Display_Rentals_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label2.Location = new System.Drawing.Point(112, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID : ";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.Location = new System.Drawing.Point(475, 238);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(157, 51);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "Search";
            this.btn_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btn_Payment);
            this.panel1.Controls.Add(this.btn_Violations);
            this.panel1.Controls.Add(this.btn_Release_Car);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.btn_Print);
            this.panel1.Controls.Add(this.btn_Mange);
            this.panel1.Controls.Add(this.btn_New);
            this.panel1.Controls.Add(this.btn_Help);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1488, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 578);
            this.panel1.TabIndex = 32;
            // 
            // btn_Payment
            // 
            this.btn_Payment.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Payment.Enabled = false;
            this.btn_Payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Payment.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_Payment.Image = ((System.Drawing.Image)(resources.GetObject("btn_Payment.Image")));
            this.btn_Payment.Location = new System.Drawing.Point(27, 232);
            this.btn_Payment.Name = "btn_Payment";
            this.btn_Payment.Size = new System.Drawing.Size(157, 51);
            this.btn_Payment.TabIndex = 37;
            this.btn_Payment.Text = "Payment";
            this.btn_Payment.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Payment.UseVisualStyleBackColor = false;
            this.btn_Payment.Click += new System.EventHandler(this.btn_Payment_Click);
            // 
            // btn_Violations
            // 
            this.btn_Violations.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Violations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Violations.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_Violations.Image = ((System.Drawing.Image)(resources.GetObject("btn_Violations.Image")));
            this.btn_Violations.Location = new System.Drawing.Point(28, 371);
            this.btn_Violations.Name = "btn_Violations";
            this.btn_Violations.Size = new System.Drawing.Size(156, 46);
            this.btn_Violations.TabIndex = 46;
            this.btn_Violations.Text = "Violaions";
            this.btn_Violations.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Violations.UseVisualStyleBackColor = false;
            this.btn_Violations.Click += new System.EventHandler(this.btn_Violations_Click);
            // 
            // btn_Release_Car
            // 
            this.btn_Release_Car.BackColor = System.Drawing.Color.Gold;
            this.btn_Release_Car.Enabled = false;
            this.btn_Release_Car.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Release_Car.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_Release_Car.Image = ((System.Drawing.Image)(resources.GetObject("btn_Release_Car.Image")));
            this.btn_Release_Car.Location = new System.Drawing.Point(27, 304);
            this.btn_Release_Car.Name = "btn_Release_Car";
            this.btn_Release_Car.Size = new System.Drawing.Size(157, 46);
            this.btn_Release_Car.TabIndex = 45;
            this.btn_Release_Car.Text = "Release";
            this.btn_Release_Car.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Release_Car.UseVisualStyleBackColor = false;
            this.btn_Release_Car.Click += new System.EventHandler(this.btn_Release_Car_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Red;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(28, 510);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(157, 51);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.Ivory;
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Print.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_Print.Image = ((System.Drawing.Image)(resources.GetObject("btn_Print.Image")));
            this.btn_Print.Location = new System.Drawing.Point(28, 438);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(157, 51);
            this.btn_Print.TabIndex = 0;
            this.btn_Print.Text = "Print";
            this.btn_Print.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.BackColor = System.Drawing.Color.Silver;
            this.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Help.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_Help.Image = ((System.Drawing.Image)(resources.GetObject("btn_Help.Image")));
            this.btn_Help.Location = new System.Drawing.Point(28, 16);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(157, 51);
            this.btn_Help.TabIndex = 0;
            this.btn_Help.Text = "Help";
            this.btn_Help.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Help.UseVisualStyleBackColor = false;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(915, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 299);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label8.Location = new System.Drawing.Point(109, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 31);
            this.label8.TabIndex = 8;
            this.label8.Text = "Paid And Ongoing";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label7.Location = new System.Drawing.Point(109, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(425, 31);
            this.label7.TabIndex = 9;
            this.label7.Text = "Has Violations And Car Not Released";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label6.Location = new System.Drawing.Point(109, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(297, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "His Violations Not Paided";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label5.Location = new System.Drawing.Point(109, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(353, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Finished But Car Not Released";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label4.Location = new System.Drawing.Point(109, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "UnPaid";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label1.Location = new System.Drawing.Point(109, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Completed";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox6.Location = new System.Drawing.Point(33, 251);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(42, 32);
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox5.Location = new System.Drawing.Point(33, 204);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(42, 32);
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Silver;
            this.pictureBox4.Location = new System.Drawing.Point(33, 157);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(42, 32);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Orange;
            this.pictureBox3.Location = new System.Drawing.Point(33, 110);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 32);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(33, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 32);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGreen;
            this.pictureBox1.Location = new System.Drawing.Point(33, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 32);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "HelpPages\\MangeRentals\\RentalsMainFormHelp.html";
            // 
            // frm_Rentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1688, 674);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gp_Search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "frm_Rentals";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "frm_Rentals";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Rentals_FormClosed);
            this.Load += new System.EventHandler(this.frm_Rentals_Load);
            this.Shown += new System.EventHandler(this.frm_Rentals_Shown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gp_Search.ResumeLayout(false);
            this.gp_Search.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Label lbl_Title;
        protected System.Windows.Forms.Label lbl_Date;
        protected System.Windows.Forms.Label label11;
        protected System.Windows.Forms.DataGridView dataGridView1;
        protected System.Windows.Forms.Button btn_Mange;
        protected System.Windows.Forms.Button btn_New;
        protected System.Windows.Forms.GroupBox gp_Search;
        protected System.Windows.Forms.TextBox txt_Search;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button btn_Search;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Button btn_Exit;
        protected System.Windows.Forms.Button btn_Print;
        protected System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.ComboBox cmb_Display_Rentals;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btn_Release_Car;
        private System.Windows.Forms.Button btn_Violations;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.Button btn_Reset;
        protected System.Windows.Forms.Button btn_Payment;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}