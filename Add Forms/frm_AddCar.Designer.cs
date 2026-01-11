namespace Car_Rental_System_New_Virsion
{
    partial class frm_AddCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddCar));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider_Add = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_Fuel = new System.Windows.Forms.ComboBox();
            this.cmb_Gear = new System.Windows.Forms.ComboBox();
            this.txt_Year = new System.Windows.Forms.TextBox();
            this.txt_Price_Per_Day = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Color = new System.Windows.Forms.TextBox();
            this.txt_Category = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Brand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Add)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.panel2.TabIndex = 34;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.lbl_Title.Location = new System.Drawing.Point(746, 23);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(248, 46);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "INSERT CAR";
            // 
            // lbl_Date
            // 
            this.lbl_Date.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Date.Location = new System.Drawing.Point(1479, 23);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(169, 31);
            this.lbl_Date.TabIndex = 21;
            this.lbl_Date.Text = "12-6-2025";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(1383, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 31);
            this.label11.TabIndex = 20;
            this.label11.Text = "Today : ";
            // 
            // errorProvider_Add
            // 
            this.errorProvider_Add.ContainerControl = this;
            this.errorProvider_Add.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_Add.Icon")));
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Back);
            this.groupBox2.Controls.Add(this.btn_Save);
            this.groupBox2.Controls.Add(this.btn_Help);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(12, 472);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1664, 100);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Silver;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.Location = new System.Drawing.Point(1106, 33);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(174, 46);
            this.btn_Back.TabIndex = 42;
            this.btn_Back.Text = "Back";
            this.btn_Back.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.Location = new System.Drawing.Point(416, 33);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(174, 46);
            this.btn_Save.TabIndex = 40;
            this.btn_Save.Text = "Save";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Help.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_Help.Image = ((System.Drawing.Image)(resources.GetObject("btn_Help.Image")));
            this.btn_Help.Location = new System.Drawing.Point(761, 33);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(174, 46);
            this.btn_Help.TabIndex = 41;
            this.btn_Help.Text = "Help";
            this.btn_Help.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Help.UseVisualStyleBackColor = false;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_Fuel);
            this.groupBox1.Controls.Add(this.cmb_Gear);
            this.groupBox1.Controls.Add(this.txt_Year);
            this.groupBox1.Controls.Add(this.txt_Price_Per_Day);
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_Model);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_Price);
            this.groupBox1.Controls.Add(this.txt_Color);
            this.groupBox1.Controls.Add(this.txt_Category);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_Brand);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1664, 363);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CAR INFORMATION";
            // 
            // cmb_Fuel
            // 
            this.cmb_Fuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Fuel.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmb_Fuel.FormattingEnabled = true;
            this.cmb_Fuel.Items.AddRange(new object[] {
            "Petrol",
            "Diesel",
            "Gaz"});
            this.cmb_Fuel.Location = new System.Drawing.Point(823, 141);
            this.cmb_Fuel.Name = "cmb_Fuel";
            this.cmb_Fuel.Size = new System.Drawing.Size(196, 34);
            this.cmb_Fuel.TabIndex = 28;
            // 
            // cmb_Gear
            // 
            this.cmb_Gear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Gear.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmb_Gear.FormattingEnabled = true;
            this.cmb_Gear.Items.AddRange(new object[] {
            "Manual",
            "Automatic"});
            this.cmb_Gear.Location = new System.Drawing.Point(823, 68);
            this.cmb_Gear.Name = "cmb_Gear";
            this.cmb_Gear.Size = new System.Drawing.Size(193, 34);
            this.cmb_Gear.TabIndex = 27;
            // 
            // txt_Year
            // 
            this.txt_Year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Year.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_Year.Location = new System.Drawing.Point(1412, 68);
            this.txt_Year.Name = "txt_Year";
            this.txt_Year.Size = new System.Drawing.Size(132, 34);
            this.txt_Year.TabIndex = 26;
            // 
            // txt_Price_Per_Day
            // 
            this.txt_Price_Per_Day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Price_Per_Day.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_Price_Per_Day.Location = new System.Drawing.Point(823, 214);
            this.txt_Price_Per_Day.Name = "txt_Price_Per_Day";
            this.txt_Price_Per_Day.Size = new System.Drawing.Size(225, 34);
            this.txt_Price_Per_Day.TabIndex = 25;
            // 
            // txt_ID
            // 
            this.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ID.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_ID.Location = new System.Drawing.Point(198, 73);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(184, 34);
            this.txt_ID.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label4.Location = new System.Drawing.Point(120, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label5.Location = new System.Drawing.Point(86, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "Brand :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label3.Location = new System.Drawing.Point(1299, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 27);
            this.label3.TabIndex = 18;
            this.label3.Text = "Price : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label1.Location = new System.Drawing.Point(1295, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 27);
            this.label1.TabIndex = 18;
            this.label1.Text = "Color : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label15.Location = new System.Drawing.Point(52, 294);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 27);
            this.label15.TabIndex = 15;
            this.label15.Text = "Categoty : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label7.Location = new System.Drawing.Point(77, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 27);
            this.label7.TabIndex = 19;
            this.label7.Text = "Model : ";
            // 
            // txt_Model
            // 
            this.txt_Model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Model.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_Model.Location = new System.Drawing.Point(198, 219);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(205, 34);
            this.txt_Model.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label8.Location = new System.Drawing.Point(666, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 27);
            this.label8.TabIndex = 24;
            this.label8.Text = "Gear Type :";
            // 
            // txt_Price
            // 
            this.txt_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Price.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_Price.Location = new System.Drawing.Point(1412, 141);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(205, 34);
            this.txt_Price.TabIndex = 17;
            // 
            // txt_Color
            // 
            this.txt_Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Color.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_Color.Location = new System.Drawing.Point(1405, 212);
            this.txt_Color.Name = "txt_Color";
            this.txt_Color.Size = new System.Drawing.Size(205, 34);
            this.txt_Color.TabIndex = 17;
            // 
            // txt_Category
            // 
            this.txt_Category.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Category.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_Category.Location = new System.Drawing.Point(198, 292);
            this.txt_Category.Name = "txt_Category";
            this.txt_Category.Size = new System.Drawing.Size(205, 34);
            this.txt_Category.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label9.Location = new System.Drawing.Point(671, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 27);
            this.label9.TabIndex = 22;
            this.label9.Text = "Fuel Type :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label10.Location = new System.Drawing.Point(1149, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(230, 27);
            this.label10.TabIndex = 21;
            this.label10.Text = "Year Of Manufacture :";
            // 
            // txt_Brand
            // 
            this.txt_Brand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Brand.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_Brand.Location = new System.Drawing.Point(198, 146);
            this.txt_Brand.Name = "txt_Brand";
            this.txt_Brand.Size = new System.Drawing.Size(225, 34);
            this.txt_Brand.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label2.Location = new System.Drawing.Point(631, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 27);
            this.label2.TabIndex = 23;
            this.label2.Text = "Price Per Day :";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "HelpPages\\MangeCars\\CarsAddFormHelp.html";
            // 
            // frm_AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1688, 674);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "frm_AddCar";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "frm_AddCar";
            this.Load += new System.EventHandler(this.frm_AddCar_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frm_AddCar_Paint);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Add)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Label lbl_Title;
        protected System.Windows.Forms.Label lbl_Date;
        protected System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider_Add;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_Fuel;
        private System.Windows.Forms.ComboBox cmb_Gear;
        private System.Windows.Forms.TextBox txt_Year;
        private System.Windows.Forms.TextBox txt_Price_Per_Day;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Model;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Color;
        private System.Windows.Forms.TextBox txt_Category;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Brand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}