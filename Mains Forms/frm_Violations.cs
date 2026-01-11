using Car_Rental_System_New_Virsion.Reports;
using System;
using System.Collections;
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
    public partial class frm_Violations : Form
    {
        private string _Rental_ID = null;
        public frm_Violations()
        {
            InitializeComponent();
        }
        public frm_Violations(string Rental_ID)
        {
            InitializeComponent();
            _Rental_ID = Rental_ID;
        }

        private bool LoadTable(string ValueSearch, string SearchType = "[Rental ID]")
        {
            string query = "SELECT * FROM V_AllViolations WHERE " + SearchType + " = '" + ValueSearch + "'";

            DataTable dt = new DataTable();
            Database.LoadData(query, dt);

            if (dt.Rows.Count == 0 )
                return false;

            dataGridView1.DataSource = dt;
            //dataGridView1.Columns["IsDelete"].Visible = false;
            dataGridView1.Columns["Rental ID"].Visible = false;
            dataGridView1.Columns["Car_ID"].Visible = false;
            return true;

        }

        private void frm_Violations_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_New_Click(object sender, EventArgs e)
        {

            frm_AddViolation frm = new frm_AddViolation();
            var Parent = this.MdiParent as Main_Form;
            frm.FormClosed += this.frm_Violations_FormClosed;

            Parent.Displayform<frm_AddViolation>(frm);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

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

        private void SearchViolationsInfo(string SearchType, string ValueSearch)
        {
            string query = "SELECT * FROM V_AllViolations WHERE " + SearchType + " = '" + ValueSearch + "'";

            if (!LoadTable(query))
            {
                MessageBox.Show("No Violation(s) found with the provided information.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void GetTotalViolations()
        {
            int total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToInt32(row.Cells["Cost"].Value);
            }
            txt_Sum.Text = total.ToString();
        }

        private void GetTotalPaymented()
        {
            int total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Payment"].Value.ToString() == "Paid")
                {
                    total += Convert.ToInt32(row.Cells["Cost"].Value);
                }
            }
            txt_Paid.Text = total.ToString();
        }

        private void GetTotalUnPaymented()
        {
            int total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Payment"].Value.ToString() == "Unpaid")
                {
                    total += Convert.ToInt32(row.Cells["Cost"].Value);
                }
            }
            txt_Remining.Text = total.ToString();
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            CheckValidation(txt_Search);

            if (errorProvider.GetError(txt_Search) != "")
            {
                SystemSounds.Hand.Play();
                return;
            }

            if (!LoadTable(txt_Search.Text))
            {
                MessageBox.Show("No Violation(s) found with the provided information.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Search.Clear();
                dataGridView1.DataSource = null;
                txt_Sum.Clear();
                txt_Paid.Clear();
                txt_Remining.Clear();
            }
            else
            {
                GetTotalViolations();
                GetTotalPaymented();
                GetTotalUnPaymented();

                if (txt_Remining.Text != "0")
                {
                    btn_Payment.Enabled = true;
                }
                else
                {
                    btn_Payment.Enabled = false;
                }
            }
            //SearchViolationsInfo("Rental_ID", txt_Search.Text);
        }

        private void frm_Violations_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frm_Violations_FormClosed(object sender, FormClosedEventArgs e)
        {
            

        }

        private void frm_Violations_Shown(object sender, EventArgs e)
        {
            if (_Rental_ID != null)
            {
                
                txt_Search.Text = _Rental_ID;
                btn_Search.PerformClick();
            }
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Paymented_Click(object sender, EventArgs e)
        {

        }

        private void m_Click(object sender, EventArgs e)
        {

        }

        private void btn_Mange_Click(object sender, EventArgs e)
        {

            
            var Parent = this.MdiParent as Main_Form;
            Parent.OpenAddPaymentForm(txt_Search.Text);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Search.Clear();
            dataGridView1.DataSource = null;
            txt_Sum.Clear();
            txt_Paid.Clear();
            txt_Remining.Clear();
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, helpProvider1.HelpNamespace, HelpNavigator.Topic, this.helpProvider1.GetHelpKeyword(this));

        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("There Are No Data To Print");
                return;
            }
            int clientId = Convert.ToInt32(txt_Search.Text);

            DataTable dt = new DataTable();

            string query = "SELECT * FROM V_AllViolations WHERE  [Rental ID] =  @id";
            SqlDataAdapter da = new SqlDataAdapter(query, Database.Connection);
            da.SelectCommand.Parameters.AddWithValue("@id", clientId);
            da.Fill(dt);

            Rp_RentalViolations rpt = new Rp_RentalViolations();
            rpt.SetDataSource(dt);

            var Parent = this.MdiParent as Main_Form;
            Parent.DisplayReports<Rp_RentalViolations>(rpt);
        }
    }
}
