using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace lawer_management_system
{
    public partial class frmLawyerDashboard : Form
    {
        int userID;

        string connectionString =
            @"Data Source=LAPTOP-FCNJDGTG;Initial Catalog=LawyerDB;Integrated Security=True;TrustServerCertificate=True";

        public frmLawyerDashboard(int id)
        {
            InitializeComponent();
            userID = id;
        }

        // ================= LOAD =================
        private void frmLawyerDashboard_Load(object sender, EventArgs e)
        {
            SetupGrid();
            LoadPendingCases();
            LoadOngoingCases();
            LoadBalance();
        }

        // ================= AUTO REFRESH =================
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            LoadPendingCases();
            LoadOngoingCases();
            LoadBalance();
        }

        // ================= GRID SETUP =================
        private void SetupGrid()
        {
            dgvPending.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPending.MultiSelect = false;
            dgvPending.ReadOnly = true;
            dgvPending.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvOngoing.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOngoing.MultiSelect = false;
            dgvOngoing.ReadOnly = true;
            dgvOngoing.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // NEW BALANCE GRID
            dgvBalance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBalance.MultiSelect = false;
            dgvBalance.ReadOnly = true;
            dgvBalance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        // ================= LOAD BALANCE =================
        private void LoadBalance()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"
                SELECT UserId, Balance
                FROM LawyerProfiles
                WHERE UserId = @id";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@id", userID);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvBalance.DataSource = dt;
            }
        }
        // ================= LOAD PENDING =================
        private void LoadPendingCases()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"
                SELECT 
                    c.CaseId,
                    cp.FullName AS ClientName,
                    lp.FullName AS LawyerName,
                    c.Status,
                    c.CreatedAt
                FROM Cases c
                JOIN ClientProfiles cp ON c.ClientUserId = cp.UserId
                JOIN LawyerProfiles lp ON c.LawyerUserId = lp.UserId
                WHERE c.LawyerUserId = @id 
                AND c.Status = 'Pending'";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@id", userID);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvPending.DataSource = dt;
            }
        }

        // ================= LOAD ONGOING =================
        private void LoadOngoingCases()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"
                SELECT 
                    c.CaseId,
                    cp.FullName AS ClientName,
                    lp.FullName AS LawyerName,
                    c.Status,
                    c.CreatedAt
                FROM Cases c
                JOIN ClientProfiles cp ON c.ClientUserId = cp.UserId
                JOIN LawyerProfiles lp ON c.LawyerUserId = lp.UserId
                WHERE c.LawyerUserId = @id 
                AND c.Status IN ('Accepted', 'Completed', 'Rejected')";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@id", userID);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvOngoing.DataSource = dt;
            }
        }

        // ================= UPDATE STATUS (PENDING CASES) =================
        private void UpdatePendingStatus(string status)
        {
            if (dgvPending.CurrentRow == null)
            {
                MessageBox.Show("Select a pending case first.");
                return;
            }

            int caseId = Convert.ToInt32(dgvPending.CurrentRow.Cells["CaseId"].Value);

            UpdateStatus(caseId, status);
        }

        // ================= UPDATE STATUS (ONGOING CASES) =================
        private void UpdateOngoingStatus(string status)
        {
            if (dgvOngoing.CurrentRow == null)
            {
                MessageBox.Show("Select a case first.");
                return;
            }

            int caseId = Convert.ToInt32(dgvOngoing.CurrentRow.Cells["CaseId"].Value);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // 🔴 CHECK CURRENT STATUS FROM DB
                string checkQuery = "SELECT Status FROM Cases WHERE CaseId = @id";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@id", caseId);

                string currentStatus = checkCmd.ExecuteScalar().ToString();

                // ❌ BLOCK IF REJECTED
                if (currentStatus == "Rejected")
                {
                    MessageBox.Show("This case is rejected. You cannot update it.");
                    return;
                }

                // ✅ OTHERWISE UPDATE
                UpdateStatus(caseId, status);
            }
        }
        // ================= DATABASE UPDATE =================
        private void UpdateStatus(int caseId, string status)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"
                UPDATE Cases 
                SET Status = @status
                WHERE CaseId = @caseId 
                AND LawyerUserId = @lawyerId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@caseId", caseId);
                cmd.Parameters.AddWithValue("@lawyerId", userID);

                cmd.ExecuteNonQuery();
            }

            LoadPendingCases();
            LoadOngoingCases();
        }

        // ================= BUTTONS =================
        

        // ================= PAY BUTTON =================

        // Pending actions
        private void btnAccept_Click(object sender, EventArgs e)
        {
            UpdatePendingStatus("Accepted");
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            UpdatePendingStatus("Rejected");
        }

        // Ongoing actions
        private void btnComplete_Click(object sender, EventArgs e)
        {
            UpdateOngoingStatus("Completed");
            IncrementTotalCases();
        }
        private void IncrementTotalCases()
        {
            if (dgvOngoing.CurrentRow == null)
                return;

            int caseId = Convert.ToInt32(dgvOngoing.CurrentRow.Cells["CaseId"].Value);

            int lawyerId = 0;

            // 🔥 GET LAWYER ID FROM DATABASE (SAFE METHOD)
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT LawyerUserId FROM Cases WHERE CaseId = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", caseId);

                lawyerId = Convert.ToInt32(cmd.ExecuteScalar());
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string update = @"
        UPDATE LawyerProfiles
        SET TotalCases = ISNULL(TotalCases, 0) + 1
        WHERE UserId = @lawyerId";

                SqlCommand cmd = new SqlCommand(update, con);
                cmd.Parameters.AddWithValue("@lawyerId", lawyerId);

                cmd.ExecuteNonQuery();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Hide();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
        
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"
                UPDATE LawyerProfiles
                SET Balance = 0
                WHERE UserId = @id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", userID);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Payment completed. Balance reset to 0.");

            LoadBalance();
        }
    }
    
}