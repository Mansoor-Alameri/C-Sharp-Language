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
    public partial class frm_NewLogin : Form
    {
        public frm_NewLogin()
        {
            InitializeComponent();
        }

        private void CheckValidating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                string message = (((TextBox)sender).Name == txt_Username.Name) ? "Username is required" : "Password is required";
                errorProvider1.SetError(((TextBox)sender), message);

            }
            else
                errorProvider1.SetError(((TextBox)sender), "");
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            CheckValidating(txt_Password, new CancelEventArgs());
            if (errorProvider1.GetError(txt_Username) == "" && errorProvider1.GetError(txt_Password) == "")
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Users WHERE Username=@username AND Password=@password", Database.Connection);
                sqlCommand.Parameters.AddWithValue("@username", txt_Username.Text);
                sqlCommand.Parameters.AddWithValue("@password", txt_Password.Text);

                Database.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    int UserID = Convert.ToInt32(reader["ID"]);
                    int EmpID = Convert.ToInt32(reader["EmpID"]);
                    reader.Close();
                    SqlCommand cmd = new SqlCommand("SELECT Job_Title FROM Employees WHERE ID = " + EmpID, Database.Connection);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    string Job_Title = reader["Job_Title"].ToString();
                    reader.Close();
                    Main_Form mainForm = new Main_Form();
                    mainForm.UserID = UserID;
                    mainForm.Job_Title = Job_Title;

                    //MessageBox.Show("Login successful!");

                    this.Hide();
                    mainForm.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
                reader.Close();
                Database.Close();
                // Perform login logic here

            }
            else
            {
                MessageBox.Show("Please fix the errors before logging in.");
            }
        }

        private void pb_Password_Click(object sender, EventArgs e)
        {
            if (pb_Password.Tag.ToString() == "eye")
            {
                pb_Password.Image = Properties.Resources.hideEye;
                pb_Password.Tag = "hideEye";
                txt_Password.PasswordChar = '\0';
            }
            else
            {
                pb_Password.Image = Properties.Resources.eye;
                pb_Password.Tag = "eye";
                txt_Password.PasswordChar = '•';
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
