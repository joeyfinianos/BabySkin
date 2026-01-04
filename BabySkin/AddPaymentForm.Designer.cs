namespace BabySkin
{
    partial class AddPaymentForm
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
            lbNewSession = new Label();
            label1 = new Label();
            cbCustomer = new ComboBox();
            label2 = new Label();
            cbSession = new ComboBox();
            nudAmount = new NumericUpDown();
            label111 = new Label();
            dtpPaymentDate = new DateTimePicker();
            label3 = new Label();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            SuspendLayout();
            // 
            // lbNewSession
            // 
            lbNewSession.AutoSize = true;
            lbNewSession.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNewSession.ForeColor = Color.DarkSlateGray;
            lbNewSession.Location = new Point(22, 20);
            lbNewSession.Name = "lbNewSession";
            lbNewSession.Size = new Size(261, 38);
            lbNewSession.TabIndex = 1;
            lbNewSession.Text = "Add New Payment";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 76);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 2;
            label1.Text = "👤 Customer:";
            // 
            // cbCustomer
            // 
            cbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCustomer.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(22, 104);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(640, 33);
            cbCustomer.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 154);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 4;
            label2.Text = "👤 Session:";
            // 
            // cbSession
            // 
            cbSession.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSession.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSession.FormattingEnabled = true;
            cbSession.Items.AddRange(new object[] { "Chest", "Face", "Shoulders", "Back", "Legs" });
            cbSession.Location = new Point(22, 191);
            cbSession.Name = "cbSession";
            cbSession.Size = new Size(640, 33);
            cbSession.TabIndex = 5;
            cbSession.SelectedIndexChanged += cbSession_SelectedIndexChanged;
            // 
            // nudAmount
            // 
            nudAmount.Location = new Point(22, 274);
            nudAmount.Name = "nudAmount";
            nudAmount.Size = new Size(640, 27);
            nudAmount.TabIndex = 6;
            // 
            // label111
            // 
            label111.AutoSize = true;
            label111.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label111.Location = new Point(22, 237);
            label111.Name = "label111";
            label111.Size = new Size(111, 25);
            label111.TabIndex = 7;
            label111.Text = "👤 Amount:";
            // 
            // dtpPaymentDate
            // 
            dtpPaymentDate.Format = DateTimePickerFormat.Short;
            dtpPaymentDate.Location = new Point(22, 348);
            dtpPaymentDate.Name = "dtpPaymentDate";
            dtpPaymentDate.Size = new Size(250, 27);
            dtpPaymentDate.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 320);
            label3.Name = "label3";
            label3.Size = new Size(156, 25);
            label3.TabIndex = 9;
            label3.Text = "👤 Payment Date:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.MediumSeaGreen;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(22, 414);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(640, 50);
            btnSave.TabIndex = 12;
            btnSave.Text = "💾 Save Payment";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // AddPaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(667, 495);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(dtpPaymentDate);
            Controls.Add(label111);
            Controls.Add(nudAmount);
            Controls.Add(cbSession);
            Controls.Add(label2);
            Controls.Add(cbCustomer);
            Controls.Add(label1);
            Controls.Add(lbNewSession);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddPaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Payment";
            Load += AddPaymentForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNewSession;
        private Label label1;
        private ComboBox cbCustomer;
        private Label label2;
        private ComboBox cbSession;
        private NumericUpDown nudAmount;
        private Label label111;
        private DateTimePicker dtpPaymentDate;
        private Label label3;
        private Button btnSave;
    }
}