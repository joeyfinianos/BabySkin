using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
namespace BabySkin
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-CNQIILR\SQLEXPRESS;Initial Catalog=db_BabySkin;Integrated Security=True;TrustServerCertificate=True";
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter username", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT UserID, FullName FROM Userss WHERE Username = @Username AND Password = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int userId = Convert.ToInt32(reader["UserID"]);
                            string fullName = reader["FullName"].ToString();

                            reader.Close();
                            conn.Close();

                            this.Hide();

                            DashboardForm dashboard = new DashboardForm(userId, fullName);
                            dashboard.ShowDialog();

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPassword.Clear();
                            txtUsername.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}