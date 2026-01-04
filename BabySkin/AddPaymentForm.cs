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
            LoadBodyAreas();
            SetDefaultValues();
        }

        private void SetDefaultValues()
        {
            dtpPaymentDate.Value = DateTime.Now;
            nudAmount.Value = 100;
            nudAmount.DecimalPlaces = 2;
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

        private void LoadBodyAreas()
        {
            cbSession.Items.Clear();
            cbSession.Items.AddRange(new string[] {
                "Face",
                "Legs",
                "Arms",
                "Back",
                "Chest",
                "Underarms",
                
                "Full Body",
                "Hands",
                "Feet",
                "Neck",
                "Shoulders"
            });

            if (cbSession.Items.Count > 0)
                cbSession.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbCustomer.SelectedValue == null)
            {
                MessageBox.Show("Please select a customer", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbCustomer.Focus();
                return;
            }

            if (cbSession.SelectedItem == null)
            {
                MessageBox.Show("Please select a body area", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbSession.Focus();
                return;
            }

            if (nudAmount.Value <= 0)
            {
                MessageBox.Show("Please enter a valid amount greater than 0", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudAmount.Focus();
                return;
            }

            try
            {
                int customerId = Convert.ToInt32(cbCustomer.SelectedValue);
                string bodyArea = cbSession.SelectedItem.ToString();
                decimal amount = nudAmount.Value;
                DateTime paymentDate = dtpPaymentDate.Value;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Find an existing session for this customer and body area
                    string findSessionQuery = @"SELECT TOP 1 SessionID 
                                       FROM LaserSessions 
                                       WHERE CustomerID = @CustomerID AND BodyArea = @BodyArea 
                                       ORDER BY SessionDate DESC";

                    int sessionId = 0;

                    using (SqlCommand cmd = new SqlCommand(findSessionQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);
                        cmd.Parameters.AddWithValue("@BodyArea", bodyArea);

                        object result = cmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show($"No session found for this customer and body area ({bodyArea}).\n\nPlease create a session first before adding a payment.", "No Session Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        sessionId = Convert.ToInt32(result);
                    }

                    // Now insert the payment
                    string insertPaymentQuery = @"INSERT INTO Payments (CustomerID, SessionID, Amount, PaymentDate) 
                                         VALUES (@CustomerID, @SessionID, @Amount, @PaymentDate)";

                    using (SqlCommand cmd = new SqlCommand(insertPaymentQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);
                        cmd.Parameters.AddWithValue("@SessionID", sessionId);
                        cmd.Parameters.AddWithValue("@Amount", amount);
                        cmd.Parameters.AddWithValue("@PaymentDate", paymentDate);

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
                MessageBox.Show("Error saving payment: " + ex.Message + "\n\n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cbSession_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}