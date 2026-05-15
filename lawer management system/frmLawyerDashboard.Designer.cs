namespace lawer_management_system
{
    partial class frmLawyerDashboard
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
            dgvPending = new DataGridView();
            dgvOngoing = new DataGridView();
            btnComplete = new Button();
            label2 = new Label();
            label3 = new Label();
            btnAccept = new Button();
            btnReject = new Button();
            btnLogout = new Button();
            label4 = new Label();
            dgvBalance = new DataGridView();
            btnPay = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPending).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOngoing).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBalance).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(444, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 34);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // dgvPending
            // 
            dgvPending.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPending.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPending.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPending.Location = new Point(180, 257);
            dgvPending.Name = "dgvPending";
            dgvPending.RowHeadersWidth = 51;
            dgvPending.Size = new Size(677, 152);
            dgvPending.TabIndex = 1;
            // 
            // dgvOngoing
            // 
            dgvOngoing.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOngoing.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOngoing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOngoing.Location = new Point(180, 70);
            dgvOngoing.Name = "dgvOngoing";
            dgvOngoing.RowHeadersWidth = 51;
            dgvOngoing.Size = new Size(691, 151);
            dgvOngoing.TabIndex = 2;
            // 
            // btnComplete
            // 
            btnComplete.Location = new Point(895, 121);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(94, 29);
            btnComplete.TabIndex = 3;
            btnComplete.Text = "Complete";
            btnComplete.UseVisualStyleBackColor = true;
            btnComplete.Click += btnComplete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 70);
            label2.Name = "label2";
            label2.Size = new Size(150, 23);
            label2.TabIndex = 4;
            label2.Text = "Ongoing Case";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 257);
            label3.Name = "label3";
            label3.Size = new Size(146, 23);
            label3.TabIndex = 5;
            label3.Text = "Pending Case";
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(895, 277);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(94, 29);
            btnAccept.TabIndex = 6;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnReject
            // 
            btnReject.Location = new Point(895, 347);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(94, 29);
            btnReject.TabIndex = 7;
            btnReject.Text = "Reject";
            btnReject.UseVisualStyleBackColor = true;
            btnReject.Click += btnReject_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(993, 9);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 435);
            label4.Name = "label4";
            label4.Size = new Size(177, 23);
            label4.TabIndex = 9;
            label4.Text = "Pending Balance";
            // 
            // dgvBalance
            // 
            dgvBalance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBalance.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBalance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBalance.Location = new Point(199, 435);
            dgvBalance.Name = "dgvBalance";
            dgvBalance.RowHeadersWidth = 51;
            dgvBalance.Size = new Size(348, 72);
            dgvBalance.TabIndex = 10;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(585, 452);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(94, 29);
            btnPay.TabIndex = 11;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // frmLawyerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1099, 581);
            Controls.Add(btnPay);
            Controls.Add(dgvBalance);
            Controls.Add(label4);
            Controls.Add(btnLogout);
            Controls.Add(btnReject);
            Controls.Add(btnAccept);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnComplete);
            Controls.Add(dgvOngoing);
            Controls.Add(dgvPending);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLawyerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lawyer Dash board";
            ((System.ComponentModel.ISupportInitialize)dgvPending).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOngoing).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBalance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvPending;
        private DataGridView dgvOngoing;
        private Button btnComplete;
        private Label label2;
        private Label label3;
        private Button btnAccept;
        private Button btnReject;
        private Button btnLogout;
        private Label label4;
        private DataGridView dgvBalance;
        private Button btnPay;
    }
}