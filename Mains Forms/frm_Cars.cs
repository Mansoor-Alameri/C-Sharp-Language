using Car_Rental_System_New_Virsion.Classes;
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
    public partial class frm_Cars : Form
    {
        public frm_Cars()
        {
            InitializeComponent();
        }

        private bool LoadTable(string query = "SELECT * FROM V_AllCars ")
        {
           
            DataTable dt = new DataTable();
            Database.LoadData(query, dt);
            if (dt.Rows.Count == 0 )
                return false;

            dataGridView1.DataSource = dt;
            //dataGridView1.Columns["ID"].Visible = false;
            
            return true;
            //dataGridView1.Columns["IsDelete"].Visible = false;
        }

        private void frm_Cars_Load(object sender, EventArgs e)
        {
            LoadTable();
            cmb_Search.SelectedIndex = 0;
        }
        
        private void btn_New_Click(object sender, EventArgs e)
        {
            frm_AddCar frm = new frm_AddCar();
            var Parent = this.MdiParent as Main_Form;
            frm.FormClosed += this.frm_Cars_FormClosed;

            Parent.Displayform<frm_AddCar>(frm);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string LoadCar_IDInfo()
        {
            if (dataGridView1.CurrentRow == null)
                return null;

           
            DataGridViewRow Row = dataGridView1.CurrentRow;


            string Car_ID = Row.Cells["ID"].Value.ToString();
            

            return Car_ID;
        }

        private void btn_Mange_Click(object sender, EventArgs e)
        {
            string Car_ID = LoadCar_IDInfo();

            if (Car_ID == null)
            {
                MessageBox.Show("Select Car!!!");
                return;
            }
            frm_EditCar frm = new frm_EditCar(Car_ID);
            var Parent = this.MdiParent as Main_Form;
            frm.FormClosed += this.frm_Cars_FormClosed;

            Parent.DisplayformWithCons(frm);
        }

        private void frm_Cars_Paint(object sender, PaintEventArgs e)
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

        private void SearchCarInfo(string SearchType, string ValueSearch)
        {
            string query = "SELECT * FROM V_AllCars WHERE " + SearchType + " = '" + ValueSearch + "'";

            if (!LoadTable(query))
            {
                MessageBox.Show("No Car found with the provided information.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                SearchType = "ID";
            }
            else
            {
                SearchType = "Name";
            }
            SearchCarInfo(SearchType, txt_Search.Text);
        }

        private void frm_Cars_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadTable();
            cmb_Search.SelectedIndex = 0;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            cmb_Search.SelectedIndex = 0;
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

            Rp_AllCars rpt = new Rp_AllCars();
            rpt.SetDataSource((DataTable)dataGridView1.DataSource);

            var Parent = this.MdiParent as Main_Form;
            Parent.DisplayReports<Rp_AllCars>(rpt);
        }
    }
}
