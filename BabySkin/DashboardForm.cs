using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

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
                        ORDER BY ls.SessionDate
                    ";

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
                    lbTotalCustomers.Text = cmd.ExecuteScalar().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading statistics: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUpcomingSessions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}