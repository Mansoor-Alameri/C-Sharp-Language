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
    public partial class frm_EditCustomer : Form
    {
        private clsCustomers _Customer;
        public frm_EditCustomer(clsCustomers Customer)
        {
            InitializeComponent();
            _Customer = Customer;
        }

        private void LoadInfoToForm()
        {
            if (_Customer != null)
            {
                txt_ID.Text = _Customer.ID;
                txt_Name.Text = _Customer.Name;
                txt_DrivingLicense.Text = _Customer.Driving_License;
                txt_Gender.Text = _Customer.Gender;
                mtxt_Phone1.Text = _Customer.Phone1;
                mtxt_Phone2.Text = _Customer.Phone2;
                cmb_Customer_type.SelectedValue = _Customer.Customer_Type;
                cmb_Guarranty.SelectedValue = _Customer.Guarranty_Type;
                cmb_Identifiy_Type.SelectedItem = _Customer.Identifiy_Type;
                txt_Identifiy.Text = _Customer.Identifiy;
                txt_Address.Text = _Customer.Address;
                mtxt_DateOfBirth.Text = _Customer.Birthday;

            }
            else
                MessageBox.Show("Customer Not Found");
        }
        private void LoadCustomersType()
        {
            string query = "SELECT * FROM Customers_Type ";
            Database.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, Database.Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Database.Close();

            cmb_Customer_type.DataSource = dt;
            cmb_Customer_type.DisplayMember = "Type";
            cmb_Customer_type.ValueMember = "ID";
        }
        private void LoadGuranteeType()
        {
            string query = "SELECT * FROM Gurantees_Type ";
            Database.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, Database.Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Database.Close();
            cmb_Guarranty.DataSource = dt;
            cmb_Guarranty.DisplayMember = "Gurantee";
            cmb_Guarranty.ValueMember = "ID";
        }
        private void frm_EditCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomersType();
            LoadGuranteeType();
            IsCanReleseGarruntee();
            //cmb_Customer_type.SelectedIndex = -1;
            //cmb_Guarranty.SelectedIndex = -1;

            LoadInfoToForm();
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
        private void CheckValidation(MaskedTextBox txt)
        {
            if (!txt.MaskFull && txt != mtxt_Phone2)
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
                else if (ctrl is MaskedTextBox)
                {
                    CheckValidation((MaskedTextBox)ctrl);
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
                else if (ctrl is MaskedTextBox)
                {
                    if (!string.IsNullOrWhiteSpace(errorProvider_Edit.GetError((MaskedTextBox)ctrl)))
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
                else if (ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)ctrl).Clear();
                }
            }
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {

            frm_DetailsCustomer_Rentals frm = new frm_DetailsCustomer_Rentals(_Customer.ID, _Customer.Name);
            var Parent = this.MdiParent as Main_Form;
            Parent.DisplayformWithCons(frm);
        }

        private int UpdatePerson(SqlTransaction trans)
        {
            string fullName = txt_Name.Text.Trim();
            string firstName;
            string lastName;
            int index = fullName.IndexOf(' ');
            if (index != -1)
            {
                firstName = fullName.Substring(0, index);
                lastName = fullName.Substring(index + 1);
            }
            else
            {
                firstName = fullName;
                lastName = "";
            }

            string Phone2;

            if (!mtxt_Phone2.MaskFull)
            {
                Phone2 = " ";
            }
            else
            {
                Phone2 = mtxt_Phone2.Text;
            }
            string Date = mtxt_DateOfBirth.Text;
            DateTime Bth = Convert.ToDateTime(mtxt_DateOfBirth.Text).Date;

            SqlCommand cmd = new SqlCommand("Update Persons Set First_Name=@FirstName, Last_Name = @LastName, Gender = @Gender, Birth_Day = @Birth_Day, Identifier_Type = @Identifier_Type, Identifier = @Identifier, Phone_1 = @Phone_1, Phone_2 = @Phone_2, Address = @Address WHERE ID=@ID;", Database.Connection, trans);
            cmd.Parameters.AddWithValue("@ID", _Customer.PersonID);
            cmd.Parameters.AddWithValue("@FirstName", firstName);
            cmd.Parameters.AddWithValue("@LastName", lastName);
            cmd.Parameters.AddWithValue("@Gender", txt_Gender.Text);
            cmd.Parameters.AddWithValue("@Birth_Day", Bth);
            cmd.Parameters.AddWithValue("@Identifier_Type", cmb_Identifiy_Type.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Identifier", txt_Identifiy.Text);
            cmd.Parameters.AddWithValue("@Phone_1", mtxt_Phone1.Text);
            cmd.Parameters.AddWithValue("@Phone_2", Phone2);
            cmd.Parameters.AddWithValue("@Address", txt_Address.Text);

            return Convert.ToInt32(cmd.ExecuteNonQuery());
        }

        private void IsCanReleseGarruntee()
        {
            string query = "SELECT COUNT(*) FROM Rentals WHERE Customer_ID = @Customer_ID AND (State = 'Not Release' And IsDelete = 0)";
            string query2 = "Select Count(*) From Rentals R join Violations V On R.ID = V.Rental_ID Where R.Customer_ID = @Customer_ID And V.Payment = 'Unpaid' And R.IsDelete = 0 And V.IsDelete = 0;";
            Database.Open();
            SqlCommand cmd = new SqlCommand(query, Database.Connection);
            SqlCommand cmd2 = new SqlCommand(query2, Database.Connection);
            cmd.Parameters.AddWithValue("@Customer_ID", Convert.ToInt32(_Customer.ID));
            cmd2.Parameters.AddWithValue("@Customer_ID", Convert.ToInt32(_Customer.ID));
            int count = (int)cmd.ExecuteScalar();
            count += (int)cmd2.ExecuteScalar();
            Database.Close();
            if (count > 0)
            {
                cmb_Guarranty.Enabled = false;
            }
        }
        private int UpdateCustomer( SqlTransaction trans)
        {

            SqlCommand cmd = new SqlCommand("Update Customers Set Driving_Lisence = @Driving_Lisence, Gurantee_ID = @Gurantee_ID, Customer_Type_ID = @Customer_Type_ID Where ID=@ID;", Database.Connection, trans);
            cmd.Parameters.AddWithValue("@Driving_Lisence", txt_DrivingLicense.Text);
            cmd.Parameters.AddWithValue("@Gurantee_ID", Convert.ToInt32(cmb_Guarranty.SelectedValue));
            cmd.Parameters.AddWithValue("@Customer_Type_ID", Convert.ToInt32(cmb_Customer_type.SelectedValue));
            cmd.Parameters.AddWithValue("@ID", _Customer.ID);
            return Convert.ToInt32(cmd.ExecuteNonQuery());

        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            CheackAllValidation();

            if (IsValid())
            {
                if (MessageBox.Show("Are you sure you want to Updated this Customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Database.Open();
                    SqlTransaction trans = Database.Connection.BeginTransaction();
                    try
                    {
                        int PersonID = UpdatePerson(trans);
                        int CustomerID = UpdateCustomer(trans);
                        trans.Commit();
                        MessageBox.Show("Customer Updated successfully!");

                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("Error : " + ex.Message);
                    }
                    finally
                    {
                        Database.Close();
                    }
                    //ClearAllFields();
                }
                
            }
            else
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete Customer ' " + txt_Name.Text + " ' With ID = " + txt_ID.Text + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (cmb_Guarranty.Enabled == false)
                {
                    MessageBox.Show("Cannot delete this customer because they have active rentals or unpaid violations.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Database.Open();
                SqlCommand cmd = new SqlCommand("BEGIN TRANSACTION; Update Persons Set IsDelete = 1 Where ID = @PersonID; Update Customers Set IsDelete = 1 Where ID = @CustomerID; COMMIT TRANSACTION;", Database.Connection);
                cmd.Parameters.AddWithValue("@PersonID", _Customer.PersonID);
                cmd.Parameters.AddWithValue("@CustomerID", _Customer.ID);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Customer Deleted successfully!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Customer Not Deleted");
                }

                Database.Close();

            }

        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, helpProvider1.HelpNamespace, HelpNavigator.Topic, this.helpProvider1.GetHelpKeyword(this));

        }
    }
}
