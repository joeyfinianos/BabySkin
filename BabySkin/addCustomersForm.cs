using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BabySkin
{
    public partial class addCustomersForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-CNQIILR\SQLEXPRESS;Initial Catalog=db_BabySkin;Integrated Security=True;TrustServerCertificate=True";
        private int? customerId = null;
        private bool isEditMode = false;

        public addCustomersForm()
        {
            InitializeComponent();
            LoadComboBoxes();
            this.Text = "Add New Customer";
        }

        public addCustomersForm(int customerId, string fullName, string phone, string gender, string skinType, string notes)
        {
            InitializeComponent();
            LoadComboBoxes();

            this.customerId = customerId;
            this.isEditMode = true;
            this.Text = "Edit Customer";

            txtFullName.Text = fullName;
            txtPhone.Text = phone;
            cbGender.SelectedItem = gender;
            cbSkinType.SelectedItem = skinType;
            txtNotes.Text = notes;

            btnSave.Text = "💾 Update Customer";
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
                    string query;

                    if (isEditMode)
                    {
                        query = @"UPDATE Customers 
                                SET FullName = @FullName, 
                                    Phone = @Phone, 
                                    Gender = @Gender, 
                                    SkinType = @SkinType, 
                                    Notes = @Notes 
                                WHERE CustomerID = @CustomerID";
                    }
                    else
                    {
                        query = @"INSERT INTO Customers (FullName, Phone, Gender, SkinType, Notes) 
                                VALUES (@FullName, @Phone, @Gender, @SkinType, @Notes)";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@Gender", cbGender.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@SkinType", cbSkinType.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Notes", txtNotes.Text.Trim());

                        if (isEditMode)
                        {
                            cmd.Parameters.AddWithValue("@CustomerID", customerId);
                        }

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            string message = isEditMode ? "Customer updated successfully!" : "Customer added successfully!";
                            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to save customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}