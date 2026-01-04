using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BabySkin
{
    public partial class AddSessionForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-CNQIILR\SQLEXPRESS;Initial Catalog=db_BabySkin;Integrated Security=True;TrustServerCertificate=True";

        public AddSessionForm()
        {
            InitializeComponent();
        }

        private void AddSessionForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadBodyAreas();
            SetDefaultValues();
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
            cbBodyArea.Items.Clear();
            cbBodyArea.Items.AddRange(new string[] {
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

            if (cbBodyArea.Items.Count > 0)
                cbBodyArea.SelectedIndex = 0;
        }

        private void SetDefaultValues()
        {

            dtpSessionDate.Value = DateTime.Now;


            nudEnergyLevel.Value = 18;


            nudDuration.Value = 30;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (cbCustomer.SelectedValue == null)
            {
                MessageBox.Show("Please select a customer", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbCustomer.Focus();
                return;
            }


            if (cbBodyArea.SelectedItem == null)
            {
                MessageBox.Show("Please select a body area", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbBodyArea.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"INSERT INTO LaserSessions (CustomerID, BodyArea, SessionDate, EnergyLevel, Duration) 
                                   VALUES (@CustomerID, @BodyArea, @SessionDate, @EnergyLevel, @Duration)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", cbCustomer.SelectedValue);
                        cmd.Parameters.AddWithValue("@BodyArea", cbBodyArea.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@SessionDate", dtpSessionDate.Value);
                        cmd.Parameters.AddWithValue("@EnergyLevel", (int)nudEnergyLevel.Value);
                        cmd.Parameters.AddWithValue("@Duration", (int)nudDuration.Value);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Session saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to save session", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving session: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSaveSession_Click(object sender, EventArgs e)
        {

        }

        private void AddSessionForm_Click(object sender, EventArgs e)
        {

        }

        private void panelNewSession_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}