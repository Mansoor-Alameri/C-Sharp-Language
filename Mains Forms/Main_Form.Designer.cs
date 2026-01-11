namespace Car_Rental_System_New_Virsion
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ms_Home = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_Customers = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_Rents = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_Cars = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_Payments = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_Employees = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_Violations = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_Reports = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_Customers,
            this.ms_Rents,
            this.ms_Cars,
            this.ms_Payments,
            this.ms_Employees,
            this.ms_Violations,
            this.ms_Reports,
            this.ms_Home});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1693, 62);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.TabStop = true;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ms_Home
            // 
            this.ms_Home.Enabled = false;
            this.ms_Home.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ms_Home.Image = ((System.Drawing.Image)(resources.GetObject("ms_Home.Image")));
            this.ms_Home.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ms_Home.Name = "ms_Home";
            this.ms_Home.Size = new System.Drawing.Size(103, 58);
            this.ms_Home.Text = "Home";
            this.ms_Home.Visible = false;
            this.ms_Home.Click += new System.EventHandler(this.ClickMenuItem);
            // 
            // ms_Customers
            // 
            this.ms_Customers.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ms_Customers.Image = ((System.Drawing.Image)(resources.GetObject("ms_Customers.Image")));
            this.ms_Customers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ms_Customers.Name = "ms_Customers";
            this.ms_Customers.Size = new System.Drawing.Size(139, 58);
            this.ms_Customers.Text = "Customers";
            this.ms_Customers.Click += new System.EventHandler(this.ClickMenuItem);
            // 
            // ms_Rents
            // 
            this.ms_Rents.Image = ((System.Drawing.Image)(resources.GetObject("ms_Rents.Image")));
            this.ms_Rents.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ms_Rents.Name = "ms_Rents";
            this.ms_Rents.Size = new System.Drawing.Size(100, 58);
            this.ms_Rents.Text = "Rents";
            this.ms_Rents.Click += new System.EventHandler(this.ClickMenuItem);
            // 
            // ms_Cars
            // 
            this.ms_Cars.Image = ((System.Drawing.Image)(resources.GetObject("ms_Cars.Image")));
            this.ms_Cars.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ms_Cars.Name = "ms_Cars";
            this.ms_Cars.Size = new System.Drawing.Size(93, 58);
            this.ms_Cars.Text = "Cars";
            this.ms_Cars.Click += new System.EventHandler(this.ClickMenuItem);
            // 
            // ms_Payments
            // 
            this.ms_Payments.Image = ((System.Drawing.Image)(resources.GetObject("ms_Payments.Image")));
            this.ms_Payments.Name = "ms_Payments";
            this.ms_Payments.Size = new System.Drawing.Size(122, 58);
            this.ms_Payments.Text = "Payment";
            this.ms_Payments.Click += new System.EventHandler(this.ClickMenuItem);
            // 
            // ms_Employees
            // 
            this.ms_Employees.Image = ((System.Drawing.Image)(resources.GetObject("ms_Employees.Image")));
            this.ms_Employees.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ms_Employees.Name = "ms_Employees";
            this.ms_Employees.Size = new System.Drawing.Size(143, 58);
            this.ms_Employees.Text = "Employees";
            this.ms_Employees.Click += new System.EventHandler(this.ClickMenuItem);
            // 
            // ms_Violations
            // 
            this.ms_Violations.Image = ((System.Drawing.Image)(resources.GetObject("ms_Violations.Image")));
            this.ms_Violations.Name = "ms_Violations";
            this.ms_Violations.Size = new System.Drawing.Size(145, 58);
            this.ms_Violations.Text = "Violationss";
            this.ms_Violations.Click += new System.EventHandler(this.ClickMenuItem);
            // 
            // ms_Reports
            // 
            this.ms_Reports.Image = ((System.Drawing.Image)(resources.GetObject("ms_Reports.Image")));
            this.ms_Reports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ms_Reports.Name = "ms_Reports";
            this.ms_Reports.Size = new System.Drawing.Size(118, 58);
            this.ms_Reports.Text = "Reports";
            this.ms_Reports.Visible = false;
            this.ms_Reports.Click += new System.EventHandler(this.DisplayReports);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1693, 741);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Rental System";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ms_Home;
        private System.Windows.Forms.ToolStripMenuItem ms_Customers;
        private System.Windows.Forms.ToolStripMenuItem ms_Rents;
        private System.Windows.Forms.ToolStripMenuItem ms_Cars;
        private System.Windows.Forms.ToolStripMenuItem ms_Employees;
        private System.Windows.Forms.ToolStripMenuItem ms_Reports;
        private System.Windows.Forms.ToolStripMenuItem ms_Payments;
        private System.Windows.Forms.ToolStripMenuItem ms_Violations;
    }
}