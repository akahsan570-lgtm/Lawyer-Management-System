namespace lawer_management_system
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            txtUsername = new TextBox();
            btnRegister = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblUsername = new Label();
            btnLogin = new Button();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(313, 170);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(199, 28);
            txtUsername.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(128, 255, 255);
            btnRegister.ForeColor = Color.Teal;
            btnRegister.Location = new Point(313, 384);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(588, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(88, 39);
            label2.Name = "label2";
            label2.Size = new Size(494, 40);
            label2.TabIndex = 4;
            label2.Text = "Lawyer Management System";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = SystemColors.ButtonHighlight;
            lblPassword.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(177, 229);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(93, 21);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(313, 229);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(199, 28);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = SystemColors.ButtonHighlight;
            lblUsername.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(172, 170);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(98, 21);
            lblUsername.TabIndex = 7;
            lblUsername.Text = "Username:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 128, 128);
            btnLogin.ForeColor = Color.Maroon;
            btnLogin.Location = new Point(313, 295);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(280, 354);
            label1.Name = "label1";
            label1.Size = new Size(160, 17);
            label1.TabIndex = 9;
            label1.Text = "Don't have an account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(333, 103);
            label3.Name = "label3";
            label3.Size = new Size(89, 34);
            label3.TabIndex = 10;
            label3.Text = "Login";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(772, 497);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(lblUsername);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegister);
            Controls.Add(txtUsername);
            ForeColor = Color.Black;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Lawyer Management System";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private Button btnRegister;
        private PictureBox pictureBox1;
        private Label label2;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblUsername;
        private Button btnLogin;
        private Label label1;
        private Label label3;
    }
}
