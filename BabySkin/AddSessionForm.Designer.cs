namespace BabySkin
{
    partial class AddSessionForm
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
            panelNewSession = new Panel();
            panel1 = new Panel();
            btnSaveSession = new Button();
            nudDuration = new NumericUpDown();
            label10 = new Label();
            nudEnergyLevel = new NumericUpDown();
            label4 = new Label();
            dtpSessionDate = new DateTimePicker();
            label3 = new Label();
            cbBodyArea = new ComboBox();
            label2 = new Label();
            cbCustomer = new ComboBox();
            label1 = new Label();
            lbNewSession = new Label();
            panelNewSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEnergyLevel).BeginInit();
            SuspendLayout();
            // 
            // panelNewSession
            // 
            panelNewSession.BackColor = Color.White;
            panelNewSession.Controls.Add(panel1);
            panelNewSession.Controls.Add(btnSaveSession);
            panelNewSession.Controls.Add(nudDuration);
            panelNewSession.Controls.Add(label10);
            panelNewSession.Controls.Add(nudEnergyLevel);
            panelNewSession.Controls.Add(label4);
            panelNewSession.Controls.Add(dtpSessionDate);
            panelNewSession.Controls.Add(label3);
            panelNewSession.Controls.Add(cbBodyArea);
            panelNewSession.Controls.Add(label2);
            panelNewSession.Controls.Add(cbCustomer);
            panelNewSession.Controls.Add(label1);
            panelNewSession.Controls.Add(lbNewSession);
            panelNewSession.Location = new Point(50, 0);
            panelNewSession.Name = "panelNewSession";
            panelNewSession.Size = new Size(700, 450);
            panelNewSession.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Location = new Point(30, 550);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 160);
            panel1.TabIndex = 12;
            // 
            // btnSaveSession
            // 
            btnSaveSession.BackColor = Color.MediumSeaGreen;
            btnSaveSession.Cursor = Cursors.Hand;
            btnSaveSession.FlatAppearance.BorderSize = 0;
            btnSaveSession.FlatStyle = FlatStyle.Flat;
            btnSaveSession.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveSession.ForeColor = Color.White;
            btnSaveSession.Location = new Point(20, 320);
            btnSaveSession.Name = "btnSaveSession";
            btnSaveSession.Size = new Size(640, 50);
            btnSaveSession.TabIndex = 11;
            btnSaveSession.Text = "💾 Save Session";
            btnSaveSession.UseVisualStyleBackColor = false;
            btnSaveSession.Click += btnSave_Click;
            // 
            // nudDuration
            // 
            nudDuration.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudDuration.Location = new Point(520, 258);
            nudDuration.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            nudDuration.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            nudDuration.Name = "nudDuration";
            nudDuration.Size = new Size(120, 31);
            nudDuration.TabIndex = 10;
            nudDuration.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(520, 230);
            label10.Name = "label10";
            label10.Size = new Size(160, 25);
            label10.TabIndex = 9;
            label10.Text = "⏱️ Duration (min):";
            // 
            // nudEnergyLevel
            // 
            nudEnergyLevel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudEnergyLevel.Location = new Point(360, 258);
            nudEnergyLevel.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nudEnergyLevel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudEnergyLevel.Name = "nudEnergyLevel";
            nudEnergyLevel.Size = new Size(120, 31);
            nudEnergyLevel.TabIndex = 8;
            nudEnergyLevel.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(360, 230);
            label4.Name = "label4";
            label4.Size = new Size(144, 25);
            label4.TabIndex = 7;
            label4.Text = "⚡ Energy Level:";
            // 
            // dtpSessionDate
            // 
            dtpSessionDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpSessionDate.Format = DateTimePickerFormat.Short;
            dtpSessionDate.Location = new Point(20, 260);
            dtpSessionDate.Name = "dtpSessionDate";
            dtpSessionDate.Size = new Size(300, 31);
            dtpSessionDate.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 230);
            label3.Name = "label3";
            label3.Size = new Size(148, 25);
            label3.TabIndex = 5;
            label3.Text = "📅 Session Date:";
            // 
            // cbBodyArea
            // 
            cbBodyArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBodyArea.FormattingEnabled = true;
            cbBodyArea.Location = new Point(20, 180);
            cbBodyArea.Name = "cbBodyArea";
            cbBodyArea.Size = new Size(640, 28);
            cbBodyArea.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 150);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 3;
            label2.Text = "🎯 Body Area:";
            // 
            // cbCustomer
            // 
            cbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCustomer.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(20, 100);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(640, 33);
            cbCustomer.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 70);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 1;
            label1.Text = "👤 Customer:";
            // 
            // lbNewSession
            // 
            lbNewSession.AutoSize = true;
            lbNewSession.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNewSession.ForeColor = Color.DarkSlateGray;
            lbNewSession.Location = new Point(20, 20);
            lbNewSession.Name = "lbNewSession";
            lbNewSession.Size = new Size(256, 38);
            lbNewSession.TabIndex = 0;
            lbNewSession.Text = "New Laser Session";
            // 
            // AddSessionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelNewSession);
            Name = "AddSessionForm";
            Text = "AddSessionForm";
            Load += AddSessionForm_Load;
            Click += AddSessionForm_Click;
            panelNewSession.ResumeLayout(false);
            panelNewSession.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEnergyLevel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNewSession;
        private Panel panel1;
        private Button btnSaveSession;
        private NumericUpDown nudDuration;
        private Label label10;
        private NumericUpDown nudEnergyLevel;
        private Label label4;
        private DateTimePicker dtpSessionDate;
        private Label label3;
        private ComboBox cbBodyArea;
        private Label label2;
        private ComboBox cbCustomer;
        private Label label1;
        private Label lbNewSession;
    }
}