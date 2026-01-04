using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace BabySkin
{
    public partial class DashboardForm : Form
    {
        private int currentUserId;
        private string currentUserName;
        private string connectionString = @"Data Source=DESKTOP-CNQIILR\SQLEXPRESS;Initial Catalog=db_BabySkin;Integrated Security=True;TrustServerCertificate=True";

        public DashboardForm(int userId, string fullName)
        {
            InitializeComponent();
            this.currentUserId = userId;
            this.currentUserName = fullName;
            this.Text = "BabySkin - Dashboard";
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            lbWelcome.Text = $"Welcome Back, {currentUserName}!";
            LoadUpcomingSessions();
            LoadStatistics();
        }

        private void LoadUpcomingSessions()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            c.FullName AS Name,
                            c.Phone,
                            ls.BodyArea AS [Body Area],
                            ls.EnergyLevel AS [Energy Level],
                            ls.SessionDate AS [Session Date]
                        FROM LaserSessions ls
                        INNER JOIN Customers c ON ls.CustomerID = c.CustomerID
                        WHERE ls.SessionDate >= CAST(GETDATE() AS DATE)
                        ORDER BY ls.SessionDate";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvUpcomingSessions.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sessions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStatistics()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Customers", conn);
                    tbTotalCustomers.Text = cmd.ExecuteScalar().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading statistics: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomersManagementForm customersForm = new CustomersManagementForm();
            customersForm.ShowDialog();
            this.Show();
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
            this.Hide();
            PaymentsForm paymentsForm = new PaymentsForm();
            paymentsForm.ShowDialog();
            this.Show();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            addCustomersForm addForm = new addCustomersForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadStatistics();
            }
        }

        private void btnRecordSession_Click(object sender, EventArgs e)
        {
            AddSessionForm addForm = new AddSessionForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadUpcomingSessions();
            }
        }

        private void btnViewPayments_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentsForm paymentsForm = new PaymentsForm();
            paymentsForm.ShowDialog();
            this.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "🔍 Search..." || txtSearch.ForeColor == Color.Gray)
            {
                return;
            }
            SearchSessions(txtSearch.Text);
        }

        private void SearchSessions(string searchText)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            c.FullName AS Name,
                            c.Phone,
                            ls.BodyArea AS [Body Area],
                            ls.EnergyLevel AS [Energy Level],
                            ls.SessionDate AS [Session Date]
                        FROM LaserSessions ls
                        INNER JOIN Customers c ON ls.CustomerID = c.CustomerID
                        WHERE ls.SessionDate >= CAST(GETDATE() AS DATE)
                        AND (c.FullName LIKE @Search 
                             OR c.Phone LIKE @Search 
                             OR ls.BodyArea LIKE @Search)
                        ORDER BY ls.SessionDate";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Search", "%" + searchText + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvUpcomingSessions.DataSource = dt;
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
                LoadUpcomingSessions();
            }
        }

        private void dgvUpcomingSessions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}