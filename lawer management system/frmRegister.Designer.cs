namespace lawer_management_system
{
    partial class frmRegister
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
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            cmbRole = new ComboBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(178, 119);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(275, 46);
            label5.Name = "label5";
            label5.Size = new Size(123, 34);
            label5.TabIndex = 4;
            label5.Text = "Register";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(178, 179);
            label6.Name = "label6";
            label6.Size = new Size(88, 21);
            label6.TabIndex = 5;
            label6.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(221, 299);
            label2.Name = "label2";
            label2.Size = new Size(45, 21);
            label2.TabIndex = 6;
            label2.Text = "Role";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(115, 234);
            label3.Name = "label3";
            label3.Size = new Size(156, 21);
            label3.TabIndex = 7;
            label3.Text = "Confirm Password";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(300, 117);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(151, 28);
            txtUsername.TabIndex = 8;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Client", "Lawyer" });
            cmbRole.Location = new Point(300, 299);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(114, 28);
            cmbRole.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(300, 172);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(151, 28);
            txtPassword.TabIndex = 10;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(300, 234);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(151, 28);
            txtConfirmPassword.TabIndex = 11;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(128, 255, 255);
            btnRegister.ForeColor = Color.Teal;
            btnRegister.Location = new Point(275, 378);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(747, 482);
            Controls.Add(btnRegister);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(cmbRole);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register_Lawyer Management system";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label5;
        private Label label6;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private ComboBox cmbRole;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button btnRegister;
    }
}