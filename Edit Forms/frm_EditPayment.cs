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
    public partial class frm_EditPayment : Form
    {
        private clsPayments _Payment;
        public frm_EditPayment(clsPayments Payment)
        {
            InitializeComponent();
            _Payment = Payment;
        }

        private void LoadInfoToForm()
        {
            if (_Payment != null)
            {
                txt_ID.Text = _Payment.ID;
                txt_Rental_ID.Text = _Payment.Rental_ID;
                cmb_Type.SelectedItem = _Payment.Payment_Type;
                cmb_Method.SelectedItem = _Payment.Method;
                dtp_Date.Text = _Payment.Date;
                
                txt_Discount.Text = _Payment.Discount;
                
                txt_Total_Price.Text = _Payment.TotalPrice;
                
            }
            else
                MessageBox.Show("Payment Not Found");
        }


        private void frm_EditPayment_Load(object sender, EventArgs e)
        {
            LoadInfoToForm();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool IsRentalRelease(string Rental_ID)
        {
            SqlCommand cmd = new SqlCommand("Select * From Rentals Where ID = @ID And State = 'Release';", Database.Connection);
            cmd.Parameters.AddWithValue("@ID", Rental_ID);
            Database.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                rdr.Close();
                Database.Close();
                return true;
            }
            else
            {
                rdr.Close();
                Database.Close();
                return false;
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete this Payment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (cmb_Type.SelectedItem.ToString() == "Rental" && IsRentalRelease(_Payment.Rental_ID))
                {
                    MessageBox.Show("You Can't Delete This Payment Becuase The Rental Has Been Released.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                SqlCommand sqlCommand = new SqlCommand("Update Payments Set IsDelete = 1 Where ID = @ID", Database.Connection);
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.AddWithValue("@ID", Convert.ToInt32(_Payment.ID));
                Database.Open();
                if (Convert.ToInt32(sqlCommand.ExecuteNonQuery()) > 0)
                {
                    if (cmb_Type.SelectedItem.ToString() == "Violations")
                    {
                        SqlCommand cmd = new SqlCommand("Update Violations Set Payment = 'Unpaid' Where Rental_ID = @Rental_ID", Database.Connection);
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@Rental_ID", Convert.ToInt32(_Payment.Rental_ID));
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Payment Deleted successfully!");
                    Database.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Payment Not Deleted");
                }
                Database.Close();
            }

        }
        private void CheckValidation(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
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
        private void btn_Save_Click(object sender, EventArgs e)
        {
            CheackAllValidation();

            if (IsValid())
            {
                if (MessageBox.Show("Are you sure you want to Update this Payment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var Parent = this.MdiParent as Main_Form;

                    SqlCommand cmd = new SqlCommand("Update Payments Set Payment_Method = @Payment_Method, Date = @Date Where ID = @ID" , Database.Connection);
                    cmd.Parameters.Clear();
                    //cmd.Parameters.AddWithValue("@Type", cmb_Type.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Payment_Method", cmb_Method.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(dtp_Date.Text));
                    cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(_Payment.ID));

                    Database.Open();

                    if (Convert.ToInt32(cmd.ExecuteNonQuery()) > 0)
                    {

                        MessageBox.Show("Payment Updated successfully!");



                    }
                    else
                    {
                        MessageBox.Show("Error Payment Not Updated");
                    }
                    Database.Close();
                    //MessageBox.Show("Customer added successfully!");
                    //ClearAllFields();
                    //txt_Discount.Text = "%0";
                    //ReturnLAstID();
                }
                
            }
            else
            {
                MessageBox.Show("Please correct the errors before saving.");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, helpProvider1.HelpNamespace, HelpNavigator.Topic, this.helpProvider1.GetHelpKeyword(this));

        }
    }
}
