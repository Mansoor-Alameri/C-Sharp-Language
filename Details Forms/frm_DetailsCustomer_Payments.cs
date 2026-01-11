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
    public partial class frm_DetailsCustomer_Payments : Form
    {
        private string _CustomerID;
        private string _CustomerName;
        public frm_DetailsCustomer_Payments(string CustomerID, string customerName)
        {
            InitializeComponent();
            _CustomerID = CustomerID;
            _CustomerName = customerName;
        }

        private void LoadTable()
        {
            
            string query = "SELECT * FROM V_AllPayments Where Customer_ID = " + _CustomerID;
            DataTable dt = new DataTable();
            Database.LoadData(query, dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Customer_ID"].Visible = false;
            dataGridView1.Columns["Car_ID"].Visible = false;
            //dataGridView1.Columns["IsDelete"].Visible = false;


        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_DetailsCustomer_Payments_Load(object sender, EventArgs e)
        {
            txt_ID.Text = _CustomerID;
            txt_Name.Text = _CustomerName;

            LoadTable();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("There Are No Data To Print");
                return;
            }
            int clientId = Convert.ToInt32(_CustomerID);

            DataTable dt = new DataTable();

            string query = "SELECT * FROM V_AllPayments Where Customer_ID =  @id";
            SqlDataAdapter da = new SqlDataAdapter(query, Database.Connection);
            da.SelectCommand.Parameters.AddWithValue("@id", clientId);
            da.Fill(dt);

            Rp_CustpmerPayments rpt = new Rp_CustpmerPayments();
            rpt.SetDataSource(dt);

            var Parent = this.MdiParent as Main_Form;
            Parent.DisplayReports<Rp_CustpmerPayments>(rpt);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
