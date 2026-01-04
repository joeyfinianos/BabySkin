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
    }
}