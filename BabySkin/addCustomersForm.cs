using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BabySkin
{
    public partial class addCustomersForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-CNQIILR\SQLEXPRESS;Initial Catalog=db_BabySkin;Integrated Security=True;TrustServerCertificate=True";

        public addCustomersForm()
        {
            InitializeComponent();
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            cbGender.Items.AddRange(new string[] { "Male", "Female", "Other" });
            cbGender.SelectedIndex = 0;

            cbSkinType.Items.AddRange(new string[] { "Fair", "Medium", "Dark", "Sensitive", "Oily", "Dry", "Combination" });
            cbSkinType.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please enter customer name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please enter phone number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"INSERT INTO Customers (FullName, Phone, Gender, SkinType, Notes) 
                                   VALUES (@FullName, @Phone, @Gender, @SkinType, @Notes)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@Gender", cbGender.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@SkinType", cbSkinType.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Notes", txtNotes.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving customer: " + ex.Message + "\n\n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}