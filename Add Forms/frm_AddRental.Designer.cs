namespace Car_Rental_System_New_Virsion
{
    partial class frm_AddRental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddRental));
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
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_Car = new System.Windows.Forms.ComboBox();
            this.cmb_Custmer = new System.Windows.Forms.ComboBox();
            this.dtp_End = new System.Windows.Forms.DateTimePicker();
            this.dtp_Start = new System.Windows.Forms.DateTimePicker();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.txt_Contract_NO = new System.Windows.Forms.TextBox();
            this.txt_Total_Price = new System.Windows.Forms.TextBox();
            this.txt_Price_Per_Day = new System.Windows.Forms.TextBox();
            this.txt_Discount = new System.Windows.Forms.TextBox();
            this.txt_Days = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.lbl_Title.Location = new System.Drawing.Point(666, 23);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(332, 46);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "CREATE RENTAL";
            // 
            // lbl_Date
            // 
            this.lbl_Date.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Date.Location = new System.Drawing.Point(1490, 23);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(169, 31);
            this.lbl_Date.TabIndex = 21;
            this.lbl_Date.Text = "12-6-2025";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(1394, 23);
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
            this.groupBox2.Location = new System.Drawing.Point(24, 395);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1664, 100);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Silver;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.Location = new System.Drawing.Point(1255, 34);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(174, 46);
            this.btn_Back.TabIndex = 46;
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
            this.btn_Save.Location = new System.Drawing.Point(607, 34);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(174, 46);
            this.btn_Save.TabIndex = 44;
            this.btn_Save.Text = "Save";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.BackColor = System.Drawing.Color.Silver;
            this.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Help.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_Help.Image = ((System.Drawing.Image)(resources.GetObject("btn_Help.Image")));
            this.btn_Help.Location = new System.Drawing.Point(931, 34);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(174, 46);
            this.btn_Help.TabIndex = 45;
            this.btn_Help.Text = "Help";
            this.btn_Help.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Help.UseVisualStyleBackColor = false;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmb_Car);
            this.groupBox1.Controls.Add(this.cmb_Custmer);
            this.groupBox1.Controls.Add(this.dtp_End);
            this.groupBox1.Controls.Add(this.dtp_Start);
            this.groupBox1.Controls.Add(this.txt_Notes);
            this.groupBox1.Controls.Add(this.txt_Contract_NO);
            this.groupBox1.Controls.Add(this.txt_Total_Price);
            this.groupBox1.Controls.Add(this.txt_Price_Per_Day);
            this.groupBox1.Controls.Add(this.txt_Discount);
            this.groupBox1.Controls.Add(this.txt_Days);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1664, 294);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RENTAL iNFORMATION";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_ID
            // 
            this.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ID.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_ID.Location = new System.Drawing.Point(198, 60);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(184, 34);
            this.txt_ID.TabIndex = 28;
            this.txt_ID.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label12.Location = new System.Drawing.Point(137, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 27);
            this.label12.TabIndex = 27;
            this.label12.Text = "ID :";
            // 
            // cmb_Car
            // 
            this.cmb_Car.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Car.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Car.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmb_Car.FormattingEnabled = true;
            this.cmb_Car.Location = new System.Drawing.Point(198, 168);
            this.cmb_Car.Name = "cmb_Car";
            this.cmb_Car.Size = new System.Drawing.Size(241, 34);
            this.cmb_Car.TabIndex = 9;
            this.cmb_Car.SelectionChangeCommitted += new System.EventHandler(this.cmb_Car_SelectionChangeCommitted);
            // 
            // cmb_Custmer
            // 
            this.cmb_Custmer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Custmer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Custmer.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmb_Custmer.FormattingEnabled = true;
            this.cmb_Custmer.Location = new System.Drawing.Point(198, 114);
            this.cmb_Custmer.Name = "cmb_Custmer";
            this.cmb_Custmer.Size = new System.Drawing.Size(241, 34);
            this.cmb_Custmer.TabIndex = 8;
            // 
            // dtp_End
            // 
            this.dtp_End.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.dtp_End.Location = new System.Drawing.Point(1270, 111);
            this.dtp_End.Name = "dtp_End";
            this.dtp_End.Size = new System.Drawing.Size(329, 34);
            this.dtp_End.TabIndex = 12;
            this.dtp_End.ValueChanged += new System.EventHandler(this.dtp_End_ValueChanged);
            // 
            // dtp_Start
            // 
            this.dtp_Start.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.dtp_Start.Location = new System.Drawing.Point(1270, 57);
            this.dtp_Start.Name = "dtp_Start";
            this.dtp_Start.Size = new System.Drawing.Size(329, 34);
            this.dtp_Start.TabIndex = 11;
            this.dtp_Start.ValueChanged += new System.EventHandler(this.dtp_Start_ValueChanged);
            // 
            // txt_Notes
            // 
            this.txt_Notes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Notes.Enabled = false;
            this.txt_Notes.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_Notes.Location = new System.Drawing.Point(792, 224);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.Size = new System.Drawing.Size(795, 126);
            this.txt_Notes.TabIndex = 24;
            this.txt_Notes.TabStop = false;
            this.txt_Notes.Visible = false;
            // 
            // txt_Contract_NO
            // 
            this.txt_Contract_NO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Contract_NO.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_Contract_NO.Location = new System.Drawing.Point(198, 222);
            this.txt_Contract_NO.Name = "txt_Contract_NO";
            this.txt_Contract_NO.Size = new System.Drawing.Size(184, 34);
            this.txt_Contract_NO.TabIndex = 24;
            this.txt_Contract_NO.TabStop = false;
            // 
            // txt_Total_Price
            // 
            this.txt_Total_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Total_Price.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_Total_Price.Location = new System.Drawing.Point(792, 168);
            this.txt_Total_Price.Name = "txt_Total_Price";
            this.txt_Total_Price.ReadOnly = true;
            this.txt_Total_Price.Size = new System.Drawing.Size(184, 34);
            this.txt_Total_Price.TabIndex = 24;
            this.txt_Total_Price.TabStop = false;
            // 
            // txt_Price_Per_Day
            // 
            this.txt_Price_Per_Day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Price_Per_Day.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_Price_Per_Day.Location = new System.Drawing.Point(792, 114);
            this.txt_Price_Per_Day.Name = "txt_Price_Per_Day";
            this.txt_Price_Per_Day.ReadOnly = true;
            this.txt_Price_Per_Day.Size = new System.Drawing.Size(108, 34);
            this.txt_Price_Per_Day.TabIndex = 25;
            this.txt_Price_Per_Day.TabStop = false;
            this.txt_Price_Per_Day.Text = "0";
            // 
            // txt_Discount
            // 
            this.txt_Discount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Discount.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_Discount.Location = new System.Drawing.Point(793, 60);
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.Size = new System.Drawing.Size(108, 34);
            this.txt_Discount.TabIndex = 20;
            this.txt_Discount.Text = "%0";
            this.txt_Discount.Leave += new System.EventHandler(this.txt_Discount_Leave);
            // 
            // txt_Days
            // 
            this.txt_Days.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Days.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_Days.Location = new System.Drawing.Point(1270, 170);
            this.txt_Days.Name = "txt_Days";
            this.txt_Days.ReadOnly = true;
            this.txt_Days.Size = new System.Drawing.Size(85, 34);
            this.txt_Days.TabIndex = 26;
            this.txt_Days.TabStop = false;
            this.txt_Days.Text = "0";
            this.txt_Days.TextChanged += new System.EventHandler(this.txt_Days_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label5.Location = new System.Drawing.Point(63, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Customer : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label1.Location = new System.Drawing.Point(1120, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "End Rental : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label15.Location = new System.Drawing.Point(1114, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(144, 27);
            this.label15.TabIndex = 14;
            this.label15.Text = "Start Rental : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label7.Location = new System.Drawing.Point(127, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 27);
            this.label7.TabIndex = 15;
            this.label7.Text = "Car :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label10.Location = new System.Drawing.Point(38, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 27);
            this.label10.TabIndex = 18;
            this.label10.Text = "Contract NO :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label4.Location = new System.Drawing.Point(690, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 27);
            this.label4.TabIndex = 18;
            this.label4.Text = "Notes :";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label3.Location = new System.Drawing.Point(659, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 27);
            this.label3.TabIndex = 18;
            this.label3.Text = "Total Price :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label6.Location = new System.Drawing.Point(628, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 27);
            this.label6.TabIndex = 17;
            this.label6.Text = "Price Per Day :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label9.Location = new System.Drawing.Point(1179, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 27);
            this.label9.TabIndex = 21;
            this.label9.Text = "Days : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label2.Location = new System.Drawing.Point(671, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "Discount : ";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "HelpPages\\MangeRentals\\RentalsAddFormHelp.html";
            // 
            // frm_AddRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1688, 674);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "frm_AddRental";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "frm_AddRental";
            this.Load += new System.EventHandler(this.frm_AddRental_Load);
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
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmb_Car;
        private System.Windows.Forms.ComboBox cmb_Custmer;
        private System.Windows.Forms.DateTimePicker dtp_End;
        private System.Windows.Forms.DateTimePicker dtp_Start;
        private System.Windows.Forms.TextBox txt_Notes;
        private System.Windows.Forms.TextBox txt_Contract_NO;
        private System.Windows.Forms.TextBox txt_Total_Price;
        private System.Windows.Forms.TextBox txt_Price_Per_Day;
        private System.Windows.Forms.TextBox txt_Discount;
        private System.Windows.Forms.TextBox txt_Days;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}