namespace BabySkin
{
    partial class addCustomersForm
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
            lbTitle = new Label();
            label1 = new Label();
            txtFullName = new TextBox();
            label2 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            cbGender = new ComboBox();
            label4 = new Label();
            cbSkinType = new ComboBox();
            label5 = new Label();
            txtNotes = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.DarkSlateGray;
            lbTitle.Location = new Point(30, 20);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(292, 41);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Add New Customer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 80);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 1;
            label1.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(30, 110);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(480, 31);
            txtFullName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 160);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 3;
            label2.Text = "Phone Number:";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(30, 190);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(480, 31);
            txtPhone.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 240);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 5;
            label3.Text = "Gender:";
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(30, 270);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(480, 33);
            cbGender.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 320);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 7;
            label4.Text = "Skin Type:";
            // 
            // cbSkinType
            // 
            cbSkinType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSkinType.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSkinType.FormattingEnabled = true;
            cbSkinType.Location = new Point(30, 350);
            cbSkinType.Name = "cbSkinType";
            cbSkinType.Size = new Size(480, 33);
            cbSkinType.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 400);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 9;
            label5.Text = "Notes (Optional):";
            // 
            // txtNotes
            // 
            txtNotes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNotes.Location = new Point(30, 430);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(480, 100);
            txtNotes.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DodgerBlue;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(30, 550);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(230, 45);
            btnSave.TabIndex = 11;
            btnSave.Text = "💾 Save Customer";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gray;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(280, 550);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(230, 45);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "❌ Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            
            // 
            // addCustomersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(532, 603);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtNotes);
            Controls.Add(label5);
            Controls.Add(cbSkinType);
            Controls.Add(label4);
            Controls.Add(cbGender);
            Controls.Add(label3);
            Controls.Add(txtPhone);
            Controls.Add(label2);
            Controls.Add(txtFullName);
            Controls.Add(label1);
            Controls.Add(lbTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "addCustomersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label label1;
        private TextBox txtFullName;
        private Label label2;
        private TextBox txtPhone;
        private Label label3;
        private ComboBox cbGender;
        private Label label4;
        private ComboBox cbSkinType;
        private Label label5;
        private TextBox txtNotes;
        private Button btnSave;
        private Button btnCancel;
    }
}