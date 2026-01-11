using Car_Rental_System_New_Virsion.Classes;
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
    public partial class frm_EditRental : Form
    {
        private clsRentals _Rental;
        public frm_EditRental(clsRentals Rental)
        {
            InitializeComponent();
            _Rental = Rental;
        }

        private void LoadCustomers()
        {
            string query = "SELECT * FROM V_AllCustomers where Gurantee != 'No Guarrantee' And Customer_Type_ID != 5 ";
            SqlDataAdapter da = new SqlDataAdapter(query, Database.Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmb_Custmer.DataSource = dt;
            cmb_Custmer.DisplayMember = "Name";
            cmb_Custmer.ValueMember = "ID";
        }

        private void LoadCars()
        {
            string query = "SELECT * FROM Cars where IsDelete = 0 ";
            SqlDataAdapter da = new SqlDataAdapter(query, Database.Connection);
            DataTable dtCars = new DataTable();
            da.Fill(dtCars);

            dtCars.Columns.Add("Display_Field", typeof(string), "Name + ', ' + Model + ', ' + Brand");
            cmb_Car.DataSource = dtCars;
            cmb_Car.DisplayMember = "Display_Field";
            cmb_Car.ValueMember = "ID";

        }
        private void LoadInfoToForm()
        {
            if (_Rental != null)
            {
                txt_ID.Text = _Rental.ID;
                cmb_Custmer.SelectedValue = _Rental.Customer;
                cmb_Car.SelectedValue = _Rental.Car;
                dtp_Start.Text = _Rental.Start_Rental;
                dtp_End.Text = _Rental.End_Rental;
                txt_Discount.Text = _Rental.Discount;
                txt_Price_Per_Day.Text = _Rental.PricePerDay;
                txt_Total_Price.Text = _Rental.TotalPrice;
                //txt_Days.Text = _Rental.Days;
                txt_Contract_NO.Text = _Rental.ContractNo;

                txt_Days.Text = Math.Ceiling(Convert.ToDouble((dtp_End.Value - dtp_Start.Value).TotalDays)).ToString();


            }
            else
                MessageBox.Show("Rental Not Found");
        }

        private void frm_EditRental_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadCars();

            LoadInfoToForm();

            


            if (_Rental.Can_Release_Car == "Yes")
            {
                btn_Release_Car.Enabled = true;
            }
            else
                btn_Release_Car.Enabled = false;
        }

        private double CalculateTotalPrice()
        {
            double Price = Convert.ToDouble(txt_Days.Text) * Convert.ToDouble(txt_Price_Per_Day.Text);
            double Discount = Convert.ToDouble(txt_Discount.Text.Replace('%', ' ').Trim());
            double TotalPrice = Price - (Price * (Discount / 100));

            return TotalPrice;
        }
        private void CheckValidation(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text) && txt != txt_Notes)
            {
                errorProvider_Edit.SetError(txt, "This field is required");
            }
            else
            {
                errorProvider_Edit.SetError(txt, "");
            }
        }

        private void CheckValidation(ComboBox cmb)
        {
            if (string.IsNullOrWhiteSpace(cmb.Text))
            {
                errorProvider_Edit.SetError(cmb, "This field is required");
            }
            else
            {
                errorProvider_Edit.SetError(cmb, "");
            }
        }

        private void CheackAllValidation()
        {
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is TextBox)
                {
                    CheckValidation((TextBox)ctrl);
                }
                else if (ctrl is ComboBox)
                {
                    CheckValidation((ComboBox)ctrl);
                }

            }

        }

        private bool IsValid()
        {

            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is TextBox)
                {
                    if (!string.IsNullOrWhiteSpace(errorProvider_Edit.GetError((TextBox)ctrl)))
                    {
                        return false;

                    }
                }
                else if (ctrl is ComboBox)
                {
                    if (!string.IsNullOrWhiteSpace(errorProvider_Edit.GetError((ComboBox)ctrl)))
                    {
                        return false;

                    }
                }

            }
            return true;

        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            CheackAllValidation();

            if (IsValid())
            {
                if (MessageBox.Show("Are you sure you want to Updated this rental?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var Parent = this.MdiParent as Main_Form;

                    SqlCommand cmd = new SqlCommand("Update Rentals Set Customer_ID = @Customer_ID, Car_ID = @Car_ID, Start_Date = @Start_Date, End_Date = @End_Date, Cost = @Cost, Contract_Number = @Contract_Number, Discount = @Discount Where ID = @ID", Database.Connection);
                    cmd.Parameters.AddWithValue("@ID", _Rental.ID);
                    cmd.Parameters.AddWithValue("@Customer_ID", Convert.ToInt32(cmb_Custmer.SelectedValue));
                    cmd.Parameters.AddWithValue("@Car_ID", Convert.ToInt32(cmb_Car.SelectedValue));
                    cmd.Parameters.AddWithValue("@Start_Date", Convert.ToDateTime(dtp_Start.Text));
                    cmd.Parameters.AddWithValue("@End_Date", Convert.ToDateTime(dtp_End.Text));
                    cmd.Parameters.AddWithValue("@Cost", Convert.ToInt32(txt_Total_Price.Text));
                    cmd.Parameters.AddWithValue("@Contract_Number", txt_Contract_NO.Text);
                    cmd.Parameters.AddWithValue("@User_ID", Parent.UserID);
                    cmd.Parameters.AddWithValue("@Discount", Convert.ToDouble(txt_Discount.Text.Replace('%', ' ').Trim()));

                    Database.Open();
                    if (Convert.ToInt32(cmd.ExecuteNonQuery()) > 0)
                    {
                        //UpdateCarState(Convert.ToInt32(cmb_Car.SelectedValue), "Not Available");

                        MessageBox.Show("Rental Updated successfully!");
                        Database.Close();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Error Rental Not Updated");
                    }

                    Database.Close();



                }
            }
            else
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UpdateCarState(int Car_ID, string State)
        {
            SqlCommand sqlCommand = new SqlCommand("UPDATE Cars SET State = @State WHERE ID = @Car_ID", Database.Connection);
            sqlCommand.Parameters.AddWithValue("@State", State);
            sqlCommand.Parameters.AddWithValue("@Car_ID", Car_ID);
            Database.Open();

            int Count = sqlCommand.ExecuteNonQuery();
            
            Database.Close();
            return Count > 0;
        }
        private void btn_Release_Car_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Release Car?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                if (UpdateCarState(Convert.ToInt32(_Rental.Car), "Available"))
                {
                    MessageBox.Show("Car Released Successfully");
                }
                else
                    MessageBox.Show("Error Car Not Released");
                btn_Release_Car.Enabled = false;
            }
        }

        private void btn_Violations_Click(object sender, EventArgs e)
        {
            frm_Violations frm = new frm_Violations(_Rental.ID);
            var Parent = this.MdiParent as Main_Form;
            Parent.DisplayformWithCons(frm);

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete this Rental?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand sqlCommand = new SqlCommand("Update Rentals Set IsDelete = 1 Where ID = @ID", Database.Connection);
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.AddWithValue("@ID", Convert.ToInt32(_Rental.ID));
                Database.Open();
                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    UpdateCarState(Convert.ToInt32(_Rental.Car), "Available");
                    MessageBox.Show("Rental Deleted Successfully");
                    Database.Close();
                    this.Close();
                }
                else
                    MessageBox.Show("Error Rental Not Deleted");
                Database.Close();
            }
        }


        private void dtp_Start_ValueChanged(object sender, EventArgs e)
        {
            dtp_End.MinDate = dtp_Start.Value;

            txt_Days.Text = (dtp_End.Value - dtp_Start.Value).Days.ToString();
        }

        private void dtp_End_ValueChanged(object sender, EventArgs e)
        {
            txt_Days.Text = Math.Ceiling(Convert.ToDouble((dtp_End.Value - dtp_Start.Value).TotalDays)).ToString();

        }

        private void cmb_Car_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmb_Car.SelectedIndex != -1)
            {

                int Car_ID = Convert.ToInt32(cmb_Car.SelectedValue);
                string query = "SELECT * FROM V_AllCars where State = 'Available' And ID = " + Car_ID.ToString();
                SqlCommand cmd = new SqlCommand(query, Database.Connection);
                Database.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    txt_Price_Per_Day.Text = sqlDataReader["Price Per Day"].ToString();
                }
                Database.Close();

                if (!string.IsNullOrWhiteSpace(txt_Total_Price.Text))
                {
                    txt_Total_Price.Text = CalculateTotalPrice().ToString();

                }
            }
        }

        private void txt_Discount_Leave(object sender, EventArgs e)
        {
            if (!txt_Discount.Text.Contains('%'))
            {
                txt_Discount.Text = txt_Discount.Text.Insert(0, "%");

            }
            if (txt_Price_Per_Day.Text != "0" && txt_Days.Text != "0")
                txt_Total_Price.Text = CalculateTotalPrice().ToString();
        }

        
        private void txt_Days_TextChanged(object sender, EventArgs e)
        {
            if (txt_Price_Per_Day.Text != "0" && txt_Price_Per_Day.Text != "")
                txt_Total_Price.Text = CalculateTotalPrice().ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_Notes_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, helpProvider1.HelpNamespace, HelpNavigator.Topic, this.helpProvider1.GetHelpKeyword(this));

        }
    }
}
