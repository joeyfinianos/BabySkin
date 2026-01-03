using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace BabySkin
{
    public partial class CustomersManagementForm : Form
    {
        private String connectionString = @"Data Source=DESKTOP-CNQIILR\SQLEXPRESS;Initial Catalog=db_BabySkin;Integrated Security=True;TrustServerCertificate=True";




        public CustomersManagementForm()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomersManagementForm_Load(object sender, EventArgs e)
        {
            loadCustomers();
            
        }
        private void loadCustomers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT 
                                        CustomerID, 
                                        FullName AS Name, 
                                        Phone, 
                                        Gender, 
                                        SkinType AS [Skin Type] 
                                     FROM Customers 
                                     ORDER BY FullName";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvCustomers.DataSource = dt;

                    if (dgvCustomers.Columns["CustomerID"] != null)
                    {
                        dgvCustomers.Columns["CustomerID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
