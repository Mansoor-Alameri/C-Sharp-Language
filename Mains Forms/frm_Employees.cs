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
    public partial class frm_Employees : Form
    {
        public frm_Employees()
        {
            InitializeComponent();
        }

        private bool LoadTable(string query = "SELECT * FROM V_AllEmployees ")
        {
           
            DataTable dt = new DataTable();
            Database.LoadData(query, dt);

            if (dt.Rows.Count == 0 )
                return false;

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Username"].Visible = false;
            dataGridView1.Columns["Password"].Visible = false;
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["Birth_Day"].Visible = false;
            dataGridView1.Columns["PersonID"].Visible = false;
            dataGridView1.Columns["UserID"].Visible = false;
            return true;
            //dataGridView1.Columns["IsDelete"].Visible = false;
        }

        private void frm_Employees_Load(object sender, EventArgs e)
        {
            LoadTable();
            cmb_Search.SelectedIndex = 0; 
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            
            frm_AddEmployee frm = new frm_AddEmployee();
            var Parent = this.MdiParent as Main_Form;
            frm.FormClosed += this.frm_Employees_FormClosed;

            Parent.Displayform<frm_AddEmployee>(frm);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private clsEmployees LoadEmployeeInfo()
        {
            if (dataGridView1.CurrentRow == null)
                return null;

            clsEmployees Employee = new clsEmployees();

            DataGridViewRow Row = dataGridView1.CurrentRow;


            Employee.ID = Row.Cells["ID"].Value.ToString();
            Employee.PersonID = Row.Cells["PersonID"].Value.ToString();
            Employee.UserID = Row.Cells["UserID"].Value.ToString();
            Employee.Name = Row.Cells["Name"].Value.ToString();
            Employee.Job_Title = Row.Cells["Job Title"].Value.ToString();
            Employee.Gender = Row.Cells["Gender"].Value.ToString();
            Employee.Phone1 = Row.Cells["Phone 1"].Value.ToString();
            Employee.Phone2 = Row.Cells["Phone 2"].Value.ToString();
            Employee.Salary = Row.Cells["Salary"].Value.ToString();
            Employee.Employment_history = Row.Cells["Employment history"].Value.ToString();
            Employee.Identifiy_Type = Row.Cells["Identifier Type"].Value.ToString();
            Employee.Identifiy = Row.Cells["Identifier"].Value.ToString();
            Employee.Address = Row.Cells["Address"].Value.ToString();
            Employee.Birthday = Row.Cells["Birth_Day"].Value.ToString();
            Employee.Username = Row.Cells["Username"].Value.ToString();
            Employee.Password = Row.Cells["Password"].Value.ToString();

            return Employee;
        }
        private void btn_Mange_Click(object sender, EventArgs e)
        {
            clsEmployees Employee = LoadEmployeeInfo();

            if (Employee == null)
            {
                MessageBox.Show("Select Employee!!!");
                return;
            }

            frm_EditEmployee frm = new frm_EditEmployee(Employee);
            var Parent = this.MdiParent as Main_Form;
            frm.FormClosed += this.frm_Employees_FormClosed;

            Parent.DisplayformWithCons(frm);
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

        private void SearchEmployeeInfo(string SearchType, string ValueSearch)
        {
            string query = "SELECT * FROM V_AllEmployees WHERE " + SearchType + " = '" + ValueSearch + "'";

            if (!LoadTable(query))
            {
                MessageBox.Show("No Employee found with the provided information.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            SearchEmployeeInfo(SearchType, txt_Search.Text);
        }

        private void frm_Employees_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void frm_Employees_FormClosed(object sender, FormClosedEventArgs e)
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

            Rp_AllEmployees rpt = new Rp_AllEmployees();
            var Parent = this.MdiParent as Main_Form;
            rpt.SetDataSource((DataTable)dataGridView1.DataSource);
            Parent.DisplayReports<Rp_AllEmployees>(rpt);
        }
    }
}
