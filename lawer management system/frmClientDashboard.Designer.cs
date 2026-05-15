namespace lawer_management_system
{
    partial class frmClientDashboard
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
            cmbSpecialization = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            cmbExperience = new ComboBox();
            cmbFee = new ComboBox();
            btnSearch = new Button();
            label5 = new Label();
            dgvLawyers = new DataGridView();
            btnHire = new Button();
            dgvCases = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            btnLogout = new Button();
            label8 = new Label();
            dgvCompletedCases = new DataGridView();
            cmbRating = new ComboBox();
            btnSubmitRating = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLawyers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCases).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompletedCases).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(512, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(235, 34);
            label1.TabIndex = 0;
            label1.Text = "Welcome Client";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Location = new Point(90, 115);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 21);
            label2.TabIndex = 1;
            label2.Text = "Specialization";
            // 
            // cmbSpecialization
            // 
            cmbSpecialization.FormattingEnabled = true;
            cmbSpecialization.Items.AddRange(new object[] { "All", "Criminal Law", "Civil Law", "Family Law", "Corporate Law", "Tax Law", "Property Law", "Cyber Law" });
            cmbSpecialization.Location = new Point(234, 107);
            cmbSpecialization.Margin = new Padding(4, 3, 4, 3);
            cmbSpecialization.Name = "cmbSpecialization";
            cmbSpecialization.Size = new Size(138, 29);
            cmbSpecialization.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Location = new Point(750, 115);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(179, 21);
            label3.TabIndex = 3;
            label3.Text = "Minimum Experience";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Location = new Point(419, 115);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(136, 21);
            label4.TabIndex = 4;
            label4.Text = "Max Hourly Fee";
            // 
            // cmbExperience
            // 
            cmbExperience.FormattingEnabled = true;
            cmbExperience.Items.AddRange(new object[] { "Any", "1+ Years", "3+ Years", "5+ Years", "10+ Years" });
            cmbExperience.Location = new Point(949, 107);
            cmbExperience.Margin = new Padding(4, 3, 4, 3);
            cmbExperience.Name = "cmbExperience";
            cmbExperience.Size = new Size(121, 29);
            cmbExperience.TabIndex = 5;
            // 
            // cmbFee
            // 
            cmbFee.FormattingEnabled = true;
            cmbFee.Items.AddRange(new object[] { "Any", "Below 1000", "1000 - 3000", "3000 - 5000", "Above 5000" });
            cmbFee.Location = new Point(573, 107);
            cmbFee.Margin = new Padding(4, 3, 4, 3);
            cmbFee.Name = "cmbFee";
            cmbFee.Size = new Size(121, 29);
            cmbFee.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 128, 128);
            btnSearch.ForeColor = Color.FromArgb(64, 0, 0);
            btnSearch.Location = new Point(1129, 106);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 63);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(178, 27);
            label5.TabIndex = 8;
            label5.Text = "Search Lawyer";
            // 
            // dgvLawyers
            // 
            dgvLawyers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLawyers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLawyers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLawyers.Location = new Point(146, 178);
            dgvLawyers.MultiSelect = false;
            dgvLawyers.Name = "dgvLawyers";
            dgvLawyers.RowHeadersWidth = 51;
            dgvLawyers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLawyers.Size = new Size(981, 137);
            dgvLawyers.TabIndex = 9;
            // 
            // btnHire
            // 
            btnHire.BackColor = Color.FromArgb(128, 255, 255);
            btnHire.ForeColor = Color.FromArgb(0, 64, 64);
            btnHire.Location = new Point(1133, 228);
            btnHire.Name = "btnHire";
            btnHire.Size = new Size(94, 29);
            btnHire.TabIndex = 10;
            btnHire.Text = "Hire Lawyer";
            btnHire.UseVisualStyleBackColor = false;
            btnHire.Click += btnHire_Click_1;
            // 
            // dgvCases
            // 
            dgvCases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCases.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCases.Location = new Point(146, 355);
            dgvCases.Name = "dgvCases";
            dgvCases.ReadOnly = true;
            dgvCases.RowHeadersWidth = 51;
            dgvCases.Size = new Size(981, 67);
            dgvCases.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 355);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(95, 23);
            label6.TabIndex = 12;
            label6.Text = "My Case";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(30, 168);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(89, 23);
            label7.TabIndex = 13;
            label7.Text = "Lawyers";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1165, 16);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 14;
            btnLogout.Text = "log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(164, 450);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(171, 23);
            label8.TabIndex = 15;
            label8.Text = "Rate the Lawyer";
            label8.Click += label8_Click;
            // 
            // dgvCompletedCases
            // 
            dgvCompletedCases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompletedCases.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCompletedCases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompletedCases.Location = new Point(342, 449);
            dgvCompletedCases.Name = "dgvCompletedCases";
            dgvCompletedCases.ReadOnly = true;
            dgvCompletedCases.RowHeadersWidth = 51;
            dgvCompletedCases.Size = new Size(499, 67);
            dgvCompletedCases.TabIndex = 16;
            // 
            // cmbRating
            // 
            cmbRating.FormattingEnabled = true;
            cmbRating.Items.AddRange(new object[] { "5", "4", "3", "2", "1" });
            cmbRating.Location = new Point(848, 449);
            cmbRating.Margin = new Padding(4, 3, 4, 3);
            cmbRating.Name = "cmbRating";
            cmbRating.Size = new Size(50, 29);
            cmbRating.TabIndex = 17;
            // 
            // btnSubmitRating
            // 
            btnSubmitRating.BackColor = Color.FromArgb(192, 255, 192);
            btnSubmitRating.ForeColor = Color.FromArgb(0, 64, 0);
            btnSubmitRating.Location = new Point(558, 536);
            btnSubmitRating.Name = "btnSubmitRating";
            btnSubmitRating.Size = new Size(94, 29);
            btnSubmitRating.TabIndex = 18;
            btnSubmitRating.Text = "Submit";
            btnSubmitRating.UseVisualStyleBackColor = false;
            btnSubmitRating.Click += btnSubmitRating_Click;
            // 
            // frmClientDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1282, 626);
            Controls.Add(btnSubmitRating);
            Controls.Add(cmbRating);
            Controls.Add(dgvCompletedCases);
            Controls.Add(label8);
            Controls.Add(btnLogout);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dgvCases);
            Controls.Add(btnHire);
            Controls.Add(dgvLawyers);
            Controls.Add(label5);
            Controls.Add(btnSearch);
            Controls.Add(cmbFee);
            Controls.Add(cmbExperience);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbSpecialization);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmClientDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client Dashboard";
            ((System.ComponentModel.ISupportInitialize)dgvLawyers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCases).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompletedCases).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbSpecialization;
        private Label label3;
        private Label label4;
        private ComboBox cmbExperience;
        private ComboBox cmbFee;
        private Button btnSearch;
        private Label label5;
        private DataGridView dgvLawyers;
        private Button btnHire;
        private DataGridView dgvCases;
        private Label label6;
        private Label label7;
        private Button btnLogout;
        private Label label8;
        private DataGridView dgvCompletedCases;
        private ComboBox cmbRating;
        private Button btnSubmitRating;
    }
}