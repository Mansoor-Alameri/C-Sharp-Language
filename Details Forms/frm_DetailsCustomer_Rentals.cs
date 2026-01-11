using Car_Rental_System_New_Virsion.Mains_Forms;
using Car_Rental_System_New_Virsion.Reports;
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
    public partial class frm_DetailsCustomer_Rentals : Form
    {
        private string _Customer_ID;
        private string _Customer_Name;
        public frm_DetailsCustomer_Rentals(string Customer_ID, string Customer_Name)
        {
            InitializeComponent();
            _Customer_ID = Customer_ID;
            _Customer_Name = Customer_Name;
        }
        
        private void LoadTable()
        {
            
            string query = "SELECT * FROM V_AllRentals Where Customer_ID = " + _Customer_ID;
            DataTable dt = new DataTable();
            Database.LoadData(query, dt);

            dataGridView1.DataSource = dt;
            
            dataGridView1.Columns["Customer_ID"].Visible = false;
            dataGridView1.Columns["Car_ID"].Visible = false;
            //dataGridView1.Columns["IsDelete"].Visible = false;
            dataGridView1.Columns["Notes"].Visible = false;
            dataGridView1.Columns["Price_Per_Day"].Visible = false;
            dataGridView1.Columns["CustomerID"].Visible = false;
            dataGridView1.Columns["CarID"].Visible = false;
            dataGridView1.Columns["Is Has Violations"].Visible = false;
        }

        private void frm_DetailsCustomer_Load(object sender, EventArgs e)
        {
            txt_ID.Text = _Customer_ID;
            txt_Name.Text = _Customer_Name;
            LoadTable();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {

            frm_DetailsCustomer_Payments frm = new frm_DetailsCustomer_Payments(_Customer_ID, _Customer_Name);
            var Parent = this.MdiParent as Main_Form;
            Parent.DisplayformWithCons(frm);
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("There Are No Data To Print");
                return;
            }

            int clientId = Convert.ToInt32(_Customer_ID);

            DataTable dt = new DataTable();

            string query = "SELECT * FROM V_AllRentals Where Customer_ID =  @id";
            SqlDataAdapter da = new SqlDataAdapter(query, Database.Connection);
            da.SelectCommand.Parameters.AddWithValue("@id", clientId);
            da.Fill(dt);

            Rp_CustomerRentals rpt = new Rp_CustomerRentals();
            rpt.SetDataSource(dt);

            var Parent = this.MdiParent as Main_Form;
            Parent.DisplayReports<Rp_CustomerRentals>(rpt);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
