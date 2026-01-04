using System;
using System.Data;
using System.Drawing;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace BabySkin
{
    public partial class PaymentsForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-CNQIILR\SQLEXPRESS;Initial Catalog=db_BabySkin;Integrated Security=True;TrustServerCertificate=True";

        public PaymentsForm()
        {
            InitializeComponent();
        }

        private void PaymentsForm_Load(object sender, EventArgs e)
        {
            LoadAllPayments();
        }

        private void LoadAllPayments()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            p.PaymentID,
                            c.FullName AS Customer,
                            ls.BodyArea AS [Body Area],
                            p.Amount,
                            p.PaymentDate AS [Payment Date]
                        FROM Payments p
                        INNER JOIN Customers c ON p.CustomerID = c.CustomerID
                        INNER JOIN LaserSessions ls ON p.SessionID = ls.SessionID
                        ORDER BY p.PaymentDate DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvAllPayments.DataSource = dt;

                    if (dgvAllPayments.Columns["PaymentID"] != null)
                    {
                        dgvAllPayments.Columns["PaymentID"].Visible = false;
                    }

                    CalculateTotalAmount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateTotalAmount()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvAllPayments.Rows)
            {
                if (row.Cells["Amount"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["Amount"].Value);
                }
            }

            // Display total in a label
            if (this.Controls.Find("lblTotalAmount", true).Length > 0)
            {
                Label lblTotal = (Label)this.Controls.Find("lblTotalAmount", true)[0];
                lblTotal.Text = $"Total: ${total:N2}";
            }
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            AddPaymentForm addForm = new AddPaymentForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadAllPayments();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomersManagementForm customersForm = new CustomersManagementForm();
            customersForm.ShowDialog();
        }

        private void btnSessions_Click(object sender, EventArgs e)
        {
            this.Close();
            SessionsForm sessionsForm = new SessionsForm();
            sessionsForm.ShowDialog();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            // Already on Payments page
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDeletePayment_Click(object sender, EventArgs e)
        {
            if (dgvAllPayments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a payment to delete", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataGridViewRow selectedRow = dgvAllPayments.SelectedRows[0];

                int paymentId = Convert.ToInt32(selectedRow.Cells["PaymentID"].Value);
                string customerName = selectedRow.Cells["Customer"].Value.ToString();
                string bodyArea = selectedRow.Cells["Body Area"].Value.ToString();
                decimal amount = Convert.ToDecimal(selectedRow.Cells["Amount"].Value);

                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete this payment?\n\n" +
                    $"Customer: {customerName}\n" +
                    $"Body Area: {bodyArea}\n" +
                    $"Amount: ${amount:N2}\n\n" +
                    $"This action cannot be undone!",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Payments WHERE PaymentID = @PaymentID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@PaymentID", paymentId);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Payment deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadAllPayments();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete payment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting payment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}