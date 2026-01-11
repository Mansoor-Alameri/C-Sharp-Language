using Car_Rental_System_New_Virsion.Classes;
using Car_Rental_System_New_Virsion.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System_New_Virsion
{
    public partial class frm_Payments : Form
    {
        private string _Rental_ID = null;
        public frm_Payments()
        {
            InitializeComponent();
        }
        public frm_Payments(string Rental_ID)
        {
            InitializeComponent();
            _Rental_ID = Rental_ID;
            
        }

        private bool LoadTable(string query = "SELECT * FROM V_AllPayments ")
        {
            
            DataTable dt = new DataTable();
            Database.LoadData(query, dt);

            if (dt.Rows.Count == 0 )
                return false;
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Customer_ID"].Visible = false;
            return true;
            //dataGridView1.Columns["IsDelete"].Visible = false;
        }
        private void OpenAddPaymentForm()
        {
            var Parent = this.MdiParent as Main_Form;
            frm_AddPayment frm = new frm_AddPayment(_Rental_ID);

            frm.FormClosed += this.frm_Payments_FormClosed;
            Parent.DisplayformWithCons(frm);
        }
        private void frm_Payments_Load(object sender, EventArgs e)
        {
            
           LoadTable();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            var Parent = this.MdiParent as Main_Form;
            frm_AddPayment frm = new frm_AddPayment();

            frm.FormClosed += this.frm_Payments_FormClosed;

            Parent.Displayform<frm_AddPayment>(frm);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private clsPayments LoadPaymentInfo()
        {
            if (dataGridView1.CurrentRow == null)
                return null;

            clsPayments Payment = new clsPayments();

            DataGridViewRow Row = dataGridView1.CurrentRow;


            Payment.ID = Row.Cells["ID"].Value.ToString();
            Payment.Rental_ID = Row.Cells["Rental ID"].Value.ToString();
            Payment.Payment_Type = Row.Cells["Type"].Value.ToString();
            Payment.Method = Row.Cells["Payment Method"].Value.ToString();
            Payment.Date = Row.Cells["Date"].Value.ToString();
            Payment.Discount = Row.Cells["Discount"].Value.ToString();
            Payment.TotalPrice = Row.Cells["Total Price"].Value.ToString();

            
            return Payment;
        }

        private void btn_Mange_Click(object sender, EventArgs e)
        {
            var Parent = this.MdiParent as Main_Form;
            if (Parent.Job_Title != "Manager")
            {
                MessageBox.Show("You Don't Have The Permissions To Mange Payments");
                return;
            }
            clsPayments Payment = LoadPaymentInfo();

            if (Payment == null)
            {
                MessageBox.Show("Select Payment!!!");
                return;
            }
            frm_EditPayment frm = new frm_EditPayment(Payment);
           
            frm.FormClosed += this.frm_Payments_FormClosed;

            Parent.DisplayformWithCons(frm);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Title_Click(object sender, EventArgs e)
        {

        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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

        private void SearchPaymentInfo(string SearchType, string ValueSearch)
        {
            string query = "SELECT * FROM V_AllPayments WHERE " + SearchType + " = '" + ValueSearch + "'";

            if (!LoadTable(query))
            {
                MessageBox.Show("No Payment found with the provided information.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            SearchPaymentInfo("ID", txt_Search.Text);
        }

        private void frm_Payments_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadTable();
        }

        private void frm_Payments_Shown(object sender, EventArgs e)
        {
            if (_Rental_ID != null)
                OpenAddPaymentForm();
            
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Search.Clear();
            LoadTable();
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

            Rp_AllPayments rpt = new Rp_AllPayments();
            rpt.SetDataSource((DataTable)dataGridView1.DataSource);

            var Parent = this.MdiParent as Main_Form;
            Parent.DisplayReports<Rp_AllPayments>(rpt);
        }
    }
}
