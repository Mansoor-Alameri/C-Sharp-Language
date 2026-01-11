using Car_Rental_System_New_Virsion.Mains_Forms;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System_New_Virsion
{
    public partial class Main_Form : Form
    {
        public int UserID;
        public string Job_Title;



        private ToolStripMenuItem CurrentMenuItem = null;
        public Main_Form()
        {
            InitializeComponent();
        }

        private void HighLightMenuItem(ToolStripMenuItem ClickedItem)
        {
            if (CurrentMenuItem != null)
            {
                CurrentMenuItem.BackColor = Color.Transparent;
                CurrentMenuItem.ForeColor = Color.Black;
            }

            ClickedItem.BackColor = Color.LightGray;
            ClickedItem.ForeColor = Color.DarkBlue;

            CurrentMenuItem = ClickedItem;

        }

        private frm_Customers Customers = new frm_Customers();
        private frm_Cars Cars = new frm_Cars();
        private frm_Employees Employees = new frm_Employees();
        private frm_Rentals Rentals =  new frm_Rentals();
        private frm_Payments Payments =  new frm_Payments();
        private frm_Violations Violations =  new frm_Violations();
        private frm_Reports Reports = new frm_Reports();

        public void Displayform<T>(T frm) where T : Form, new()
        {

            if (frm.IsDisposed)
                frm = new T();
            
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;

            frm.Show();
        }
        public void DisplayformWithCons(Form frm)
        {
            if (frm is frm_Violations)
                HighLightMenuItem(ms_Violations);
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;

            frm.Show();
        }
        
        public void DisplayReports<T>(T rpt) where T : ReportClass, new()
        {
            ms_Reports.Visible = true;
            HighLightMenuItem(ms_Reports);
            if (Reports.IsDisposed)
            {
                Reports = new frm_Reports();
            }
            Reports.MdiParent = this;
            Reports.Dock = DockStyle.Fill;
            Reports.crystalReportViewer1.ReportSource = rpt;
            Reports.crystalReportViewer1.Refresh();
            Reports.Show();
        }
        public void OpenAddPaymentForm(string Rental_ID)
        {
            Payments = new frm_Payments(Rental_ID);
            HighLightMenuItem(ms_Payments);

            foreach (Form Child in this.MdiChildren)
            {
                Child.Dispose();
            }
            DisplayformWithCons(Payments);
        }
        private void ClickMenuItem(object sender, EventArgs e)
        {
            if (CurrentMenuItem == sender as ToolStripMenuItem)
            {
                return;
            }
            if (ms_Reports.Visible == true)
                {
                ms_Reports.Visible = false;
            }
            HighLightMenuItem(sender as ToolStripMenuItem);

            foreach (Form Child in this.MdiChildren)
            {
                Child.Dispose();
            }

                switch (CurrentMenuItem.Name)
                {
                    case "ms_Home":
                        //Displayform(frm_Home);
                        break;
                    case "ms_Customers":
                        Displayform(Customers);
                        break;
                    case "ms_Rents":
                        Displayform(Rentals);
                        break;
                    case "ms_Cars":
                        Displayform(Cars);
                        break;
                    case "ms_Employees":
                        Displayform(Employees);
                        break;
                    case "ms_Payments":
                        Displayform(Payments);
                        break;
                    case "ms_Violations":
                        Displayform(Violations);
                        break;
                    

                }
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            DeleteOldUnpaidRentals();
            ClickMenuItem(ms_Rents,null);
        }

        public void DeleteOldUnpaidRentals()
        {
            SqlCommand cmd = new SqlCommand("BEGIN TRANSACTION; UPDATE Cars SET State = 'Available' WHERE ID IN (SELECT Car_ID FROM Rentals Where DATEDIFF(HOUR, Created_at, GetDate()) > 24 And IsDelete = 0 And ID not in (Select Rental_ID From Rentals join Payments On Rentals.ID = Payments.Rental_ID Where Payments.Type = 'Rental')) ; " +
                "Update Rentals set IsDelete = 1 Where DATEDIFF(HOUR, Created_at, GetDate()) > 24 And ID not in (Select Rental_ID From Rentals join Payments On Rentals.ID = Payments.Rental_ID Where Payments.Type = 'Rental') And IsDelete = 0; COMMIT TRANSACTION;", Database.Connection);
            Database.Open();
            cmd.ExecuteNonQuery();
            Database.Close();
        }
        private void DisplayReports(object sender, EventArgs e)
        {

        }
    }
}
