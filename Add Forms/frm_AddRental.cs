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
    public partial class frm_AddRental : Form
    {
        int X;
        public frm_AddRental()
        {
            InitializeComponent();
        }

        private void ReturnLAstID()
        {
            Database.Open();

            SqlCommand cmd = new SqlCommand("select max(ID) from Rentals", Database.Connection);

            if (cmd.ExecuteScalar() == DBNull.Value)
            {
                X = 1;
            }
            else
            {
                X = Convert.ToInt32(cmd.ExecuteScalar());
                X++;
            }
            txt_ID.Text = X.ToString();
            Database.Close();
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
            string query = "SELECT * FROM Cars where State = 'Available' AND IsDelete = 0 ";
            SqlDataAdapter da = new SqlDataAdapter(query, Database.Connection);
            DataTable dtCars = new DataTable();
            da.Fill(dtCars);

            dtCars.Columns.Add("Display_Field", typeof(string), "Name + ', ' + Model + ', ' + Brand");
            cmb_Car.DataSource = dtCars;
            cmb_Car.DisplayMember = "Display_Field";
            cmb_Car.ValueMember = "ID";

        }
        private void frm_AddRental_Load(object sender, EventArgs e)
        {
            ReturnLAstID();
            LoadCustomers();
            LoadCars();

            dtp_End.MinDate = dtp_Start.Value;

            cmb_Car.Text = "";
            cmb_Custmer.Text = "";
            
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
                errorProvider_Add.SetError(txt, "This field is required");
            }
            else
            {
                errorProvider_Add.SetError(txt, "");
            }
        }
        
        private void CheckValidation(ComboBox cmb)
        {
            if (string.IsNullOrWhiteSpace(cmb.Text))
            {
                errorProvider_Add.SetError(cmb, "This field is required");
            }
            else
            {
                errorProvider_Add.SetError(cmb, "");
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
                    if (!string.IsNullOrWhiteSpace(errorProvider_Add.GetError((TextBox)ctrl)))
                    {
                        return false;

                    }
                }
                else if (ctrl is ComboBox)
                {
                    if (!string.IsNullOrWhiteSpace(errorProvider_Add.GetError((ComboBox)ctrl)))
                    {
                        return false;

                    }
                }
                
            }
            return true;

        }

        private void ClearAllFields()
        {
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
                else if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).SelectedIndex = -1;
                }
                
            }
        }
        private void UpdateCarState(int Car_ID, string State)
        {
            SqlCommand sqlCommand = new SqlCommand("UPDATE Cars SET State = @State WHERE ID = @Car_ID", Database.Connection);
            sqlCommand.Parameters.AddWithValue("@State", State);
            sqlCommand.Parameters.AddWithValue("@Car_ID", Car_ID);
            Database.Open();

            sqlCommand.ExecuteNonQuery();
            Database.Close();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            CheackAllValidation();

            if(txt_Days.Text == "0")
                errorProvider_Add.SetError(txt_Days, "This field is required");
            else
                errorProvider_Add.SetError(txt_Days, "");

            if (IsValid())
            {
                if (MessageBox.Show("Are you sure you want to add this rental?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var Parent = this.MdiParent as Main_Form;

                    SqlCommand cmd = new SqlCommand("Insert Into Rentals (Customer_ID, Car_ID, Start_Date, End_Date, Cost, Contract_Number, User_ID, Discount ) Values (@Customer_ID, @Car_ID, @Start_Date, @End_Date, @Cost, @Contract_Number, @User_ID, @Discount)", Database.Connection);
                    cmd.Parameters.AddWithValue("@Customer_ID", Convert.ToInt32(cmb_Custmer.SelectedValue));
                    cmd.Parameters.AddWithValue("@Car_ID", Convert.ToInt32(Convert.ToInt32(cmb_Car.SelectedValue)));
                    cmd.Parameters.AddWithValue("@Start_Date", Convert.ToDateTime(dtp_Start.Text));
                    cmd.Parameters.AddWithValue("@End_Date", Convert.ToDateTime(dtp_End.Text));
                    cmd.Parameters.AddWithValue("@Cost", Convert.ToInt32(txt_Total_Price.Text));
                    cmd.Parameters.AddWithValue("@Contract_Number", txt_Contract_NO.Text);
                    cmd.Parameters.AddWithValue("@User_ID", Convert.ToInt32(Parent.UserID));
                    cmd.Parameters.AddWithValue("@Discount", Convert.ToDouble(txt_Discount.Text.Replace('%', ' ').Trim()));

                    Database.Open();
                    if (Convert.ToInt32(cmd.ExecuteNonQuery()) > 0)
                    {
                        UpdateCarState(Convert.ToInt32(cmb_Car.SelectedValue), "Not Available");

                        MessageBox.Show("Rental added successfully!");
                        Database.Close();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Error Car Not Added");
                    }
                   
                    Database.Close();



                }
                ClearAllFields();
                ReturnLAstID();
                txt_Price_Per_Day.Text = "0";
                txt_Days.Text = "0";
                txt_Discount.Text = "%0";

            }
            else
            {
                MessageBox.Show("Please correct the errors before saving.");
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txt_Discount_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_Days_TextChanged(object sender, EventArgs e)
        {
            if (txt_Price_Per_Day.Text != "0" && txt_Price_Per_Day.Text != "")
                txt_Total_Price.Text = CalculateTotalPrice().ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, helpProvider1.HelpNamespace, HelpNavigator.Topic, this.helpProvider1.GetHelpKeyword(this));

        }
    }
}
