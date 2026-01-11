namespace Car_Rental_System_New_Virsion
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.pb_Password = new System.Windows.Forms.PictureBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Password
            // 
            this.pb_Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Password.Image = global::Car_Rental_System_New_Virsion.Properties.Resources.eye;
            this.pb_Password.Location = new System.Drawing.Point(504, 257);
            this.pb_Password.Margin = new System.Windows.Forms.Padding(4);
            this.pb_Password.Name = "pb_Password";
            this.pb_Password.Size = new System.Drawing.Size(35, 30);
            this.pb_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Password.TabIndex = 18;
            this.pb_Password.TabStop = false;
            this.pb_Password.Tag = "eye";
            this.pb_Password.Click += new System.EventHandler(this.pb_Password_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Title.Location = new System.Drawing.Point(470, 60);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(395, 57);
            this.lbl_Title.TabIndex = 17;
            this.lbl_Title.Text = "Car Rental System";
            this.lbl_Title.Click += new System.EventHandler(this.lbl_Title_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Password.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Password.Location = new System.Drawing.Point(92, 252);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(127, 31);
            this.lbl_Password.TabIndex = 15;
            this.lbl_Password.Text = "Password";
            this.lbl_Password.Click += new System.EventHandler(this.lbl_Password_Click);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Username.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Username.Location = new System.Drawing.Point(92, 195);
            this.lbl_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(139, 31);
            this.lbl_Username.TabIndex = 16;
            this.lbl_Username.Text = "User name";
            this.lbl_Username.Click += new System.EventHandler(this.lbl_Username_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.MistyRose;
            this.btn_Login.FlatAppearance.BorderSize = 2;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Login.Location = new System.Drawing.Point(278, 351);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(194, 52);
            this.btn_Login.TabIndex = 14;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_Password.Location = new System.Drawing.Point(242, 257);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(264, 30);
            this.txt_Password.TabIndex = 13;
            this.txt_Password.Tag = "Mansoor77";
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            this.txt_Password.Validating += new System.ComponentModel.CancelEventHandler(this.CheckValidating);
            // 
            // txt_Username
            // 
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Username.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_Username.Location = new System.Drawing.Point(242, 202);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(266, 30);
            this.txt_Username.TabIndex = 12;
            this.txt_Username.TextChanged += new System.EventHandler(this.txt_Username_TextChanged);
            this.txt_Username.Validating += new System.ComponentModel.CancelEventHandler(this.CheckValidating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // frm_Login
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1369, 683);
            this.Controls.Add(this.pb_Password);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Name = "frm_Login";
            this.Text = "frm_Login";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Password;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}