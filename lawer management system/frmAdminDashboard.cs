using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace lawer_management_system
{
    public partial class frmAdminDashboard : Form
    {
        string connectionString =
            @"Data Source=LAPTOP-FCNJDGTG;Initial Catalog=LawyerDB;Integrated Security=True;TrustServerCertificate=True";

        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        // 🔥 AUTO REFRESH LIKE CLIENT DASHBOARD
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            RefreshAll();
        }

        // ================= FORM LOAD =================
        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            RefreshAll();
        }

        // ================= MASTER REFRESH =================
        private void RefreshAll()
        {
            LoadClients();
            LoadLawyers();
        }

        // ================= CLIENTS =================
        private void LoadClients()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT * FROM ClientProfiles";
                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvClients.DataSource = dt;
            }
        }

        // ================= LAWYERS =================
        private void LoadLawyers()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT * FROM LawyerProfiles";
                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvLawyers.DataSource = dt;
            }
        }

        // ================= DELETE CLIENT =================
        private void btnDeleteLawyer_Click_1(object sender, EventArgs e)
        {
            if (dgvClients.CurrentRow == null)
            {
                MessageBox.Show("Select a client first.");
                return;
            }

            int clientId = Convert.ToInt32(dgvClients.CurrentRow.Cells["UserId"].Value);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // 🔥 ONLY BLOCK IF ACCEPTED EXISTS
                string checkQuery = @"
        SELECT COUNT(*) 
        FROM Cases 
        WHERE ClientUserId = @id 
        AND LTRIM(RTRIM(Status)) = 'Accepted'";

                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@id", clientId);

                int activeCases = (int)checkCmd.ExecuteScalar();

                if (activeCases > 0)
                {
                    MessageBox.Show("Cannot delete client. Active (Accepted) case exists.");
                    return;
                }

                // 🟢 DELETE CASES FIRST
                SqlCommand cmd1 = new SqlCommand(
                    "DELETE FROM Cases WHERE ClientUserId = @id", con);
                cmd1.Parameters.AddWithValue("@id", clientId);
                cmd1.ExecuteNonQuery();

                // 🟢 DELETE PROFILE
                SqlCommand cmd2 = new SqlCommand(
                    "DELETE FROM ClientProfiles WHERE UserId = @id", con);
                cmd2.Parameters.AddWithValue("@id", clientId);
                cmd2.ExecuteNonQuery();

                // 🟢 DELETE USER
                SqlCommand cmd3 = new SqlCommand(
                    "DELETE FROM Users WHERE UserId = @id", con);
                cmd3.Parameters.AddWithValue("@id", clientId);
                cmd3.ExecuteNonQuery();
            }

            RefreshAll();
        }

        // ================= DELETE LAWYER =================

        private void btnDeleteClient_Click_1(object sender, EventArgs e)
        {
            if (dgvLawyers.CurrentRow == null)
            {
                MessageBox.Show("Select a lawyer first.");
                return;
            }

            int lawyerId = Convert.ToInt32(dgvLawyers.CurrentRow.Cells["UserId"].Value);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // 🔥 ONLY BLOCK IF ACCEPTED EXISTS
                string checkQuery = @"
        SELECT COUNT(*) 
        FROM Cases 
        WHERE LawyerUserId = @id 
        AND LTRIM(RTRIM(Status)) = 'Accepted'";

                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@id", lawyerId);

                int activeCases = (int)checkCmd.ExecuteScalar();

                if (activeCases > 0)
                {
                    MessageBox.Show("Cannot delete lawyer. Active (Accepted) case exists.");
                    return;
                }

                // 🟢 DELETE CASES
                SqlCommand cmd1 = new SqlCommand(
                    "DELETE FROM Cases WHERE LawyerUserId = @id", con);
                cmd1.Parameters.AddWithValue("@id", lawyerId);
                cmd1.ExecuteNonQuery();

                // 🟢 DELETE PROFILE
                SqlCommand cmd2 = new SqlCommand(
                    "DELETE FROM LawyerProfiles WHERE UserId = @id", con);
                cmd2.Parameters.AddWithValue("@id", lawyerId);
                cmd2.ExecuteNonQuery();

                // 🟢 DELETE USER
                SqlCommand cmd3 = new SqlCommand(
                    "DELETE FROM Users WHERE UserId = @id", con);
                cmd3.Parameters.AddWithValue("@id", lawyerId);
                cmd3.ExecuteNonQuery();
            }

            RefreshAll();
        }



        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Hide();
        }
    }
}