namespace Car_Rental_System_New_Virsion
{
    partial class frm_EditViolation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EditViolation));
            this.txt_Cost = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Violation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Rental_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Cost
            // 
            this.txt_Cost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Cost.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_Cost.Location = new System.Drawing.Point(439, 353);
            this.txt_Cost.Name = "txt_Cost";
            this.txt_Cost.Size = new System.Drawing.Size(184, 34);
            this.txt_Cost.TabIndex = 34;
            this.txt_Cost.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label10.Location = new System.Drawing.Point(359, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 27);
            this.label10.TabIndex = 33;
            this.label10.Text = "Cost :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label5.Location = new System.Drawing.Point(316, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Violation :";
            // 
            // txt_ID
            // 
            this.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ID.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_ID.Location = new System.Drawing.Point(439, 73);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(184, 34);
            this.txt_ID.TabIndex = 9;
            this.txt_ID.TabStop = false;
            // 
            // txt_Violation
            // 
            this.txt_Violation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Violation.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_Violation.Location = new System.Drawing.Point(439, 205);
            this.txt_Violation.Multiline = true;
            this.txt_Violation.Name = "txt_Violation";
            this.txt_Violation.Size = new System.Drawing.Size(404, 110);
            this.txt_Violation.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label4.Location = new System.Drawing.Point(378, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID :";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.lbl_Title.Location = new System.Drawing.Point(681, 23);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(330, 46);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "EDIT VIOLATION";
            // 
            // lbl_Date
            // 
            this.lbl_Date.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Date.Location = new System.Drawing.Point(1489, 23);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(169, 31);
            this.lbl_Date.TabIndex = 21;
            this.lbl_Date.Text = "12-6-2025";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(1393, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 31);
            this.label11.TabIndex = 20;
            this.label11.Text = "Today : ";
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.Location = new System.Drawing.Point(1072, 606);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(174, 46);
            this.btn_Back.TabIndex = 48;
            this.btn_Back.Text = "Back";
            this.btn_Back.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_Help.Image = ((System.Drawing.Image)(resources.GetObject("btn_Help.Image")));
            this.btn_Help.Location = new System.Drawing.Point(798, 606);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(174, 46);
            this.btn_Help.TabIndex = 47;
            this.btn_Help.Text = "Help";
            this.btn_Help.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Help.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.Location = new System.Drawing.Point(524, 606);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(174, 46);
            this.btn_Save.TabIndex = 46;
            this.btn_Save.Text = "Delete";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Save.UseVisualStyleBackColor = true;
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
            this.panel2.TabIndex = 44;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Cost);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Rental_ID);
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Violation);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(369, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(991, 464);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VIOLATION INFORMATION";
            // 
            // txt_Rental_ID
            // 
            this.txt_Rental_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Rental_ID.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txt_Rental_ID.Location = new System.Drawing.Point(439, 143);
            this.txt_Rental_ID.Name = "txt_Rental_ID";
            this.txt_Rental_ID.Size = new System.Drawing.Size(184, 34);
            this.txt_Rental_ID.TabIndex = 9;
            this.txt_Rental_ID.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label1.Location = new System.Drawing.Point(309, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rental ID :";
            // 
            // frm_EditViolation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1688, 674);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_EditViolation";
            this.Text = "frm_EditViolation";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Cost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Violation;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label lbl_Title;
        protected System.Windows.Forms.Label lbl_Date;
        protected System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Button btn_Save;
        protected System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Rental_ID;
        private System.Windows.Forms.Label label1;
    }
}