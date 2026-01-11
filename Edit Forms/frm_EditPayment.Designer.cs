namespace Car_Rental_System_New_Virsion
{
    partial class frm_EditPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EditPayment));
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.txt_Total_Price = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Discount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmb_Method = new System.Windows.Forms.ComboBox();
            this.cmb_Type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Rental_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.errorProvider_Edit = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Edit)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.dtp_Date.Location = new System.Drawing.Point(206, 196);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(329, 34);
            this.dtp_Date.TabIndex = 35;
            this.dtp_Date.Value = new System.DateTime(2025, 12, 6, 21, 53, 45, 369);
            // 
            // txt_Total_Price
            // 
            this.txt_Total_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Total_Price.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_Total_Price.Location = new System.Drawing.Point(1342, 136);
            this.txt_Total_Price.Name = "txt_Total_Price";
            this.txt_Total_Price.ReadOnly = true;
            this.txt_Total_Price.Size = new System.Drawing.Size(184, 34);
            this.txt_Total_Price.TabIndex = 34;
            this.txt_Total_Price.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label10.Location = new System.Drawing.Point(1196, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 27);
            this.label10.TabIndex = 33;
            this.label10.Text = "Total Price : ";
            // 
            // txt_Discount
            // 
            this.txt_Discount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Discount.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_Discount.Location = new System.Drawing.Point(1342, 77);
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.ReadOnly = true;
            this.txt_Discount.Size = new System.Drawing.Size(108, 34);
            this.txt_Discount.TabIndex = 32;
            this.txt_Discount.Text = "%0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label13.Location = new System.Drawing.Point(1214, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 27);
            this.label13.TabIndex = 31;
            this.label13.Text = "Discount : ";
            // 
            // cmb_Method
            // 
            this.cmb_Method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Method.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmb_Method.FormattingEnabled = true;
            this.cmb_Method.Items.AddRange(new object[] {
            "Cash",
            "Bank Transfer",
            "POS"});
            this.cmb_Method.Location = new System.Drawing.Point(845, 131);
            this.cmb_Method.Name = "cmb_Method";
            this.cmb_Method.Size = new System.Drawing.Size(196, 34);
            this.cmb_Method.TabIndex = 19;
            // 
            // cmb_Type
            // 
            this.cmb_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Type.Enabled = false;
            this.cmb_Type.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmb_Type.FormattingEnabled = true;
            this.cmb_Type.Items.AddRange(new object[] {
            "Rental",
            "Violations"});
            this.cmb_Type.Location = new System.Drawing.Point(845, 72);
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.Size = new System.Drawing.Size(196, 34);
            this.cmb_Type.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label1.Location = new System.Drawing.Point(643, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 27);
            this.label1.TabIndex = 24;
            this.label1.Text = "Payment Method :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label7.Location = new System.Drawing.Point(671, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 27);
            this.label7.TabIndex = 24;
            this.label7.Text = "Payment Type :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label5.Location = new System.Drawing.Point(78, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rental ID :";
            // 
            // txt_ID
            // 
            this.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ID.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_ID.Location = new System.Drawing.Point(208, 74);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(184, 34);
            this.txt_ID.TabIndex = 9;
            this.txt_ID.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label3.Location = new System.Drawing.Point(118, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 27);
            this.label3.TabIndex = 22;
            this.label3.Text = "Date : ";
            // 
            // txt_Rental_ID
            // 
            this.txt_Rental_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Rental_ID.Enabled = false;
            this.txt_Rental_ID.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_Rental_ID.Location = new System.Drawing.Point(208, 133);
            this.txt_Rental_ID.Name = "txt_Rental_ID";
            this.txt_Rental_ID.ReadOnly = true;
            this.txt_Rental_ID.Size = new System.Drawing.Size(225, 34);
            this.txt_Rental_ID.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label4.Location = new System.Drawing.Point(147, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID :";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.lbl_Title.Location = new System.Drawing.Point(764, 23);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(302, 46);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "EDIT PAYMENT";
            // 
            // lbl_Date
            // 
            this.lbl_Date.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Date.Location = new System.Drawing.Point(1485, 23);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(169, 31);
            this.lbl_Date.TabIndex = 21;
            this.lbl_Date.Text = "12-6-2025";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(1389, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 31);
            this.label11.TabIndex = 20;
            this.label11.Text = "Today : ";
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
            this.panel2.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_Date);
            this.groupBox1.Controls.Add(this.txt_Total_Price);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_Discount);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cmb_Method);
            this.groupBox1.Controls.Add(this.cmb_Type);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Rental_ID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1664, 273);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CUSTOMER iNFORMATION";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Red;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.Location = new System.Drawing.Point(269, 31);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(174, 46);
            this.btn_Delete.TabIndex = 41;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.BackColor = System.Drawing.Color.Silver;
            this.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Help.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_Help.Image = ((System.Drawing.Image)(resources.GetObject("btn_Help.Image")));
            this.btn_Help.Location = new System.Drawing.Point(917, 31);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(174, 46);
            this.btn_Help.TabIndex = 42;
            this.btn_Help.Text = "Help";
            this.btn_Help.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Help.UseVisualStyleBackColor = false;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Silver;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.Location = new System.Drawing.Point(1241, 31);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(174, 46);
            this.btn_Back.TabIndex = 43;
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
            this.btn_Save.Location = new System.Drawing.Point(593, 31);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(174, 46);
            this.btn_Save.TabIndex = 49;
            this.btn_Save.Text = "Save";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // errorProvider_Edit
            // 
            this.errorProvider_Edit.ContainerControl = this;
            this.errorProvider_Edit.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_Edit.Icon")));
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Save);
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Controls.Add(this.btn_Back);
            this.groupBox2.Controls.Add(this.btn_Help);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(12, 381);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1664, 100);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "HelpPages\\MangePayments\\PaymentsEditFormHelp.html";
            // 
            // frm_EditPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1688, 674);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "frm_EditPayment";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "frm_EditPayment";
            this.Load += new System.EventHandler(this.frm_EditPayment_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Edit)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.TextBox txt_Total_Price;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Discount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmb_Method;
        private System.Windows.Forms.ComboBox cmb_Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Rental_ID;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label lbl_Title;
        protected System.Windows.Forms.Label lbl_Date;
        protected System.Windows.Forms.Label label11;
        protected System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ErrorProvider errorProvider_Edit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}