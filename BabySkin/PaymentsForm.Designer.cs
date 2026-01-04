namespace BabySkin
{
    partial class PaymentsForm
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
            btnPayments = new Button();
            btnSessions = new Button();
            btnCustomers = new Button();
            sidebarpanel = new Panel();
            btnLogout = new Button();
            btnDashboard = new Button();
            lblogo = new Label();
            mainPanel = new Panel();
            dgvAllPayments = new DataGridView();
            txtSearchPayments = new TextBox();
            btnAddPayment = new Button();
            label1 = new Label();
            sidebarpanel.SuspendLayout();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllPayments).BeginInit();
            SuspendLayout();
            // 
            // btnPayments
            // 
            btnPayments.BackColor = Color.DarkSlateBlue;
            btnPayments.FlatAppearance.BorderSize = 0;
            btnPayments.FlatStyle = FlatStyle.Flat;
            btnPayments.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPayments.ForeColor = Color.White;
            btnPayments.Location = new Point(10, 240);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(160, 40);
            btnPayments.TabIndex = 7;
            btnPayments.Text = "💳 Payments";
            btnPayments.TextAlign = ContentAlignment.MiddleLeft;
            btnPayments.UseVisualStyleBackColor = false;
            btnPayments.Click += btnPayments_Click_1;
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
            btnSessions.TabIndex = 6;
            btnSessions.Text = "📋 Sessions";
            btnSessions.TextAlign = ContentAlignment.MiddleLeft;
            btnSessions.UseVisualStyleBackColor = false;
            btnSessions.Click += btnSessions_Click_1;
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
            btnCustomers.TabIndex = 5;
            btnCustomers.Text = "👥 Customers";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click_1;
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
            sidebarpanel.Size = new Size(180, 673);
            sidebarpanel.TabIndex = 4;
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
            btnLogout.Click += btnLogout_Click_1;
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
            btnDashboard.Click += btnDashboard_Click_1;
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
            // mainPanel
            // 
            mainPanel.Controls.Add(dgvAllPayments);
            mainPanel.Controls.Add(txtSearchPayments);
            mainPanel.Controls.Add(btnAddPayment);
            mainPanel.Controls.Add(label1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(180, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1188, 673);
            mainPanel.TabIndex = 5;
            // 
            // dgvAllPayments
            // 
            dgvAllPayments.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MediumPurple;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAllPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAllPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllPayments.EnableHeadersVisualStyles = false;
            dgvAllPayments.Location = new Point(30, 160);
            dgvAllPayments.Name = "dgvAllPayments";
            dgvAllPayments.ReadOnly = true;
            dgvAllPayments.RowHeadersWidth = 51;
            dgvAllPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllPayments.Size = new Size(1150, 540);
            dgvAllPayments.TabIndex = 3;
            // 
            // txtSearchPayments
            // 
            txtSearchPayments.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchPayments.Location = new Point(30, 90);
            txtSearchPayments.Name = "txtSearchPayments";
            txtSearchPayments.Size = new Size(400, 31);
            txtSearchPayments.TabIndex = 2;
            txtSearchPayments.Text = "🔍 Search payments...";
            // 
            // btnAddPayment
            // 
            btnAddPayment.BackColor = Color.DodgerBlue;
            btnAddPayment.FlatAppearance.BorderSize = 0;
            btnAddPayment.FlatStyle = FlatStyle.Flat;
            btnAddPayment.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPayment.ForeColor = Color.White;
            btnAddPayment.Location = new Point(900, 25);
            btnAddPayment.Name = "btnAddPayment";
            btnAddPayment.Size = new Size(280, 45);
            btnAddPayment.TabIndex = 1;
            btnAddPayment.Text = "➕ Add New Payment";
            btnAddPayment.UseVisualStyleBackColor = false;
            btnAddPayment.Click += btnAddPayment_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(30, 20);
            label1.Name = "label1";
            label1.Size = new Size(208, 54);
            label1.TabIndex = 0;
            label1.Text = "Payments";
            // 
            // PaymentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1368, 673);
            Controls.Add(mainPanel);
            Controls.Add(sidebarpanel);
            Name = "PaymentsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BabySkin - Payments";
            Load += PaymentsForm_Load;
            sidebarpanel.ResumeLayout(false);
            sidebarpanel.PerformLayout();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllPayments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPayments;
        private Button btnSessions;
        private Button btnCustomers;
        private Panel sidebarpanel;
        private Button btnLogout;
        private Button btnDashboard;
        private Label lblogo;
        private Panel mainPanel;
        private Label label1;
        private Button btnAddPayment;
        private DataGridView dgvAllPayments;
        private TextBox txtSearchPayments;
    }
}