namespace BabySkin
{
    partial class SessionsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnPayments = new Button();
            btnSessions = new Button();
            btnCustomers = new Button();
            sidebarpanel = new Panel();
            btnLogout = new Button();
            btnDashboard = new Button();
            lblogo = new Label();
            mainPanel = new Panel();
            dgvAllSessions = new DataGridView();
            txtSearchSessions = new TextBox();
            btnAddSession = new Button();
            lbTitle = new Label();
            sidebarpanel.SuspendLayout();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllSessions).BeginInit();
            SuspendLayout();
            // 
            // btnPayments
            // 
            btnPayments.BackColor = Color.MediumPurple;
            btnPayments.Cursor = Cursors.Hand;
            btnPayments.FlatAppearance.BorderSize = 0;
            btnPayments.FlatStyle = FlatStyle.Flat;
            btnPayments.Font = new Font("Segoe UI", 10.2F);
            btnPayments.ForeColor = Color.White;
            btnPayments.Location = new Point(10, 240);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(160, 40);
            btnPayments.TabIndex = 12;
            btnPayments.Text = "💳 Payments";
            btnPayments.TextAlign = ContentAlignment.MiddleLeft;
            btnPayments.UseVisualStyleBackColor = false;
            btnPayments.Click += btnPayments_Click_1;
            // 
            // btnSessions
            // 
            btnSessions.BackColor = Color.DarkSlateBlue;
            btnSessions.Cursor = Cursors.Hand;
            btnSessions.FlatAppearance.BorderSize = 0;
            btnSessions.FlatStyle = FlatStyle.Flat;
            btnSessions.Font = new Font("Segoe UI", 10.2F);
            btnSessions.ForeColor = Color.White;
            btnSessions.Location = new Point(10, 190);
            btnSessions.Name = "btnSessions";
            btnSessions.Size = new Size(160, 40);
            btnSessions.TabIndex = 11;
            btnSessions.Text = "📋 Sessions";
            btnSessions.TextAlign = ContentAlignment.MiddleLeft;
            btnSessions.UseVisualStyleBackColor = false;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.MediumPurple;
            btnCustomers.Cursor = Cursors.Hand;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Segoe UI", 10.2F);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Location = new Point(10, 140);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(160, 40);
            btnCustomers.TabIndex = 10;
            btnCustomers.Text = "👥 Customers";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // sidebarpanel
            // 
            sidebarpanel.BackColor = Color.SlateBlue;
            sidebarpanel.Controls.Add(btnPayments);
            sidebarpanel.Controls.Add(btnLogout);
            sidebarpanel.Controls.Add(btnSessions);
            sidebarpanel.Controls.Add(btnDashboard);
            sidebarpanel.Controls.Add(btnCustomers);
            sidebarpanel.Controls.Add(lblogo);
            sidebarpanel.Dock = DockStyle.Left;
            sidebarpanel.Location = new Point(0, 0);
            sidebarpanel.Name = "sidebarpanel";
            sidebarpanel.Size = new Size(180, 720);
            sidebarpanel.TabIndex = 9;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.MediumPurple;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10.2F);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(10, 620);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(160, 40);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "🚪 Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.MediumPurple;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10.2F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(10, 90);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(160, 40);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "🏠 Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblogo
            // 
            lblogo.AutoSize = true;
            lblogo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblogo.ForeColor = Color.White;
            lblogo.Location = new Point(20, 25);
            lblogo.Name = "lblogo";
            lblogo.Size = new Size(153, 31);
            lblogo.TabIndex = 0;
            lblogo.Text = "🌸 BabySkin";
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.Lavender;
            mainPanel.Controls.Add(dgvAllSessions);
            mainPanel.Controls.Add(txtSearchSessions);
            mainPanel.Controls.Add(btnAddSession);
            mainPanel.Controls.Add(lbTitle);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(180, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1100, 720);
            mainPanel.TabIndex = 10;
            // 
            // dgvAllSessions
            // 
            dgvAllSessions.AllowUserToAddRows = false;
            dgvAllSessions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAllSessions.BackgroundColor = Color.White;
            dgvAllSessions.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MediumPurple;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAllSessions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAllSessions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllSessions.EnableHeadersVisualStyles = false;
            dgvAllSessions.Location = new Point(30, 160);
            dgvAllSessions.Name = "dgvAllSessions";
            dgvAllSessions.ReadOnly = true;
            dgvAllSessions.RowHeadersVisible = false;
            dgvAllSessions.RowHeadersWidth = 51;
            dgvAllSessions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllSessions.Size = new Size(1050, 540);
            dgvAllSessions.TabIndex = 5;
            // 
            // txtSearchSessions
            // 
            txtSearchSessions.Font = new Font("Segoe UI", 10.8F);
            txtSearchSessions.ForeColor = Color.Gray;
            txtSearchSessions.Location = new Point(30, 90);
            txtSearchSessions.Name = "txtSearchSessions";
            txtSearchSessions.Size = new Size(400, 31);
            txtSearchSessions.TabIndex = 4;
            txtSearchSessions.Text = "🔍 Search sessions...";
            txtSearchSessions.TextChanged += btnSearch_Click;
            txtSearchSessions.Enter += btnSearch_Click;
            // 
            // btnAddSession
            // 
            btnAddSession.BackColor = Color.MediumSeaGreen;
            btnAddSession.Cursor = Cursors.Hand;
            btnAddSession.FlatAppearance.BorderSize = 0;
            btnAddSession.FlatStyle = FlatStyle.Flat;
            btnAddSession.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnAddSession.ForeColor = Color.White;
            btnAddSession.Location = new Point(800, 25);
            btnAddSession.Name = "btnAddSession";
            btnAddSession.Size = new Size(280, 45);
            btnAddSession.TabIndex = 2;
            btnAddSession.Text = "➕ Add New Session";
            btnAddSession.UseVisualStyleBackColor = false;
            btnAddSession.Click += btnAddSession_Click;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lbTitle.ForeColor = Color.DarkSlateGray;
            lbTitle.Location = new Point(30, 20);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(180, 54);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Sessions";
            // 
            // SessionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1280, 720);
            Controls.Add(mainPanel);
            Controls.Add(sidebarpanel);
            Name = "SessionsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BabySkin - Sessions";
            Load += SessionsForm_Load;
            sidebarpanel.ResumeLayout(false);
            sidebarpanel.PerformLayout();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllSessions).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnSessions;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Panel sidebarpanel;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblogo;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnAddSession;
        private System.Windows.Forms.TextBox txtSearchSessions;
        private System.Windows.Forms.DataGridView dgvAllSessions;
    }
}