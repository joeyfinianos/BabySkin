using System;
using System.Data;
using System.Drawing;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace BabySkin
{
    public partial class SessionsForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-CNQIILR\SQLEXPRESS;Initial Catalog=db_BabySkin;Integrated Security=True;TrustServerCertificate=True";

        public SessionsForm()
        {
            InitializeComponent();
        }

        private void SessionsForm_Load(object sender, EventArgs e)
        {
            LoadAllSessions();
        }

        private void LoadAllSessions()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            ls.SessionID,
                            c.FullName AS Customer,
                            ls.BodyArea AS [Body Area],
                            ls.SessionDate AS Date,
                            ls.EnergyLevel AS [Energy Level],
                            ls.Duration
                        FROM LaserSessions ls
                        INNER JOIN Customers c ON ls.CustomerID = c.CustomerID
                        ORDER BY ls.SessionDate DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvAllSessions.DataSource = dt;

                    if (dgvAllSessions.Columns["SessionID"] != null)
                    {
                        dgvAllSessions.Columns["SessionID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sessions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddSession_Click(object sender, EventArgs e)
        {
            AddSessionForm addForm = new AddSessionForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadAllSessions();
            }
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
                            ls.SessionID,
                            c.FullName AS Customer,
                            ls.BodyArea AS [Body Area],
                            ls.SessionDate AS Date,
                            ls.EnergyLevel AS [Energy Level],
                            ls.Duration
                        FROM LaserSessions ls
                        INNER JOIN Customers c ON ls.CustomerID = c.CustomerID
                        WHERE c.FullName LIKE @Search OR ls.BodyArea LIKE @Search
                        ORDER BY ls.SessionDate DESC";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Search", "%" + searchText + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvAllSessions.DataSource = dt;

                    if (dgvAllSessions.Columns["SessionID"] != null)
                    {
                        dgvAllSessions.Columns["SessionID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchSessions_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchSessions.Text == "🔍 Search sessions..." || txtSearchSessions.ForeColor == Color.Gray)
                return;

            SearchSessions(txtSearchSessions.Text);
        }

        private void txtSearchSessions_Enter(object sender, EventArgs e)
        {
            if (txtSearchSessions.Text == "🔍 Search sessions...")
            {
                txtSearchSessions.Text = "";
                txtSearchSessions.ForeColor = Color.Black;
            }
        }

        private void txtSearchSessions_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchSessions.Text))
            {
                txtSearchSessions.Text = "🔍 Search sessions...";
                txtSearchSessions.ForeColor = Color.Gray;
                LoadAllSessions();
            }
        }

        // NAVIGATION BUTTONS

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
            // Already on Sessions page
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payments page coming soon!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtSearchSessions_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchSessions.Text) || txtSearchSessions.Text == "🔍 Search sessions...")
            {
                txtSearchSessions.Text = "";
                LoadAllSessions();
            }
            else
            {
                SearchSessions(txtSearchSessions.Text);
            }
        }
    }
}