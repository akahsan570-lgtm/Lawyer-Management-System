namespace lawer_management_system
{
    partial class SuperadminDashboard
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
            btnAddAdmin = new Button();
            label1 = new Label();
            dgvAdmins = new DataGridView();
            label2 = new Label();
            btnDeleteAdmin = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label6 = new Label();
            dgvFinance = new DataGridView();
            btnChargeLawyers = new Button();
            button1 = new Button();
            label7 = new Label();
            txtSuperUsername = new TextBox();
            txtSuperPassword = new TextBox();
            btnUpdateSuperadmin = new Button();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFinance).BeginInit();
            SuspendLayout();
            // 
            // btnAddAdmin
            // 
            btnAddAdmin.Location = new Point(874, 252);
            btnAddAdmin.Name = "btnAddAdmin";
            btnAddAdmin.Size = new Size(94, 29);
            btnAddAdmin.TabIndex = 0;
            btnAddAdmin.Text = "Add";
            btnAddAdmin.UseVisualStyleBackColor = true;
            btnAddAdmin.Click += btnAddAdmin_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 23);
            label1.Name = "label1";
            label1.Size = new Size(512, 34);
            label1.TabIndex = 1;
            label1.Text = "Welcome to  Super Admin Dashbord";
            // 
            // dgvAdmins
            // 
            dgvAdmins.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdmins.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAdmins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdmins.Location = new Point(34, 114);
            dgvAdmins.Name = "dgvAdmins";
            dgvAdmins.RowHeadersWidth = 51;
            dgvAdmins.Size = new Size(472, 107);
            dgvAdmins.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 57);
            label2.Name = "label2";
            label2.Size = new Size(144, 27);
            label2.TabIndex = 3;
            label2.Text = "Edit Admins";
            // 
            // btnDeleteAdmin
            // 
            btnDeleteAdmin.Location = new Point(213, 252);
            btnDeleteAdmin.Name = "btnDeleteAdmin";
            btnDeleteAdmin.Size = new Size(94, 29);
            btnDeleteAdmin.TabIndex = 4;
            btnDeleteAdmin.Text = "Delete";
            btnDeleteAdmin.UseVisualStyleBackColor = true;
            btnDeleteAdmin.Click += btnDeleteAdmin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(616, 95);
            label3.Name = "label3";
            label3.Size = new Size(122, 23);
            label3.TabIndex = 5;
            label3.Text = "Add Admin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(712, 146);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 6;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonFace;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(717, 194);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 7;
            label5.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(836, 144);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(192, 27);
            txtUsername.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(836, 194);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(192, 27);
            txtPassword.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(34, 318);
            label6.Name = "label6";
            label6.Size = new Size(195, 27);
            label6.TabIndex = 10;
            label6.Text = "Charge Lawyers";
            // 
            // dgvFinance
            // 
            dgvFinance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFinance.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvFinance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFinance.Location = new Point(141, 370);
            dgvFinance.Name = "dgvFinance";
            dgvFinance.RowHeadersWidth = 51;
            dgvFinance.Size = new Size(780, 107);
            dgvFinance.TabIndex = 11;
            // 
            // btnChargeLawyers
            // 
            btnChargeLawyers.Location = new Point(952, 403);
            btnChargeLawyers.Name = "btnChargeLawyers";
            btnChargeLawyers.Size = new Size(94, 29);
            btnChargeLawyers.TabIndex = 12;
            btnChargeLawyers.Text = "Charge";
            btnChargeLawyers.UseVisualStyleBackColor = true;
            btnChargeLawyers.Click += btnChargeLawyers_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1022, 42);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(34, 505);
            label7.Name = "label7";
            label7.Size = new Size(175, 27);
            label7.TabIndex = 14;
            label7.Text = "Update Profile";
            // 
            // txtSuperUsername
            // 
            txtSuperUsername.Location = new Point(488, 521);
            txtSuperUsername.Name = "txtSuperUsername";
            txtSuperUsername.Size = new Size(192, 27);
            txtSuperUsername.TabIndex = 17;
            // 
            // txtSuperPassword
            // 
            txtSuperPassword.Location = new Point(488, 564);
            txtSuperPassword.Name = "txtSuperPassword";
            txtSuperPassword.Size = new Size(192, 27);
            txtSuperPassword.TabIndex = 18;
            // 
            // btnUpdateSuperadmin
            // 
            btnUpdateSuperadmin.Location = new Point(536, 612);
            btnUpdateSuperadmin.Name = "btnUpdateSuperadmin";
            btnUpdateSuperadmin.Size = new Size(94, 29);
            btnUpdateSuperadmin.TabIndex = 19;
            btnUpdateSuperadmin.Text = "Update";
            btnUpdateSuperadmin.UseVisualStyleBackColor = true;
            btnUpdateSuperadmin.Click += btnUpdateSuperadmin_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonFace;
            label8.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(367, 521);
            label8.Name = "label8";
            label8.Size = new Size(93, 21);
            label8.TabIndex = 20;
            label8.Text = "Username";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonFace;
            label9.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(372, 570);
            label9.Name = "label9";
            label9.Size = new Size(88, 21);
            label9.TabIndex = 21;
            label9.Text = "Password";
            // 
            // SuperadminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1150, 653);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(btnUpdateSuperadmin);
            Controls.Add(txtSuperPassword);
            Controls.Add(txtSuperUsername);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(btnChargeLawyers);
            Controls.Add(dgvFinance);
            Controls.Add(label6);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnDeleteAdmin);
            Controls.Add(label2);
            Controls.Add(dgvAdmins);
            Controls.Add(label1);
            Controls.Add(btnAddAdmin);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SuperadminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Superadmin Dashboard";
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFinance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddAdmin;
        private Label label1;
        private DataGridView dgvAdmins;
        private Label label2;
        private Button btnDeleteAdmin;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label6;
        private DataGridView dgvFinance;
        private Button btnChargeLawyers;
        private Button button1;
        private Label label7;
        private TextBox txtSuperUsername;
        private TextBox txtSuperPassword;
        private Button btnUpdateSuperadmin;
        private Label label8;
        private Label label9;
    }
}