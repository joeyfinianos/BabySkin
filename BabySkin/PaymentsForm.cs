using System;
using System.Data;
using System.Drawing;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace BabySkin
{
    public partial class PaymentsForm : Form
    {
        private int userId;
        private string fullName;

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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchPayments(string searchText)
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
                        WHERE c.FullName LIKE @Search OR ls.BodyArea LIKE @Search
                        ORDER BY p.PaymentDate DESC";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Search", "%" + searchText + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvAllPayments.DataSource = dt;

                    if (dgvAllPayments.Columns["PaymentID"] != null)
                    {
                        dgvAllPayments.Columns["PaymentID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtSearchPayments_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchPayments.Text == "🔍 Search payments..." || txtSearchPayments.ForeColor == Color.Gray)
                return;

            SearchPayments(txtSearchPayments.Text);
        }

        private void txtSearchPayments_Enter(object sender, EventArgs e)
        {
            if (txtSearchPayments.Text == "🔍 Search payments...")
            {
                txtSearchPayments.Text = "";
                txtSearchPayments.ForeColor = Color.Black;
            }
        }

        private void txtSearchPayments_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchPayments.Text))
            {
                txtSearchPayments.Text = "🔍 Search payments...";
                txtSearchPayments.ForeColor = Color.Gray;
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
            this.Hide();
            SessionsForm sessionsForm = new SessionsForm();
            sessionsForm.ShowDialog();
            this.Show();
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
                this.Close();
            }
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dashboard = new DashboardForm(this.userId, this.fullName);
            dashboard.ShowDialog();




        }

        private void btnCustomers_Click_1(object sender, EventArgs e)
        {
            this.Close();
            CustomersManagementForm customersForm = new CustomersManagementForm();
            customersForm.ShowDialog();
            this.Show();
        }

        private void btnPayments_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSessions_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SessionsForm sessions = new SessionsForm();
            sessions.ShowDialog();
        }

        private void btnAddPayment_Click_1(object sender, EventArgs e)
        {
            AddPaymentForm addForm = new AddPaymentForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadAllPayments();
            }
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Show();
        }
    }
}