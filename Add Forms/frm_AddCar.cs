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
    public partial class frm_AddCar : Form
    {
        int X;
        public frm_AddCar()
        {
            InitializeComponent();
        }

        private void ReturnLAstID()
        {
            Database.Open();

            SqlCommand cmd = new SqlCommand("select max(ID) from Cars", Database.Connection);

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

        private void frm_AddCar_Load(object sender, EventArgs e)
        {
            ReturnLAstID();
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
                
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            CheackAllValidation();

            if (IsValid())
            {
                if (MessageBox.Show("Are you sure you want to Updated this Car?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("Insert into Cars (Name, Brand, Model, Color, Year_of_Manufacture, Fuel_Type, Gear_Type, Price, Price_Per_Day) Values (@Name, @Brand, @Model, @Color, @Year_of_Manufacture, @Fuel_Type, @Gear_Type, @Price, @Price_Per_Day)", Database.Connection);
                    cmd.Parameters.AddWithValue("@Name", txt_Category.Text);
                    cmd.Parameters.AddWithValue("@Model", txt_Model.Text);
                    cmd.Parameters.AddWithValue("@Brand", txt_Brand.Text);
                    cmd.Parameters.AddWithValue("@Color", txt_Color.Text);
                    cmd.Parameters.AddWithValue("@Year_of_Manufacture", txt_Year.Text);
                    cmd.Parameters.AddWithValue("@Fuel_Type", cmb_Fuel.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Gear_Type", cmb_Gear.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Price", txt_Price.Text);
                    cmd.Parameters.AddWithValue("@Price_Per_Day", txt_Price_Per_Day.Text);

                    Database.Open();

                    if (Convert.ToInt32(cmd.ExecuteNonQuery()) > 0)
                    {

                        MessageBox.Show("Car added successfully!");

                        ClearAllFields();
                        ReturnLAstID();
                        Database.Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error Car Not Added");
                    }
                    Database.Close();
                }
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

        private void frm_AddCar_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, helpProvider1.HelpNamespace, HelpNavigator.Topic, this.helpProvider1.GetHelpKeyword(this));

        }
    }
}
