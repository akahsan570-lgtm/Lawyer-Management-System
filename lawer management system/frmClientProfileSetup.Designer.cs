namespace lawer_management_system
{
    partial class frmClientProfileSetup
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFullName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(213, 31);
            label1.Name = "label1";
            label1.Size = new Size(309, 34);
            label1.TabIndex = 0;
            label1.Text = "Setup Client Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(236, 106);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 1;
            label2.Text = "Full Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(236, 259);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 2;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(251, 211);
            label4.Name = "label4";
            label4.Size = new Size(62, 21);
            label4.TabIndex = 3;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonFace;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(261, 157);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(370, 103);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(221, 28);
            txtFullName.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(370, 204);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(221, 28);
            txtPhone.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(370, 157);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(221, 28);
            txtEmail.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(370, 256);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(221, 65);
            txtAddress.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 255, 255);
            btnSave.ForeColor = Color.Teal;
            btnSave.Location = new Point(370, 366);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(136, 29);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save Profile";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // frmClientProfileSetup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtFullName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmClientProfileSetup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile setup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtFullName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private Button btnSave;
    }
}