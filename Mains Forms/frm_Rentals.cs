//using Car_Rental_System_New_Virsion.Classes;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Linq;
//using System.Media;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Car_Rental_System_New_Virsion
//{
//    public partial class frm_Rentals : Form
//    {
//        public frm_Rentals()
//        {
//            InitializeComponent();
//        }
//        bool userSelected = false;

//        //private bool LoadTable(string query = "")
//        //{

//        //    bool booleanFilter = false;

//        //    if (!string.IsNullOrEmpty(query))
//        //    {

//        //    }
//        //    else if (cmb_Display_Rentals.SelectedItem.ToString() == "All Rentals")
//        //    {
//        //        query = "SELECT * FROM V_AllRentals";
//        //        booleanFilter = true;
//        //    }
//        //    else if (cmb_Display_Rentals.SelectedItem.ToString() == "Completed Rentals")
//        //    {
//        //        query = "Select * From V_AllRentals Where State = 'Release' And [Is Has Violations] = 'No' ;";
//        //        booleanFilter = true;

//        //    }
//        //    else
//        //        query = "Select * From V_AllRentals Where ([End Date] < GETDATE() And State = 'Not Release') OR ([End Date] > GETDATE()) OR [Is Has Violations] = 'Yes'; ";


//        //    //dataGridView1.DataSource = null;
//        //    DataTable dt = new DataTable();
//        //    Database.LoadData(query, dt);

//        //    if (dt.Rows.Count == 0 )
//        //        return false;

//        //    dataGridView1.DataSource = dt;
//        //    dataGridView1.Columns["Customer_ID"].Visible = false;
//        //    dataGridView1.Columns["Car_ID"].Visible = false;
//        //    //dataGridView1.Columns["Payment State"].Visible = false;
//        //    dataGridView1.Columns["Notes"].Visible = false;
//        //    dataGridView1.Columns["Price_Per_Day"].Visible = false;
//        //    dataGridView1.Columns["CustomerID"].Visible = false;
//        //    dataGridView1.Columns["CarID"].Visible = false;
//        //    dataGridView1.Columns["Is Has Violations"].Visible = false;

//        //    if (booleanFilter)
//        //    {
//        //        dataGridView1.Columns["Created_at"].Visible = false;

//        //    }
//        //    return true;
//        //    //dataGridView1.Columns["IsDelete"].Visible = false;
//        //}

//        private bool LoadTable(string query = "")
//        {
//            // حماية من Null
//            if (cmb_Display_Rentals.SelectedItem == null && string.IsNullOrEmpty(query))
//                return false;

//            bool hideCreatedAtColumn = false;

//            // إذا لم يُمرر Query جاهز، يتم بناؤه حسب الكمبوبوكس
//            if (string.IsNullOrEmpty(query))
//            {
//                string selected = cmb_Display_Rentals.SelectedItem.ToString();

//                if (selected == "All Rentals")
//                {
//                    query = "SELECT * FROM V_AllRentals";
//                    hideCreatedAtColumn = true;
//                }
//                else if (selected == "Completed Rentals")
//                {
//                    query = @"SELECT * 
//                      FROM V_AllRentals 
//                      WHERE State = 'Release' 
//                      AND [Is Has Violations] = 'No'";
//                    hideCreatedAtColumn = true;
//                }
//                else
//                {
//                    query = @"SELECT * 
//                      FROM V_AllRentals 
//                      WHERE 
//                      ([End Date] < GETDATE() AND State = 'Not Release')
//                      OR ([End Date] > GETDATE())
//                      OR [Is Has Violations] = 'Yes'";
//                }
//            }

//            DataTable dt = new DataTable();
//            Database.LoadData(query, dt);

//            if (dt.Rows.Count == 0)
//                return false;

//            // منع إعادة حساب الـ Layout أثناء التعديل
//            dataGridView1.SuspendLayout();

//            dataGridView1.DataSource = null;
//            dataGridView1.DataSource = dt;

//            HideColumn("Customer_ID");
//            HideColumn("Car_ID");
//            HideColumn("CustomerID");
//            HideColumn("CarID");
//            HideColumn("Notes");
//            HideColumn("Price_Per_Day");
//            HideColumn("Is Has Violations");

//            if (hideCreatedAtColumn)
//                HideColumn("Created_at");

//            dataGridView1.ResumeLayout();

//            return true;
//        }

//        private void HideColumn(string columnName)
//        {
//            if (dataGridView1.Columns.Contains(columnName))
//                dataGridView1.Columns[columnName].Visible = false;
//        }
//        private void frm_Rentals_Load(object sender, EventArgs e)
//        {
//            cmb_Display_Rentals.SelectedIndex = 0;

//            //LoadTable();
//        }

//        private void btn_New_Click(object sender, EventArgs e)
//        {

//            frm_AddRental frm = new frm_AddRental();
//            var Parent = this.MdiParent as Main_Form;
//            frm.FormClosed += this.frm_Rentals_FormClosed;
//            Parent.Displayform<frm_AddRental>(frm);

//        }

//        private void btn_Exit_Click(object sender, EventArgs e)
//        {
//            Application.Exit();

//        }

//        private clsRentals LoadRentalInfo()
//        {
//            if (dataGridView1.CurrentRow == null)
//                return null;

//            clsRentals Rental = new clsRentals();

//            DataGridViewRow Row = dataGridView1.CurrentRow;


//            Rental.ID = Row.Cells["ID"].Value.ToString();
//            Rental.Customer = Row.Cells["CustomerID"].Value.ToString();
//            Rental.Car = Row.Cells["CarID"].Value.ToString();
//            Rental.Start_Rental = Row.Cells["Start Date"].Value.ToString();
//            Rental.End_Rental = Row.Cells["End Date"].Value.ToString();
//            Rental.Discount = Row.Cells["Discount"].Value.ToString();
//            Rental.PricePerDay = Row.Cells["Price_Per_Day"].Value.ToString();
//            Rental.TotalPrice = Row.Cells["Rental Price"].Value.ToString();

//            Rental.ContractNo = Row.Cells["Contract Number"].Value.ToString();

//            if (Row.DefaultCellStyle.BackColor == Color.Orange)
//                Rental.Can_Release_Car = "Yes";
//            else
//                Rental.Can_Release_Car = "No";


//                return Rental;
//        }

//        private void btn_Mange_Click(object sender, EventArgs e)
//        {
//            var Parent = this.MdiParent as Main_Form;
//            if(Parent.Job_Title != "Manager")
//            {
//                MessageBox.Show("You Don't Have The Permissions To Mange Rentals");
//                return;
//            }

//            if (dataGridView1.CurrentRow == null)
//            {
//                MessageBox.Show("Select Rental!!!");
//                return;
//            }

//            if (dataGridView1.CurrentRow.Cells["Payment State"].Value.ToString() == "Paid")
//            {
//                MessageBox.Show("You can't Mange Rental Has a Payment Opreation");
//                return;
//            }


//            clsRentals Rental = LoadRentalInfo();

//            if (Rental == null)
//            {
//                MessageBox.Show("Select Rental!!!");
//                return;
//            }
//            frm_EditRental frm = new frm_EditRental(Rental);
//            frm.FormClosed += this.frm_Rentals_FormClosed;

//            Parent.DisplayformWithCons(frm);
//        }

//        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
//        {
//            if (dataGridView1.Rows[e.RowIndex].DataBoundItem == null /*|| dataGridView1.Rows.Count == 1*/)
//            {
//                return;
//            }
//            DataGridViewRow Row = dataGridView1.Rows[e.RowIndex];

//            string State = Row.Cells["state"].Value.ToString();
//            string Payment = Row.Cells["Payment State"].Value.ToString();
//            string IsHasViolations = Row.Cells["Is Has Violations"].Value.ToString();

//            DateTime dt = Convert.ToDateTime(Row.Cells["End Date"].Value);

//            if (State == "Not Release" && Payment == "Paid" && dt < DateTime.Now)
//            {
//                Row.DefaultCellStyle.BackColor = Color.Orange;
//                Row.DefaultCellStyle.SelectionBackColor = Color.Orange;

//            }

//            if (State == "Release" && IsHasViolations == "Yes")
//            {
//                Row.DefaultCellStyle.BackColor = Color.Silver;
//                Row.DefaultCellStyle.SelectionBackColor = Color.Silver;

//            }

//            if (State == "Not Release" && Payment == "Paid" && dt < DateTime.Now && IsHasViolations == "Yes")
//            {
//                Row.DefaultCellStyle.BackColor = Color.Peru;
//                Row.DefaultCellStyle.SelectionBackColor = Color.Peru;

//            }


//            if (State == "Release" && IsHasViolations == "No")
//            {
//                Row.DefaultCellStyle.BackColor = Color.LightGreen;
//                Row.DefaultCellStyle.SelectionBackColor = Color.LightGreen;

//            }

//            if (Payment == "Unpaid")
//            {
//                Row.DefaultCellStyle.BackColor = Color.Red;
//                Row.DefaultCellStyle.SelectionBackColor = Color.Red;

//            }
//        }



//        private void comboBox1_DropDown(object sender, EventArgs e)
//        {
//            userSelected = true;
//        }


//        private void cmb_Display_Rentals_SelectionChangeCommitted(object sender, EventArgs e)
//        {
//            if (!userSelected) 
//                return;

//            // كودك هنا
//            userSelected = false;
//            //LoadTable();



//        }

//        private void dataGridView1_Paint(object sender, PaintEventArgs e)
//        {

//        }

//        private void frm_Rentals_Paint(object sender, PaintEventArgs e)
//        {
//        }
//        private void CheckValidation(TextBox txt)
//        {
//            if (string.IsNullOrWhiteSpace(txt.Text))
//            {
//                errorProvider.SetError(txt, "This field is required");
//            }
//            else
//            {
//                errorProvider.SetError(txt, "");
//            }
//        }

//        private void SearchRentalInfo(string SearchType, string ValueSearch)
//        {
//            string query = "SELECT * FROM V_AllRentals WHERE " + SearchType + " = '" + ValueSearch + "'";

//            if (!LoadTable(query))
//            {
//                MessageBox.Show("No Rental found with the provided information.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
//            }

//        }
//        private void btn_Search_Click(object sender, EventArgs e)
//        {
//            //cmb_Display_Rentals.SelectedItem = " ";
//            //CheckValidation(txt_Search);

//            //if (errorProvider.GetError(txt_Search) != "")
//            //{
//            //    SystemSounds.Hand.Play();
//            //    return;
//            //}
//            if (string.IsNullOrWhiteSpace(txt_Search.Text))
//                LoadTable();
//            else
//            {
//                cmb_Display_Rentals.SelectedItem = "All Rentals";
//                SearchRentalInfo("ID", txt_Search.Text);

//            }
//        }

//        private void frm_Rentals_Shown(object sender, EventArgs e)
//        {
//            //cmb_Display_Rentals.SelectedIndex = 0;

//            //LoadTable();

//        }

//        private void frm_Rentals_FormClosed(object sender, FormClosedEventArgs e)
//        {
//            LoadTable();
//        }

//        private void btn_Print_Click(object sender, EventArgs e)
//        {
//            if (dataGridView1.Rows.Count == 0)
//            {
//                MessageBox.Show("There Are No Data To Print");
//                return;
//            }
//        }

//        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
//        {
//        }

//        private void UpdateCarState(int Car_ID, string State)
//        {
//            SqlCommand sqlCommand = new SqlCommand("UPDATE Cars SET State = @State WHERE ID = @Car_ID", Database.Connection);
//            sqlCommand.Parameters.AddWithValue("@State", State);
//            sqlCommand.Parameters.AddWithValue("@Car_ID", Car_ID);
//            Database.Open();

//            if (Convert.ToInt32(sqlCommand.ExecuteNonQuery()) > 0)
//            {
//                MessageBox.Show("Car Released Successfully");
//            }
//            else
//                MessageBox.Show("Error Car Not Released");

//            Database.Close();
//        }
//        private void UpdateRentalState(int Rental_ID, string State)
//        {
//            SqlCommand sqlCommand = new SqlCommand("UPDATE Rentals SET State = @State WHERE ID = @Rental_ID", Database.Connection);
//            sqlCommand.Parameters.AddWithValue("@State", State);
//            sqlCommand.Parameters.AddWithValue("@Rental_ID", Rental_ID);
//            Database.Open();

//            if (Convert.ToInt32(sqlCommand.ExecuteNonQuery()) > 0)
//            {
//                MessageBox.Show("Rental Released Successfully");
//            }
//            else
//                MessageBox.Show("Error Rental Not Released");

//            Database.Close();
//        }
//        private void btn_Release_Car_Click(object sender, EventArgs e)
//        {
//            if (MessageBox.Show("Are you sure you want to Release Car?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
//            {
//                UpdateCarState(Convert.ToInt32(dataGridView1.CurrentRow.Cells["CarID"].Value.ToString()), "Available");
//                UpdateRentalState(Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString()), "Release");
//                btn_Release_Car.Enabled = false;
//                LoadTable();

//            }
//        }

//        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
//        {

//            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.DefaultCellStyle.BackColor == Color.Empty)
//                return;
//            //MessageBox.Show(dataGridView1.CurrentRow.DefaultCellStyle.BackColor.ToString());
//            if (dataGridView1.CurrentRow.DefaultCellStyle.BackColor == Color.Orange)
//            {
//                btn_Release_Car.Enabled = true;

//            }
//            else
//            {
//                btn_Release_Car.Enabled = false;

//            }
//            if (dataGridView1.CurrentRow.DefaultCellStyle.BackColor == Color.Red)
//            {
//                btn_Payment.Enabled = true;

//            }
//            else
//            {
//                btn_Payment.Enabled = false;

//            }

//        }

//        private void btn_Violations_Click(object sender, EventArgs e)
//        {
//            frm_Violations frm = new frm_Violations(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
//            var Parent = this.MdiParent as Main_Form;
//            Parent.DisplayformWithCons(frm);
//        }

//        private void pictureBox1_Click(object sender, EventArgs e)
//        {

//        }

//        private void panel3_Paint(object sender, PaintEventArgs e)
//        {

//        }

//        private void label4_Click(object sender, EventArgs e)
//        {

//        }

//        private void gp_Search_Enter(object sender, EventArgs e)
//        {

//        }

//        private void label1_Click(object sender, EventArgs e)
//        {

//        }

//        private void btn_Reset_Click(object sender, EventArgs e)
//        {
//            txt_Search.Clear();
//            cmb_Display_Rentals.SelectedItem = "All Rentals";
//            btn_Search_Click(null, null);
//        }

//        private void btn_Payment_Click(object sender, EventArgs e)
//        {
//            var Parent = this.MdiParent as Main_Form;
//            Parent.OpenAddPaymentForm(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
//        }

//        private void btn_Help_Click(object sender, EventArgs e)
//        {
//            System.Windows.Forms.Help.ShowHelp(this, helpProvider1.HelpNamespace, HelpNavigator.Topic, this.helpProvider1.GetHelpKeyword(this));

//        }
//    }
//}



using Car_Rental_System_New_Virsion.Classes;
using Car_Rental_System_New_Virsion.Reports;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Car_Rental_System_New_Virsion
{
    public partial class frm_Rentals : Form
    {
        public frm_Rentals()
        {
            InitializeComponent();
        }

        private void frm_Rentals_Load(object sender, EventArgs e)
        {
            cmb_Display_Rentals.SelectedIndex = 0;
            //
            //LoadTable();
        }

        #region Load & Display

        private bool LoadTable(string query = "")
        {
            if (cmb_Display_Rentals.SelectedItem == null && string.IsNullOrEmpty(query))
                return false;

            bool hideCreatedAtColumn = false;

            if (string.IsNullOrEmpty(query))
            {
                string selected = cmb_Display_Rentals.SelectedItem.ToString();

                switch (selected)
                {
                    case "All Rentals":
                        query = "SELECT * FROM V_AllRentals";
                        hideCreatedAtColumn = true;
                        break;

                    case "Completed Rentals":
                        query = @"SELECT * FROM V_AllRentals 
                                  WHERE State = 'Release' AND [Is Has Violations] = 'No'";
                        hideCreatedAtColumn = true;
                        break;

                    default:
                        query = @"SELECT * FROM V_AllRentals 
                                  WHERE ([End Date] < GETDATE() AND State = 'Not Release')
                                  OR ([End Date] > GETDATE()) 
                                  OR [Is Has Violations] = 'Yes'";
                        break;
                }
            }

            DataTable dt = new DataTable();
            Database.LoadData(query, dt);

            if (dt.Rows.Count == 0 && !string.IsNullOrWhiteSpace(txt_Search.Text))
                return false;

            dataGridView1.SuspendLayout();
            this.SuspendLayout();

            dataGridView1.DataSource = dt;

            HideColumn("Customer_ID");
            HideColumn("Car_ID");
            HideColumn("CustomerID");
            HideColumn("CarID");
            HideColumn("Notes");
            HideColumn("Price_Per_Day");
            HideColumn("Is Has Violations");
            if (hideCreatedAtColumn)
                HideColumn("Created_at");

            ColorRows();
            UpdateButtonStates();

            dataGridView1.ResumeLayout();
            this.ResumeLayout();

            return true;
        }

        private void HideColumn(string columnName)
        {
            if (dataGridView1.Columns.Contains(columnName))
                dataGridView1.Columns[columnName].Visible = false;
        }

        private void ColorRows()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.DataBoundItem == null) continue;

                string state = row.Cells["State"].Value.ToString();
                string payment = row.Cells["Payment State"].Value.ToString();
                string hasViolations = row.Cells["Is Has Violations"].Value.ToString();
                DateTime endDate = Convert.ToDateTime(row.Cells["End Date"].Value);

                if (state == "Not Release" && payment == "Paid" && endDate < DateTime.Now && hasViolations == "Yes")
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.DefaultCellStyle.SelectionBackColor = Color.Yellow;

                }
                else if (state == "Not Release" && payment == "Paid" && endDate < DateTime.Now)
                {
                    row.DefaultCellStyle.BackColor = Color.Orange;
                    row.DefaultCellStyle.SelectionBackColor = Color.Orange;
                }
                else if (state == "Release" && hasViolations == "Yes")
                {
                    row.DefaultCellStyle.BackColor = Color.Silver;
                    row.DefaultCellStyle.SelectionBackColor = Color.Silver;
                }
                else if (state == "Release" && hasViolations == "No")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                    row.DefaultCellStyle.SelectionBackColor = Color.LightGreen;
                }
                else if (payment == "Unpaid")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.SelectionBackColor = Color.Red;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                }
            }
        }

        private void UpdateButtonStates()
        {
            if (dataGridView1.CurrentRow == null)
            {
                btn_Release_Car.Enabled = false;
                btn_Payment.Enabled = false;
                return;
            }

            var color = dataGridView1.CurrentRow.DefaultCellStyle.BackColor;

            btn_Release_Car.Enabled = color == Color.Orange ;
            btn_Payment.Enabled = color == Color.Red || color == Color.Yellow;
        }

        #endregion

        #region Selection & ComboBox

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            UpdateButtonStates();
        }

        private clsRentals LoadRentalInfo()
        {
            if (dataGridView1.CurrentRow == null)
                return null;

            clsRentals Rental = new clsRentals();

            DataGridViewRow Row = dataGridView1.CurrentRow;


            Rental.ID = Row.Cells["ID"].Value.ToString();
            Rental.Customer = Row.Cells["CustomerID"].Value.ToString();
            Rental.Car = Row.Cells["CarID"].Value.ToString();
            Rental.Start_Rental = Row.Cells["Start Date"].Value.ToString();
            Rental.End_Rental = Row.Cells["End Date"].Value.ToString();
            Rental.Discount = Row.Cells["Discount"].Value.ToString();
            Rental.PricePerDay = Row.Cells["Price_Per_Day"].Value.ToString();
            Rental.TotalPrice = Row.Cells["Rental Price"].Value.ToString();

            Rental.ContractNo = Row.Cells["Contract Number"].Value.ToString();

            if (Row.DefaultCellStyle.BackColor == Color.Orange)
                Rental.Can_Release_Car = "Yes";
            else
                Rental.Can_Release_Car = "No";


            return Rental;
        }

        private void btn_Mange_Click(object sender, EventArgs e)
        {
            var Parent = this.MdiParent as Main_Form;
            if (Parent.Job_Title != "Manager")
            {
                MessageBox.Show("You Don't Have The Permissions To Mange Rentals");
                return;
            }

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Select Rental!!!");
                return;
            }

            if (dataGridView1.CurrentRow.Cells["Payment State"].Value.ToString() == "Paid")
            {
                MessageBox.Show("You can't Mange Rental Has a Payment Opreation");
                return;
            }


            clsRentals Rental = LoadRentalInfo();

            if (Rental == null)
            {
                MessageBox.Show("Select Rental!!!");
                return;
            }
            frm_EditRental frm = new frm_EditRental(Rental);
            frm.FormClosed += this.frm_Rentals_FormClosed;

            Parent.DisplayformWithCons(frm);
        }
        private void cmb_Display_Rentals_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadTable();
        }

        #endregion

        #region Buttons

        private void btn_New_Click(object sender, EventArgs e)
        {
            frm_AddRental frm = new frm_AddRental();
            var Parent = this.MdiParent as Main_Form;
            frm.FormClosed += this.frm_Rentals_FormClosed;
            Parent.Displayform<frm_AddRental>(frm);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Release_Car_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Release Car?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UpdateCarState(Convert.ToInt32(dataGridView1.CurrentRow.Cells["CarID"].Value), "Available");
                UpdateRentalState(Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value), "Release");
                LoadTable();
            }
        }

        private void btn_Payment_Click(object sender, EventArgs e)
        {
            var Parent = this.MdiParent as Main_Form;
            Parent.OpenAddPaymentForm(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Search.Text))
                LoadTable();
            else
            {
                cmb_Display_Rentals.SelectedItem = "All Rentals";
                SearchRentalInfo("ID", txt_Search.Text);
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Search.Clear();
            cmb_Display_Rentals.SelectedItem = "All Rentals";
            LoadTable();
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            
            System.Windows.Forms.Help.ShowHelp(this, helpProvider1.HelpNamespace, HelpNavigator.Topic, this.helpProvider1.GetHelpKeyword(this));
        }

        private void btn_Violations_Click(object sender, EventArgs e)
        {
            frm_Violations frm = new frm_Violations(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
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

            Rp_AllRentals rpt = new Rp_AllRentals();
            rpt.SetDataSource((DataTable)dataGridView1.DataSource);

            var Parent = this.MdiParent as Main_Form;
            Parent.DisplayReports<Rp_AllRentals>(rpt);
        }


        #endregion

        #region Database Operations

        private void UpdateCarState(int Car_ID, string State)
        {
            SqlCommand sqlCommand = new SqlCommand("UPDATE Cars SET State = @State WHERE ID = @Car_ID", Database.Connection);
            sqlCommand.Parameters.AddWithValue("@State", State);
            sqlCommand.Parameters.AddWithValue("@Car_ID", Car_ID);
            Database.Open();
            sqlCommand.ExecuteNonQuery();
            Database.Close();
        }

        private void UpdateRentalState(int Rental_ID, string State)
        {
            SqlCommand sqlCommand = new SqlCommand("UPDATE Rentals SET State = @State WHERE ID = @Rental_ID", Database.Connection);
            sqlCommand.Parameters.AddWithValue("@State", State);
            sqlCommand.Parameters.AddWithValue("@Rental_ID", Rental_ID);
            Database.Open();
            sqlCommand.ExecuteNonQuery();
            Database.Close();
        }

        private void SearchRentalInfo(string SearchType, string ValueSearch)
        {
            string query = $"SELECT * FROM V_AllRentals WHERE {SearchType} = '{ValueSearch}'";

            if (!LoadTable(query))
                MessageBox.Show("No Rental found with the provided information.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region FormClosed

        private void frm_Rentals_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadTable();
        }

        #endregion

        private void frm_Rentals_Shown(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void gp_Search_Enter(object sender, EventArgs e)
        {

        }
    }
}
