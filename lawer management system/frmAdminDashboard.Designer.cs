namespace lawer_management_system
{
    partial class frmAdminDashboard
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
            btnDeleteClient = new Button();
            dgvClients = new DataGridView();
            label1 = new Label();
            dgvLawyers = new DataGridView();
            btnDeleteLawyer = new Button();
            btnLogout = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLawyers).BeginInit();
            SuspendLayout();
            // 
            // btnDeleteClient
            // 
            btnDeleteClient.BackColor = Color.FromArgb(255, 128, 128);
            btnDeleteClient.ForeColor = Color.Maroon;
            btnDeleteClient.Location = new Point(1039, 491);
            btnDeleteClient.Name = "btnDeleteClient";
            btnDeleteClient.Size = new Size(94, 29);
            btnDeleteClient.TabIndex = 0;
            btnDeleteClient.Text = "Delete";
            btnDeleteClient.UseVisualStyleBackColor = false;
            btnDeleteClient.Click += btnDeleteClient_Click_1;
            // 
            // dgvClients
            // 
            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(187, 100);
            dgvClients.Name = "dgvClients";
            dgvClients.RowHeadersWidth = 51;
            dgvClients.Size = new Size(804, 135);
            dgvClients.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(546, 17);
            label1.Name = "label1";
            label1.Size = new Size(146, 34);
            label1.TabIndex = 2;
            label1.Text = "Welcome";
            // 
            // dgvLawyers
            // 
            dgvLawyers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLawyers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLawyers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLawyers.Location = new Point(54, 334);
            dgvLawyers.Name = "dgvLawyers";
            dgvLawyers.RowHeadersWidth = 51;
            dgvLawyers.Size = new Size(1027, 141);
            dgvLawyers.TabIndex = 3;
            // 
            // btnDeleteLawyer
            // 
            btnDeleteLawyer.BackColor = Color.FromArgb(255, 128, 128);
            btnDeleteLawyer.ForeColor = Color.Maroon;
            btnDeleteLawyer.Location = new Point(924, 241);
            btnDeleteLawyer.Name = "btnDeleteLawyer";
            btnDeleteLawyer.Size = new Size(94, 29);
            btnDeleteLawyer.TabIndex = 4;
            btnDeleteLawyer.Text = "Delete";
            btnDeleteLawyer.UseVisualStyleBackColor = false;
            btnDeleteLawyer.Click += btnDeleteLawyer_Click_1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(128, 255, 128);
            btnLogout.ForeColor = Color.FromArgb(0, 64, 0);
            btnLogout.Location = new Point(1039, 17);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(162, 63);
            label2.Name = "label2";
            label2.Size = new Size(74, 23);
            label2.TabIndex = 6;
            label2.Text = "Clients";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(1, 297);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 7;
            label3.Text = "Lawyers";
            // 
            // frmAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1145, 577);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLogout);
            Controls.Add(btnDeleteLawyer);
            Controls.Add(dgvLawyers);
            Controls.Add(label1);
            Controls.Add(dgvClients);
            Controls.Add(btnDeleteClient);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashbord";
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLawyers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeleteClient;
        private DataGridView dgvClients;
        private Label label1;
        private DataGridView dgvLawyers;
        private Button btnDeleteLawyer;
        private Button btnLogout;
        private Label label2;
        private Label label3;
    }
}