namespace BabySkin
{
    partial class CustomersManagementForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            mainPanel = new Panel();
            mainnPanel = new Panel();
            dataGridView1 = new DataGridView();
            dgvCustomers = new DataGridView();
            txtSearch = new TextBox();
            btnDeleteSelected = new Button();
            btnEditSelected = new Button();
            btnAddCustomer = new Button();
            lbTitle = new Label();
            btnPayments = new Button();
            btnSessions = new Button();
            btnCustomers = new Button();
            sidebarpanel = new Panel();
            btnLogout = new Button();
            btnDashboard = new Button();
            lblogo = new Label();
            mainPanel.SuspendLayout();
            mainnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            sidebarpanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.AliceBlue;
            mainPanel.Controls.Add(mainnPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(180, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1289, 673);
            mainPanel.TabIndex = 9;
            // 
            // mainnPanel
            // 
            mainnPanel.BackColor = Color.Lavender;
            mainnPanel.Controls.Add(dataGridView1);
            mainnPanel.Controls.Add(dgvCustomers);
            mainnPanel.Controls.Add(txtSearch);
            mainnPanel.Controls.Add(btnDeleteSelected);
            mainnPanel.Controls.Add(btnEditSelected);
            mainnPanel.Controls.Add(btnAddCustomer);
            mainnPanel.Controls.Add(lbTitle);
            mainnPanel.Dock = DockStyle.Fill;
            mainnPanel.Location = new Point(0, 0);
            mainnPanel.Name = "mainnPanel";
            mainnPanel.Size = new Size(1289, 673);
            mainnPanel.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MediumPurple;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(30, 630);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1150, 150);
            dataGridView1.TabIndex = 5;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.MediumPurple;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.EnableHeadersVisualStyles = false;
            dgvCustomers.Location = new Point(30, 130);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(1150, 480);
            dgvCustomers.TabIndex = 5;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Location = new Point(30, 80);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(350, 31);
            txtSearch.TabIndex = 4;
            txtSearch.Text = "🔍 Search...";
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // btnDeleteSelected
            // 
            btnDeleteSelected.BackColor = Color.Tomato;
            btnDeleteSelected.Cursor = Cursors.Hand;
            btnDeleteSelected.FlatAppearance.BorderSize = 0;
            btnDeleteSelected.FlatStyle = FlatStyle.Flat;
            btnDeleteSelected.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteSelected.ForeColor = Color.White;
            btnDeleteSelected.Location = new Point(1014, 25);
            btnDeleteSelected.Name = "btnDeleteSelected";
            btnDeleteSelected.Size = new Size(166, 40);
            btnDeleteSelected.TabIndex = 3;
            btnDeleteSelected.Text = "🗑️ Delete Selected";
            btnDeleteSelected.UseVisualStyleBackColor = false;
            // 
            // btnEditSelected
            // 
            btnEditSelected.BackColor = Color.MediumSeaGreen;
            btnEditSelected.Cursor = Cursors.Hand;
            btnEditSelected.FlatAppearance.BorderSize = 0;
            btnEditSelected.FlatStyle = FlatStyle.Flat;
            btnEditSelected.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditSelected.ForeColor = Color.White;
            btnEditSelected.Location = new Point(852, 25);
            btnEditSelected.Name = "btnEditSelected";
            btnEditSelected.Size = new Size(166, 40);
            btnEditSelected.TabIndex = 2;
            btnEditSelected.Text = "✏️ Edit Selected";
            btnEditSelected.UseVisualStyleBackColor = false;
            btnEditSelected.Click += btnEditSelected_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = Color.DodgerBlue;
            btnAddCustomer.Cursor = Cursors.Hand;
            btnAddCustomer.FlatAppearance.BorderSize = 0;
            btnAddCustomer.FlatStyle = FlatStyle.Flat;
            btnAddCustomer.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCustomer.ForeColor = Color.White;
            btnAddCustomer.Location = new Point(691, 25);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(166, 40);
            btnAddCustomer.TabIndex = 1;
            btnAddCustomer.Text = "➕ Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.BackColor = Color.DarkSlateBlue;
            lbTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(30, 20);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(223, 54);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Customers";
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
            btnPayments.TabIndex = 8;
            btnPayments.Text = "💳 Payments";
            btnPayments.TextAlign = ContentAlignment.MiddleLeft;
            btnPayments.UseVisualStyleBackColor = false;
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
            btnSessions.TabIndex = 7;
            btnSessions.Text = "📋 Sessions";
            btnSessions.TextAlign = ContentAlignment.MiddleLeft;
            btnSessions.UseVisualStyleBackColor = false;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.DarkSlateBlue;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Location = new Point(10, 140);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(160, 40);
            btnCustomers.TabIndex = 6;
            btnCustomers.Text = "👥 Customers";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
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
            sidebarpanel.Size = new Size(180, 673);
            sidebarpanel.TabIndex = 5;
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
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.MediumPurple;
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
            btnDashboard.Click += btnDashboard_Click;
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
            // CustomersManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Lavender;
            ClientSize = new Size(1469, 673);
            Controls.Add(mainPanel);
            Controls.Add(btnPayments);
            Controls.Add(btnSessions);
            Controls.Add(btnCustomers);
            Controls.Add(sidebarpanel);
            Name = "CustomersManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BabySkin - Customers";
            Load += CustomersManagementForm_Load;
            mainPanel.ResumeLayout(false);
            mainnPanel.ResumeLayout(false);
            mainnPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            sidebarpanel.ResumeLayout(false);
            sidebarpanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel mainnPanel;
        private Button btnPayments;
        private Button btnSessions;
        private Button btnCustomers;
        private Panel sidebarpanel;
        private Button btnLogout;
        private Button btnDashboard;
        private Label lblogo;
        private Button btnEditSelected;
        private Button btnAddCustomer;
        private Label lbTitle;
        private TextBox txtSearch;
        private Button btnDeleteSelected;
        private DataGridView dgvCustomers;
        private DataGridView dataGridView1;
    }
}