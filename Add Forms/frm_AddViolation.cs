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
    public partial class frm_AddViolation : Form
    {
        int X;
        public frm_AddViolation()
        {
            InitializeComponent();
        }

        private void ReturnLAstID()
        {
            Database.Open();

            SqlCommand cmd = new SqlCommand("select max(ID) from Violations", Database.Connection);

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

        private void frm_AddViolation_Load(object sender, EventArgs e)
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
        private bool IsRental_ID_Exists(int RentalID)
        {
            Database.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from Rentals where ID=@Rental_ID AND End_Date < Getdate() AND IsDelete = 0 ", Database.Connection);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Rental_ID", RentalID);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            Database.Close();
            return count > 0;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            CheackAllValidation();

            if (IsValid())
            {
                if (MessageBox.Show("Are you sure you want to add this Violation?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("Insert into Violations (Violation, Cost, Rental_ID) Values (@Violation, @Cost, @Rental_ID)", Database.Connection);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Violation", txt_Violation.Text);
                    cmd.Parameters.AddWithValue("@Cost", txt_Cost.Text);
                    cmd.Parameters.AddWithValue("@Rental_ID", Convert.ToInt32(txt_Rental_ID.Text));
                    Database.Open();
                    if (Convert.ToInt32(cmd.ExecuteNonQuery()) > 0)
                    {
                        MessageBox.Show("Violation added successfully!");
                        Database.Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error Violation Not Added");
                    }
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

        private void txt_Rental_ID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Rental_ID.Text))
            {
                return;
            }
            if (!IsRental_ID_Exists(Convert.ToInt32(txt_Rental_ID.Text)))
            {
                MessageBox.Show("Rental ID not found.");
                txt_Rental_ID.Clear();
                return;
            }

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
