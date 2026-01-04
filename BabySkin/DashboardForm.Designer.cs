namespace BabySkin
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            sidebarpanel = new Panel();
            btnLogout = new Button();
            btnDashboard = new Button();
            lblogo = new Label();
            btnCustomers = new Button();
            btnSessions = new Button();
            btnPayments = new Button();
            mainPanel = new Panel();
            dgvUpcomingSessions = new DataGridView();
            txtSearch = new TextBox();
            lblUpcomingSessions = new Label();
            customerCard = new Panel();
            tbTotalCustomers = new TextBox();
            lbTotalCustomers = new Label();
            lbWelcome = new Label();
            sidebarpanel.SuspendLayout();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUpcomingSessions).BeginInit();
            customerCard.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarpanel
            // 
            sidebarpanel.BackColor = Color.SlateBlue;
            sidebarpanel.Controls.Add(btnLogout);
            sidebarpanel.Controls.Add(btnDashboard);
            sidebarpanel.Controls.Add(lblogo);
            sidebarpanel.Dock = DockStyle.Left;
            sidebarpanel.Location = new Point(0, 0);
            sidebarpanel.Name = "sidebarpanel";
            sidebarpanel.Size = new Size(180, 625);
            sidebarpanel.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.MediumPurple;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(10, 334);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(160, 40);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "🚪 Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.DarkSlateBlue;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(10, 90);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(160, 40);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "🏠 Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // lblogo
            // 
            lblogo.AutoSize = true;
            lblogo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblogo.ForeColor = Color.White;
            lblogo.Location = new Point(20, 25);
            lblogo.Name = "lblogo";
            lblogo.Size = new Size(153, 31);
            lblogo.TabIndex = 0;
            lblogo.Text = "🌸 BabySkin";
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.MediumPurple;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Location = new Point(10, 140);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(160, 40);
            btnCustomers.TabIndex = 1;
            btnCustomers.Text = "👥 Customers";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnSessions
            // 
            btnSessions.BackColor = Color.MediumPurple;
            btnSessions.FlatAppearance.BorderSize = 0;
            btnSessions.FlatStyle = FlatStyle.Flat;
            btnSessions.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSessions.ForeColor = Color.White;
            btnSessions.Location = new Point(10, 190);
            btnSessions.Name = "btnSessions";
            btnSessions.Size = new Size(160, 40);
            btnSessions.TabIndex = 2;
            btnSessions.Text = "📋 Sessions";
            btnSessions.TextAlign = ContentAlignment.MiddleLeft;
            btnSessions.UseVisualStyleBackColor = false;
            btnSessions.Click += btnSessions_Click;
            // 
            // btnPayments
            // 
            btnPayments.BackColor = Color.MediumPurple;
            btnPayments.FlatAppearance.BorderSize = 0;
            btnPayments.FlatStyle = FlatStyle.Flat;
            btnPayments.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPayments.ForeColor = Color.White;
            btnPayments.Location = new Point(10, 240);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(160, 40);
            btnPayments.TabIndex = 3;
            btnPayments.Text = "💳 Payments";
            btnPayments.TextAlign = ContentAlignment.MiddleLeft;
            btnPayments.UseVisualStyleBackColor = false;
            btnPayments.Click += btnPayments_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.AliceBlue;
            mainPanel.Controls.Add(dgvUpcomingSessions);
            mainPanel.Controls.Add(txtSearch);
            mainPanel.Controls.Add(lblUpcomingSessions);
            mainPanel.Controls.Add(customerCard);
            mainPanel.Controls.Add(lbWelcome);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(180, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1074, 625);
            mainPanel.TabIndex = 4;
            // 
            // dgvUpcomingSessions
            // 
            dgvUpcomingSessions.AllowUserToAddRows = false;
            dgvUpcomingSessions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUpcomingSessions.BackgroundColor = Color.White;
            dgvUpcomingSessions.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MediumPurple;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUpcomingSessions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUpcomingSessions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUpcomingSessions.EnableHeadersVisualStyles = false;
            dgvUpcomingSessions.Location = new Point(40, 245);
            dgvUpcomingSessions.MultiSelect = false;
            dgvUpcomingSessions.Name = "dgvUpcomingSessions";
            dgvUpcomingSessions.ReadOnly = true;
            dgvUpcomingSessions.RowHeadersVisible = false;
            dgvUpcomingSessions.RowHeadersWidth = 51;
            dgvUpcomingSessions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUpcomingSessions.Size = new Size(1030, 250);
            dgvUpcomingSessions.TabIndex = 4;
            dgvUpcomingSessions.CellContentClick += dgvUpcomingSessions_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Location = new Point(630, 211);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(220, 31);
            txtSearch.TabIndex = 3;
            txtSearch.Text = "🔍 Search...";
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // lblUpcomingSessions
            // 
            lblUpcomingSessions.AutoSize = true;
            lblUpcomingSessions.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpcomingSessions.ForeColor = Color.DarkSlateGray;
            lblUpcomingSessions.Location = new Point(40, 200);
            lblUpcomingSessions.Name = "lblUpcomingSessions";
            lblUpcomingSessions.Size = new Size(269, 38);
            lblUpcomingSessions.TabIndex = 2;
            lblUpcomingSessions.Text = "Upcoming Sessions";
            // 
            // customerCard
            // 
            customerCard.BackColor = Color.White;
            customerCard.Controls.Add(tbTotalCustomers);
            customerCard.Controls.Add(lbTotalCustomers);
            customerCard.Location = new Point(40, 90);
            customerCard.Name = "customerCard";
            customerCard.Size = new Size(253, 67);
            customerCard.TabIndex = 1;
            // 
            // tbTotalCustomers
            // 
            tbTotalCustomers.Location = new Point(160, 16);
            tbTotalCustomers.Name = "tbTotalCustomers";
            tbTotalCustomers.ReadOnly = true;
            tbTotalCustomers.Size = new Size(65, 27);
            tbTotalCustomers.TabIndex = 1;
            // 
            // lbTotalCustomers
            // 
            lbTotalCustomers.AutoSize = true;
            lbTotalCustomers.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotalCustomers.ForeColor = Color.Gray;
            lbTotalCustomers.Location = new Point(15, 15);
            lbTotalCustomers.Name = "lbTotalCustomers";
            lbTotalCustomers.Size = new Size(139, 25);
            lbTotalCustomers.TabIndex = 0;
            lbTotalCustomers.Text = "Total Customers";
            // 
            // lbWelcome
            // 
            lbWelcome.AutoSize = true;
            lbWelcome.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbWelcome.ForeColor = Color.DarkSlateGray;
            lbWelcome.Location = new Point(40, 30);
            lbWelcome.Name = "lbWelcome";
            lbWelcome.Size = new Size(446, 54);
            lbWelcome.TabIndex = 0;
            lbWelcome.Text = "Welcome Back Admin!";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 625);
            Controls.Add(mainPanel);
            Controls.Add(btnPayments);
            Controls.Add(btnSessions);
            Controls.Add(btnCustomers);
            Controls.Add(sidebarpanel);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardForm";
            FormClosing += DashboardForm_FormClosing;
            Load += DashboardForm_Load;
            sidebarpanel.ResumeLayout(false);
            sidebarpanel.PerformLayout();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUpcomingSessions).EndInit();
            customerCard.ResumeLayout(false);
            customerCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebarpanel;
        private Button btnDashboard;
        private Label lblogo;
        private Button btnCustomers;
        private Button btnSessions;
        private Button btnLogout;
        private Button btnPayments;
        private Panel mainPanel;
        private Label lbWelcome;
        private Panel customerCard;
        private TextBox tbTotalCustomers;
        private Label lbTotalCustomers;
        private DataGridView dgvUpcomingSessions;
        private TextBox txtSearch;
        private Label lblUpcomingSessions;
    }
}