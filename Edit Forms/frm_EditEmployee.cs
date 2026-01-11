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
    public partial class frm_EditEmployee : Form
    {
        private clsEmployees _Employee;

        public frm_EditEmployee(clsEmployees Employee)
        {
            InitializeComponent();
            _Employee = Employee;
        }

        private void LoadInfoToForm()
        {
            if (_Employee != null)
            {
                txt_ID.Text = _Employee.ID;
                txt_Name.Text = _Employee.Name;
                cmb_Job_Title.SelectedItem = _Employee.Job_Title;
                txt_Gender.Text = _Employee.Gender;
                mtxt_Phone1.Text = _Employee.Phone1;
                mtxt_Phone2.Text = _Employee.Phone2;
                txt_Salary.Text = _Employee.Salary;
                mtxt_Employment_history.Text = _Employee.Employment_history;
                cmb_Identifiy_Type.SelectedItem = _Employee.Identifiy_Type;
                txt_Identifiy.Text = _Employee.Identifiy;
                txt_Address.Text = _Employee.Address;
                txt_Username.Text = _Employee.Username;
                txt_Password.Text = _Employee.Password;
                mtxt_DateOfBirth.Text = _Employee.Birthday;

            }
            else
                MessageBox.Show("Employee Not Found");
        }
        private void frm_EditEmployee_Load(object sender, EventArgs e)
        {
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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
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
            cmd.Parameters.AddWithValue("@ID", _Employee.PersonID);
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

        private int UpdateEmployee(SqlTransaction trans)
        {
            DateTime Emph = Convert.ToDateTime(mtxt_Employment_history.Text).Date;

            SqlCommand cmd = new SqlCommand("Update Employees Set Job_Title = @Job_Title, Academic_qualification = @Academic_qualification, Employment_history = @Employment_history, Salary = @Salary Where ID = @ID;", Database.Connection, trans);
            cmd.Parameters.AddWithValue("@Job_Title", cmb_Job_Title.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Academic_qualification", txt_Academic_qualification.Text);
            cmd.Parameters.AddWithValue("@Employment_history", Emph);
            cmd.Parameters.AddWithValue("@Salary", txt_Salary.Text);
            cmd.Parameters.AddWithValue("@ID", _Employee.ID);

            return Convert.ToInt32(cmd.ExecuteNonQuery());

        }

        private int UpdateUser(SqlTransaction trans)
        {

            SqlCommand cmd = new SqlCommand("Update Users Set Username = @Username, Password = @Password Where ID = @UserID", Database.Connection, trans);
            cmd.Parameters.AddWithValue("@Username", txt_Username.Text);
            cmd.Parameters.AddWithValue("@Password", txt_Password.Text);
            cmd.Parameters.AddWithValue("@UserID", _Employee.UserID);
            return Convert.ToInt32(cmd.ExecuteNonQuery());

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            CheackAllValidation();

            if (IsValid())
            {
                if (MessageBox.Show("Are you sure you want to Updated this Employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Database.Open();
                    SqlTransaction trans = Database.Connection.BeginTransaction();
                    try
                    {
                        int PersonID = UpdatePerson(trans);
                        int EmployeeID = UpdateEmployee(trans);
                        int UserID = UpdateUser(trans);

                        trans.Commit();
                        MessageBox.Show("Employee Updated successfully!");
                        if (_Employee.Job_Title != cmb_Job_Title.SelectedItem.ToString())
                        {
                            var Parent = this.MdiParent as Main_Form;
                            Parent.Job_Title = cmb_Job_Title.SelectedItem.ToString();
                            //MessageBox.Show("Please restart the application to apply the changes in job title.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, helpProvider1.HelpNamespace, HelpNavigator.Topic, this.helpProvider1.GetHelpKeyword(this));

        }
    }
}
