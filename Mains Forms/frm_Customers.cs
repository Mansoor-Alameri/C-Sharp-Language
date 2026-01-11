using Car_Rental_System_New_Virsion.Classes;
using Car_Rental_System_New_Virsion.Mains_Forms;
using Car_Rental_System_New_Virsion.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System_New_Virsion
{
    public partial class frm_Customers : Form
    {
        public frm_Customers()
        {
            InitializeComponent();
        }
        private bool LoadTable(string query = "SELECT * FROM V_AllCustomers ")
        {
            
            DataTable dt = new DataTable();
            Database.LoadData(query, dt);

            
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["Customer_Type_ID"].Visible = false;
            dataGridView1.Columns["Gurantee_ID"].Visible = false;
            dataGridView1.Columns["PersonID"].Visible = false;

            //dataGridView1.Columns["IsDelete"].Visible = false;
            dataGridView1.Columns["Birth_Day"].Visible = false;
            if (dt.Rows.Count == 0)
                return false;
            else
                return true;

        }
        private void frm_Customers_Load(object sender, EventArgs e)
        {
            LoadTable();
            cmb_Search.SelectedIndex = 0;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            frm_AddCustomer frm = new frm_AddCustomer();
            var Parent = this.MdiParent as Main_Form;
            frm.FormClosed += this.frm_Customers_FormClosed;

            Parent.Displayform<frm_AddCustomer>(frm);
        }

        private clsCustomers LoadCustomerInfo()
        {
            if (dataGridView1.CurrentRow == null)
                return null;

            clsCustomers Customer = new clsCustomers();

            DataGridViewRow Row = dataGridView1.CurrentRow;


            Customer.ID = Row.Cells["ID"].Value.ToString();
            Customer.PersonID = Row.Cells["PersonID"].Value.ToString();
            Customer.Name = Row.Cells["Name"].Value.ToString();
            Customer.Driving_License = Row.Cells["Driving Lisence"].Value.ToString();
            Customer.Gender = Row.Cells["Gender"].Value.ToString();
            Customer.Phone1 = Row.Cells["Phone 1"].Value.ToString();
            Customer.Phone2 = Row.Cells["Phone 2"].Value.ToString();
            Customer.Guarranty_Type = Row.Cells["Gurantee_ID"].Value.ToString();
            Customer.Customer_Type = Row.Cells["Customer_Type_ID"].Value.ToString();
            Customer.Identifiy_Type = Row.Cells["Identifier Type"].Value.ToString();
            Customer.Identifiy = Row.Cells["Identifier"].Value.ToString();
            Customer.Address = Row.Cells["Address"].Value.ToString();
            Customer.Birthday = Row.Cells["Birth_Day"].Value.ToString();

            return Customer;
        }
        private void btn_Mange_Click(object sender, EventArgs e)
        {
            clsCustomers Customer = LoadCustomerInfo();

            if (Customer == null)
            {
                MessageBox.Show("Select Customer!!!");
                return;
            }
            frm_EditCustomer frm = new frm_EditCustomer(Customer);
            var Parent = this.MdiParent as Main_Form;
            frm.FormClosed += this.frm_Customers_FormClosed;

            Parent.DisplayformWithCons(frm);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gp_Search_Enter(object sender, EventArgs e)
        {

        }
        private void CheckValidation(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                errorProvider.SetError(txt, "This field is required");
            }
            else
            {
                errorProvider.SetError(txt, "");
            }
        }

        private void SearchCustomerInfo(string SearchType, string ValueSearch)
        {
            string query = "SELECT * FROM V_AllCustomers WHERE " + SearchType + " = '" + ValueSearch + "'";
          
            if (!LoadTable(query))
            {
                MessageBox.Show("No customer found with the provided information.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            CheckValidation(txt_Search);

            if (errorProvider.GetError(txt_Search) != "")
            {
                SystemSounds.Hand.Play();
                return;
            }

            string SearchType;
            if (cmb_Search.SelectedIndex == 0)
            {
                SearchType = "Identifier";
            }
            else if (cmb_Search.SelectedIndex == 1)
            {
                SearchType = "ID";
            }
            else
            {
                SearchType = "Name";
            }
            SearchCustomerInfo(SearchType,txt_Search.Text);
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("There Are No Data To Print");
                return;
            }
            
            Rp_AllCustomers rpt = new Rp_AllCustomers();
            rpt.SetDataSource((DataTable)dataGridView1.DataSource);
            
            var Parent = this.MdiParent as Main_Form;
            Parent.DisplayReports<Rp_AllCustomers>(rpt);




        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Title_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Date_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, helpProvider1.HelpNamespace,HelpNavigator.Topic,this.helpProvider1.GetHelpKeyword(this));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_Customers_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void frm_Customers_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadTable();
            cmb_Search.SelectedIndex = 0;

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            cmb_Search.SelectedItem = "National ID";
            txt_Search.Clear();
            LoadTable();
        }

        private void btn_Reset_Click_1(object sender, EventArgs e)
        {
            cmb_Search.SelectedIndex = 0;
            txt_Search.Clear();
            LoadTable();
        }
    }
}
