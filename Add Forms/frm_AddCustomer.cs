using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Car_Rental_System_New_Virsion
{
    public partial class frm_AddCustomer : Form
    {
        int X;
        public frm_AddCustomer()
        {
            InitializeComponent();
        }

        private void ReturnLAstID()
        {
            Database.Open();

            SqlCommand cmd = new SqlCommand("select max(ID) from Customers", Database.Connection);

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


        private void frm_AddCustomer_Load(object sender, EventArgs e)
        {
            ReturnLAstID();
            LoadCustomersType();
            LoadGuranteeType();
            cmb_Customer_type.SelectedIndex = -1;
            cmb_Guarranty.SelectedIndex = -1;
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
        private void CheckValidation(MaskedTextBox txt)
        {
            if (!txt.MaskFull && txt != mtxt_Phone2)
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
                else if (ctrl is MaskedTextBox)
                {
                    if (!string.IsNullOrWhiteSpace(errorProvider_Add.GetError((MaskedTextBox)ctrl)))
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

       
        private int InsertPerson(SqlTransaction trans)
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

            SqlCommand cmd = new SqlCommand("Insert Into Persons (First_Name, Last_Name, Gender, Birth_Day, Identifier_Type, Identifier, Phone_1, Phone_2, Address) values (@FirstName, @LastName, @Gender, @Birth_Day, @Identifier_Type, @Identifier, @Phone_1, @Phone_2, @Address); Select Cast(Scope_Identity() As int)", Database.Connection, trans);
            cmd.Parameters.AddWithValue("@FirstName", firstName);
            cmd.Parameters.AddWithValue("@LastName", lastName);
            cmd.Parameters.AddWithValue("@Gender", txt_Gender.Text);
            cmd.Parameters.AddWithValue("@Birth_Day", Bth);
            cmd.Parameters.AddWithValue("@Identifier_Type", cmb_Identifiy_Type.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Identifier", txt_Identifiy.Text);
            cmd.Parameters.AddWithValue("@Phone_1", mtxt_Phone1.Text);
            cmd.Parameters.AddWithValue("@Phone_2", Phone2);
            cmd.Parameters.AddWithValue("@Address", txt_Address.Text);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        private int InserCustomer(int PersonID, SqlTransaction trans)
        {



            SqlCommand cmd = new SqlCommand("insert into Customers (Driving_Lisence, Gurantee_ID, Customer_Type_ID, Person_ID) Values(@Driving_Lisence, @Gurantee_ID, @Customer_Type_ID, @Person_ID) ; Select Cast(Scope_Identity() As int)", Database.Connection, trans);
            cmd.Parameters.AddWithValue("@Driving_Lisence", txt_DrivingLicense.Text);
            cmd.Parameters.AddWithValue("@Gurantee_ID", Convert.ToInt32(cmb_Guarranty.SelectedValue));
            cmd.Parameters.AddWithValue("@Customer_Type_ID", Convert.ToInt32(cmb_Customer_type.SelectedValue));
            cmd.Parameters.AddWithValue("@Person_ID", PersonID);
            return Convert.ToInt32(cmd.ExecuteScalar());

        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            CheackAllValidation();

            if (IsValid())
            {
                Database.Open();
                SqlTransaction trans = Database.Connection.BeginTransaction();
                try
                {
                    int PersonID = InsertPerson(trans);
                    int CustomerID = InserCustomer(PersonID, trans);
                    trans.Commit();
                    MessageBox.Show("Customer added successfully!");
                    Database.Close();
                    this.Close();
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

        private void cmb_Customer_type_SelectedIndexChanged(object sender, EventArgs e)
        {

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
