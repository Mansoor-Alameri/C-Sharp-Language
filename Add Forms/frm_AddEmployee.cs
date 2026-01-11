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
    public partial class frm_AddEmployee : Form
    {
        int X;
        public frm_AddEmployee()
        {
            InitializeComponent();
            
        }

        private void ReturnLAstID()
        {
            Database.Open();

            SqlCommand cmd = new SqlCommand("select max(ID) from Employees", Database.Connection);

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

        private void frm_AddEmployee_Load(object sender, EventArgs e)
        {
            ReturnLAstID();
            //cmb_Job_Title.SelectedItem = "Employee";
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

        private int InserEmployee(int PersonID, SqlTransaction trans)
        {
            DateTime Emph = Convert.ToDateTime(mtxt_Employment_history.Text).Date;


            SqlCommand cmd = new SqlCommand("insert into Employees (Job_Title, Academic_qualification, Employment_history, Salary, Person_ID) Values(@Job_Title, @Academic_qualification, @Employment_history, @Salary, @Person_ID) ; Select Cast(Scope_Identity() As int)", Database.Connection, trans);
            cmd.Parameters.AddWithValue("@Job_Title", cmb_Job_Title.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Academic_qualification", " ");
            cmd.Parameters.AddWithValue("@Employment_history", Emph);
            cmd.Parameters.AddWithValue("@Salary", txt_Salary.Text);
            cmd.Parameters.AddWithValue("@Person_ID", PersonID);
            return Convert.ToInt32(cmd.ExecuteScalar());

        }

        private int InserUser(int EmpID, SqlTransaction trans)
        {



            SqlCommand cmd = new SqlCommand("insert into Users (Username, Password, EmpID) Values(@Username, @Password, @EmpID) ; Select Cast(Scope_Identity() As int)", Database.Connection, trans);
            cmd.Parameters.AddWithValue("@Username", txt_Username.Text);
            cmd.Parameters.AddWithValue("@Password", txt_Password.Text);
            cmd.Parameters.AddWithValue("@EmpID", EmpID);
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
                    int EmployeeID = InserEmployee(PersonID, trans);
                    int UserID = InserUser(EmployeeID, trans);
                    trans.Commit();
                    MessageBox.Show("Employee added successfully!");
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

        private void btn_Help_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, helpProvider1.HelpNamespace, HelpNavigator.Topic, this.helpProvider1.GetHelpKeyword(this));

        }
    }
}
