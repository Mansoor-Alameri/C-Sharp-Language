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
    public partial class frm_EditCar : Form
    {
        private string _Car_ID;
        private string _Car_Name;
        public frm_EditCar(string Car_ID)
        {
            InitializeComponent();
            _Car_ID = Car_ID;
        }

        private void LoadCarInfo()
        {
            SqlCommand cmd = new SqlCommand("Select * From Cars Where ID = " + _Car_ID +" ", Database.Connection);
            cmd.Parameters.Clear();

            Database.Open();
            SqlDataReader da = cmd.ExecuteReader();
            if (da.Read())
            {
                txt_ID.Text = _Car_ID;
                txt_Brand.Text = da["Brand"].ToString();
                txt_Model.Text = da["Model"].ToString();
                txt_Category.Text = da["Name"].ToString();
                txt_Color.Text = da["Color"].ToString();
                txt_Year.Text = da["Year_of_Manufacture"].ToString();
                txt_Price_Per_Day.Text = da["Price_Per_Day"].ToString();
                txt_Price.Text = da["Price"].ToString();
                cmb_Fuel.Text = da["Fuel_Type"].ToString();
                cmb_Gear.Text = da["Gear_Type"].ToString();

                _Car_Name = da["Name"].ToString() + ", " + da["Model"].ToString() + ", " + da["Brand"].ToString();
            }
            else
            {
                MessageBox.Show("Error!!!");
            }
            Database.Close();
        }
        private void frm_EditCar_Load(object sender, EventArgs e)
        {
            LoadCarInfo();
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
        
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {

            frm_DetailsCar_Rentals frm = new frm_DetailsCar_Rentals(_Car_ID, _Car_Name);
            var Parent = this.MdiParent as Main_Form;
            Parent.DisplayformWithCons(frm);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            CheackAllValidation();

            if (IsValid())
            {
                if (MessageBox.Show("Are you sure you want to Add this Car?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("Update Cars Set Name = @Name, Brand = @Brand, Model = @Model, Color = @Color, Year_of_Manufacture = @Year_of_Manufacture, Fuel_Type = @Fuel_Type, Gear_Type = @Gear_Type, Price = @Price, Price_Per_Day = @Price_Per_Day Where ID = @ID;", Database.Connection);
                    cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txt_ID.Text));
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

                        MessageBox.Show("Car Updated successfully!");

                        //ClearAllFields();


                    }
                    else
                    {
                        MessageBox.Show("Error Car Not Updated");
                    }
                    Database.Close();
                }
            }
            else
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Color_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void label1_Click(object sender, EventArgs e)
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
