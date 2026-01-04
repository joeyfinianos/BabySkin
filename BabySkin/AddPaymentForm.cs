using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BabySkin
{
    public partial class AddPaymentForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-CNQIILR\SQLEXPRESS;Initial Catalog=db_BabySkin;Integrated Security=True;TrustServerCertificate=True";

        public AddPaymentForm()
        {
            InitializeComponent();
        }

        private void AddPaymentForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            dtpPaymentDate.Value = DateTime.Now;
            nudAmount.Value = 100;
        }

        private void LoadCustomers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT CustomerID, FullName FROM Customers ORDER BY FullName";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cbCustomer.DisplayMember = "FullName";
                    cbCustomer.ValueMember = "CustomerID";
                    cbCustomer.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCustomer.SelectedValue != null)
            {
                LoadCustomerSessions(Convert.ToInt32(cbCustomer.SelectedValue));
            }
        }

        private void LoadCustomerSessions(int customerId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT SessionID, BodyArea + ' - ' + CONVERT(VARCHAR, SessionDate, 103) AS SessionInfo 
                                   FROM LaserSessions 
                                   WHERE CustomerID = @CustomerID 
                                   ORDER BY SessionDate DESC";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cbSession.DisplayMember = "SessionInfo";
                    cbSession.ValueMember = "SessionID";
                    cbSession.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sessions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbCustomer.SelectedValue == null)
            {
                MessageBox.Show("Please select a customer", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbSession.SelectedValue == null)
            {
                MessageBox.Show("Please select a session", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudAmount.Value <= 0)
            {
                MessageBox.Show("Please enter a valid amount", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"INSERT INTO Payments (CustomerID, SessionID, Amount, PaymentDate) 
                                   VALUES (@CustomerID, @SessionID, @Amount, @PaymentDate)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", cbCustomer.SelectedValue);
                        cmd.Parameters.AddWithValue("@SessionID", cbSession.SelectedValue);
                        cmd.Parameters.AddWithValue("@Amount", nudAmount.Value);
                        cmd.Parameters.AddWithValue("@PaymentDate", dtpPaymentDate.Value);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Payment saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to save payment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving payment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }
    }
}