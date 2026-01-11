namespace Car_Rental_System_New_Virsion
{
    partial class frm_Cars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cars));
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
            this.cmb_Search = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gp_Search.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
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
            this.lbl_Title.Location = new System.Drawing.Point(679, 23);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(310, 46);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "MANAGE CARS";
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 311);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1468, 350);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.TabStop = false;
            // 
            // btn_Mange
            // 
            this.btn_Mange.BackColor = System.Drawing.Color.Silver;
            this.btn_Mange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mange.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_Mange.Image = ((System.Drawing.Image)(resources.GetObject("btn_Mange.Image")));
            this.btn_Mange.Location = new System.Drawing.Point(28, 266);
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
            this.btn_New.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btn_New.Image = ((System.Drawing.Image)(resources.GetObject("btn_New.Image")));
            this.btn_New.Location = new System.Drawing.Point(28, 147);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(157, 51);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "New Car";
            this.btn_New.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_New.UseVisualStyleBackColor = false;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // gp_Search
            // 
            this.gp_Search.Controls.Add(this.btn_Reset);
            this.gp_Search.Controls.Add(this.txt_Search);
            this.gp_Search.Controls.Add(this.cmb_Search);
            this.gp_Search.Controls.Add(this.label2);
            this.gp_Search.Controls.Add(this.btn_Search);
            this.gp_Search.Controls.Add(this.label1);
            this.gp_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gp_Search.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.gp_Search.Location = new System.Drawing.Point(13, 102);
            this.gp_Search.Name = "gp_Search";
            this.gp_Search.Size = new System.Drawing.Size(1469, 202);
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
            this.btn_Reset.Location = new System.Drawing.Point(705, 132);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(157, 51);
            this.btn_Reset.TabIndex = 3;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(181, 132);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(222, 38);
            this.txt_Search.TabIndex = 2;
            // 
            // cmb_Search
            // 
            this.cmb_Search.FormattingEnabled = true;
            this.cmb_Search.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.cmb_Search.Location = new System.Drawing.Point(181, 63);
            this.cmb_Search.Name = "cmb_Search";
            this.cmb_Search.Size = new System.Drawing.Size(238, 39);
            this.cmb_Search.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label2.Location = new System.Drawing.Point(86, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Value :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.Location = new System.Drawing.Point(499, 132);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(157, 51);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "Search";
            this.btn_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label1.Location = new System.Drawing.Point(36, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search By :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
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
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Red;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(27, 504);
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
            this.btn_Print.Location = new System.Drawing.Point(28, 385);
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
            this.btn_Help.Location = new System.Drawing.Point(28, 28);
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
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "HelpPages\\MangeCars\\CarsMainFormHelp.html";
            // 
            // frm_Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1688, 674);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gp_Search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "frm_Cars";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "frm_Cars";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Cars_FormClosed);
            this.Load += new System.EventHandler(this.frm_Cars_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frm_Cars_Paint);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gp_Search.ResumeLayout(false);
            this.gp_Search.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
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
        protected System.Windows.Forms.ComboBox cmb_Search;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button btn_Search;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Button btn_Exit;
        protected System.Windows.Forms.Button btn_Print;
        protected System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.ErrorProvider errorProvider;
        protected System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}