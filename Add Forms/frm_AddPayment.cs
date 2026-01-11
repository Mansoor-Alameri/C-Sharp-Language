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
    public partial class frm_AddPayment : Form
    {
        int X;

        private string _Rental_ID = null;
        public frm_AddPayment()
        {
            InitializeComponent();
        }
        public frm_AddPayment(string Rental_ID)
        {
            InitializeComponent();
            _Rental_ID = Rental_ID;

        }

        private void ReturnLAstID()
        {
            Database.Open();

            SqlCommand cmd = new SqlCommand("select max(ID) from Payments", Database.Connection);

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

        private void frm_AddPayment_Load(object sender, EventArgs e)
        {
            ReturnLAstID();
            dtp_Date.Value = DateTime.Now;
            cmb_Type.SelectedIndex = -1;
            if (_Rental_ID != null)
            {
                txt_Rental_ID.Text = _Rental_ID.ToString();
                txt_Rental_ID_Leave(null,null);
            }
        }

        private void CheckValidation(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
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

        private bool IsHasPayment(int RentalID)
        {
            Database.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from Payments where Rental_ID=@Rental_ID AND Type = 'Rental' AND IsDelete = 0 ", Database.Connection);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Rental_ID", RentalID);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            Database.Close();
            return count > 0;
        }
        private void LoadRentalInfo(int RentalID)
        {
            if (IsHasPayment(RentalID)) {

                cmb_Type.SelectedItem = "Violations";

                Database.Open();
                SqlCommand cmd = new SqlCommand("Select Count(*) As NumOfViolation, Sum(Cost) As Total_Cost from Violations where Rental_ID=@ID AND IsDelete = 0 And Payment = 'Unpaid' ", Database.Connection);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID", RentalID);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txt_Total_Price.Text = dr["Total_Cost"].ToString();
                    txt_Discount.Text = dr["NumOfViolation"].ToString();
                    label13.Text = "Number of Violations";
                    
                    if (string.IsNullOrWhiteSpace(txt_Total_Price.Text))
                    {
                        MessageBox.Show("Renrtal Is Paid And It Has no Violations.");

                        cmb_Type.SelectedIndex = -1;
                        txt_Rental_ID.Clear();
                        txt_Discount.Clear();
                        txt_Total_Price.Clear();
                        label13.Text = "Discount";

                    }

                }
                else
                {
                    MessageBox.Show("Rental ID not found.");
                    txt_Rental_ID.Clear();
                    txt_Discount.Clear();
                    txt_Total_Price.Clear();
                }
                dr.Close();
                Database.Close();
                //MessageBox.Show("This rental already has a payment recorded.");
                //txt_Rental_ID.Clear();
                //return;
            }
            else
            {
                cmb_Type.SelectedItem = "Rental";
                Database.Open();
                SqlCommand cmd = new SqlCommand("select Cost, Discount from Rentals where ID=@ID AND IsDelete = 0 ", Database.Connection);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID", RentalID);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txt_Total_Price.Text = dr["Cost"].ToString();
                    txt_Discount.Text = dr["Discount"].ToString();
                    label13.Text = "Discount";
                }
                else
                {
                    MessageBox.Show("Rental ID not found.");
                    txt_Rental_ID.Clear();
                    txt_Discount.Clear();
                    txt_Total_Price.Clear();
                }
                dr.Close();
                Database.Close();
            }
            
            
                
        }
        private void UpdateViolationPayment()
        {
            SqlCommand cmd = new SqlCommand("Update Violations Set Payment = 'Paid' Where Rental_ID = @RentalID ;", Database.Connection);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@RentalID", Convert.ToInt32(txt_Rental_ID.Text));
            Database.Open();
            cmd.ExecuteNonQuery();
            Database.Close();

        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            CheackAllValidation();

            if (IsValid())
            {
                if (MessageBox.Show("Are you sure you want to add this Payment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var Parent = this.MdiParent as Main_Form;

                    SqlCommand cmd = new SqlCommand("Insert into Payments (Type, Payment_Method, Date, Total_Price, Rental_ID, User_ID) Values" +
                        "" +
                        " (@Type, @Payment_Method, @Date, @Total_Price, @Rental_ID, @User_ID)", Database.Connection);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Type", cmb_Type.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Payment_Method", cmb_Method.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(dtp_Date.Text));
                    cmd.Parameters.AddWithValue("@Total_Price", txt_Total_Price.Text);
                    cmd.Parameters.AddWithValue("@Rental_ID", Convert.ToInt32(txt_Rental_ID.Text));
                    cmd.Parameters.AddWithValue("@User_ID", Convert.ToInt32(Parent.UserID));

                    Database.Open();

                    if (Convert.ToInt32(cmd.ExecuteNonQuery()) > 0)
                    {
                        UpdateViolationPayment();
                        MessageBox.Show("Payment added successfully!");
                        Database.Close();
                        this.Close();


                    }
                    else
                    {
                        MessageBox.Show("Error Payment Not Added");
                    }
                    Database.Close();
                    //MessageBox.Show("Customer added successfully!");
                    //ClearAllFields();
                    //txt_Discount.Text = "%0";
                    //ReturnLAstID();
                }
                ClearAllFields();
                ReturnLAstID();
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

        private void txt_Rental_ID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Rental_ID.Text))
                return;
            LoadRentalInfo(Convert.ToInt32(txt_Rental_ID.Text));
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, helpProvider1.HelpNamespace, HelpNavigator.Topic, this.helpProvider1.GetHelpKeyword(this));

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
