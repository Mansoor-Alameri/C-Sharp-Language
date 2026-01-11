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
    public partial class frm_DetailsCar_Rentals : Form
    {
        private string _Car_ID;
        private string _Car_Name;
        public frm_DetailsCar_Rentals(string Car_ID, string Car_Name)
        {
            InitializeComponent();
            _Car_ID = Car_ID;
            _Car_Name = Car_Name;
        }

        private void LoadTable()
        {
           
            string query = "SELECT * FROM V_AllRentals Where Car_ID = " + _Car_ID;
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


        }

        private void frm_DetailsCar_Load(object sender, EventArgs e)
        {
            txt_ID.Text = _Car_ID;
            txt_Car.Text = _Car_Name;
            LoadTable();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btn_Next_Click_1(object sender, EventArgs e)
        {

            frm_DetailsCar_Violations frm = new frm_DetailsCar_Violations(_Car_ID,_Car_Name);
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
            int Car_ID = Convert.ToInt32(_Car_ID);

            DataTable dt = new DataTable();

            string query = "SELECT * FROM V_AllRentals Where Car_ID =  @id";
            SqlDataAdapter da = new SqlDataAdapter(query, Database.Connection);
            da.SelectCommand.Parameters.AddWithValue("@id", Car_ID);
            da.Fill(dt);

            Rp_CarRentals rpt = new Rp_CarRentals();
            rpt.SetDataSource(dt);

            var Parent = this.MdiParent as Main_Form;
            Parent.DisplayReports<Rp_CarRentals>(rpt);
        }
    }
}
