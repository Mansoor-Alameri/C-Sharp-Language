using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarRentalSystem
{
    public partial class LoginForm : Form
    {
        SqlConnection conn = new SqlConnection("Server =LAPTOP-V8DN1E0P; Database = CarRentalSystem;Trusted_Connection = True;");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text.Trim() == "" || txt_Password.Text.Trim() == "")
            {
                MessageBox.Show(" يرجى ادخال اسم المستخدم وكلمة المرور ");
                return;
            }
            
            SqlCommand SelectSearchCommand = new SqlCommand();
            SelectSearchCommand.CommandText = "Select Employees.Employee_ID ,Employees.UserName, Employees.Role_ID, Roles.Role_Name from Employees join Roles on Employees.Role_ID =  Roles.Role_ID where ((Employees.UserName = @UserName) and (Employees.Password = @Password))";
            SelectSearchCommand.Connection = conn;
            SelectSearchCommand.Parameters.AddWithValue("UserName", Convert.ToString(txt_UserName.Text));
            SelectSearchCommand.Parameters.AddWithValue("Password", Convert.ToString(txt_Password.Text));
            SqlDataReader SelectReader;
            conn.Open();
            SelectReader = SelectSearchCommand.ExecuteReader();

            if (!SelectReader.Read())
            {
                MessageBox.Show("! اسم المستخدم او كلمة المرور غير صحيح ", "الحساب غير موجود", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                conn.Close();
            } 
            else
            {
                Session.Employee_ID = Convert.ToInt32( SelectReader["Employee_ID"]);
                Session.UserName = SelectReader["UserName"].ToString();
                Session.Role_ID = Convert.ToInt32(SelectReader["Role_ID"].ToString());
                Session.Role_Name = SelectReader["Role_Name"].ToString();
                SelectReader.Close();


                Session.Permissions.Clear();
                SelectSearchCommand.CommandText = "Select Permissions.Permission_Name from RolePermissions join Permissions on RolePermissions.Permission_ID = Permissions.Permission_ID  where RolePermissions.Role_ID = @Role_ID";
                SelectSearchCommand.Connection = conn;
                SelectSearchCommand.Parameters.AddWithValue("Role_ID", Session.Role_ID);
                
                SqlDataReader Reader;
                Reader = SelectSearchCommand.ExecuteReader();

                while(Reader.Read())
                {
                    Session.Permissions.Add(Reader["Permission_Name"].ToString());
                }
                Reader.Close();

                MainForm Main = new MainForm();
                Main.Show();
                this.Hide();

                MessageBox.Show(" مرحبا بك " + Session.Role_Name + " " + Session.UserName, "تم تسجيل الدخول بنجاح", MessageBoxButtons.OK,
                MessageBoxIcon.None);

            }
        }
    }
}
