using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace BabySkin
{
    public partial class CustomersManagementForm : Form
    {
        private String connectionString = @"Data Source=DESKTOP-CNQIILR\SQLEXPRESS;Initial Catalog=db_BabySkin;Integrated Security=True;TrustServerCertificate=True";




        public CustomersManagementForm()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomersManagementForm_Load(object sender, EventArgs e)
        {
            loadCustomers();

        }
        private void loadCustomers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT 
                                        CustomerID, 
                                        FullName AS Name, 
                                        Phone, 
                                        Gender, 
                                        SkinType AS [Skin Type] 
                                     FROM Customers 
                                     ORDER BY FullName";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvCustomers.DataSource = dt;

                    if (dgvCustomers.Columns["CustomerID"] != null)
                    {
                        dgvCustomers.Columns["CustomerID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "🔍 Search..." || txtSearch.ForeColor == System.Drawing.Color.Gray)
            {
                return;
            }
            SearchCustomers(txtSearch.Text);
        }



        private void SearchCustomers(string searchText)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT 
                                CustomerID, 
                                FullName AS Name, 
                                Phone, 
                                Gender, 
                                SkinType AS [Skin Type] 
                             FROM Customers 
                             WHERE FullName LIKE @Search OR Phone LIKE @Search 
                             ORDER BY FullName";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Search", "%" + searchText + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvCustomers.DataSource = dt;

                    if (dgvCustomers.Columns["CustomerID"] != null)
                    {
                        dgvCustomers.Columns["CustomerID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "🔍 Search...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "🔍 Search...";
                txtSearch.ForeColor = Color.Gray;
                loadCustomers();
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            addCustomersForm addForm = new addCustomersForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                loadCustomers();
            }
        }

        private void btnEditSelected_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to edit", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataGridViewRow selectedRow = dgvCustomers.SelectedRows[0];

                int customerId = Convert.ToInt32(selectedRow.Cells["CustomerID"].Value);
                string fullName = selectedRow.Cells["Name"].Value.ToString();
                string phone = selectedRow.Cells["Phone"].Value.ToString();
                string gender = selectedRow.Cells["Gender"].Value.ToString();
                string skinType = selectedRow.Cells["Skin Type"].Value.ToString();

                string notes = "";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Notes FROM Customers WHERE CustomerID = @CustomerID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        notes = result.ToString();
                    }
                }

                addCustomersForm editForm = new addCustomersForm(customerId, fullName, phone, gender, skinType, notes);

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    loadCustomers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to delete", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataGridViewRow selectedRow = dgvCustomers.SelectedRows[0];
                string customerName = selectedRow.Cells["Name"].Value.ToString();
                int customerId = Convert.ToInt32(selectedRow.Cells["CustomerID"].Value);

                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete customer '{customerName}'?\n\nThis will also delete all their sessions and payments!\n\nThis action cannot be undone!",
                    "Confirm Delete",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.OK)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@CustomerID", customerId);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Customer and all related data deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadCustomers();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
