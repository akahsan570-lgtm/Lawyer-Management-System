using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace lawer_management_system
{
    public partial class SuperadminDashboard : Form
    {
        string connectionString =
            @"Data Source=LAPTOP-FCNJDGTG;Initial Catalog=LawyerDB;Integrated Security=True;TrustServerCertificate=True";

        public SuperadminDashboard()
        {
            InitializeComponent();
        }

        // 🔄 AUTO LOAD (NO REFRESH BUTTON NEEDED)
        private void SuperadminDashboard_Load(object sender, EventArgs e)
        {
            LoadAllData();
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            LoadAllData();
        }

        private void LoadAllData()
        {
            LoadAdmins();
            LoadFinanceData();
            LoadSuperadminData();
        }

        // ================= ADMINS =================
        private void LoadAdmins()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT UserId, Username FROM Users WHERE Role = 'Admin'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvAdmins.DataSource = dt;
            }
        }

        // ================= FINANCE =================
        private void LoadFinanceData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"
                SELECT 
                    l.UserId,
                    u.Username,
                    COUNT(c.CaseId) AS CompletedCases,
                    SUM(CASE WHEN c.IsCharged = 0 THEN 1 ELSE 0 END) AS UnchargedCases,
                    l.Balance
                FROM LawyerProfiles l
                JOIN Users u ON l.UserId = u.UserId
                LEFT JOIN Cases c 
                    ON l.UserId = c.LawyerUserId 
                    AND c.Status = 'Completed'
                GROUP BY l.UserId, u.Username, l.Balance";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFinance.DataSource = dt;
            }
        }

        // ================= ADD ADMIN =================

        // ================= DELETE ADMIN =================
        private void LoadSuperadminData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT Username, Password FROM Users WHERE Role = 'Superadmin'";
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtSuperUsername.Text = reader["Username"].ToString();
                    txtSuperPassword.Text = reader["Password"].ToString();
                }

                reader.Close();
            }
        }

        // ================= CHARGE LAWYERS =================


        private void btnAddAdmin_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Fill all fields");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Prevent duplicate
                string check = "SELECT COUNT(*) FROM Users WHERE Username=@u";
                SqlCommand checkCmd = new SqlCommand(check, con);
                checkCmd.Parameters.AddWithValue("@u", txtUsername.Text);

                int exists = (int)checkCmd.ExecuteScalar();

                if (exists > 0)
                {
                    MessageBox.Show("Username already exists");
                    return;
                }

                string query = "INSERT INTO Users (Username, Password, Role) VALUES (@u, @p, 'Admin')";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@u", txtUsername.Text);
                cmd.Parameters.AddWithValue("@p", txtPassword.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Admin added");
            LoadAdmins();
        }

        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {

            if (dgvAdmins.CurrentRow == null)
            {
                MessageBox.Show("Select an admin");
                return;
            }

            int adminId = Convert.ToInt32(dgvAdmins.CurrentRow.Cells["UserId"].Value);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "DELETE FROM Users WHERE UserId=@id AND Role='Admin'";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", adminId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Admin deleted");
            LoadAdmins();
        }

        private void btnChargeLawyers_Click(object sender, EventArgs e)
        {
            decimal chargePerCase = 100;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string selectQuery = @"
        SELECT LawyerUserId, COUNT(*) AS TotalCases
        FROM Cases
        WHERE Status = 'Completed' AND IsCharged = 0
        GROUP BY LawyerUserId";

                SqlCommand cmd = new SqlCommand(selectQuery, con);
                SqlDataReader reader = cmd.ExecuteReader();

                // ✅ CHECK IF THERE IS ANYTHING TO CHARGE
                if (!reader.HasRows)
                {
                    reader.Close();
                    MessageBox.Show("Already charged for all completed cases.");
                    return;
                }

                while (reader.Read())
                {
                    int lawyerId = Convert.ToInt32(reader["LawyerUserId"]);
                    int totalCases = Convert.ToInt32(reader["TotalCases"]);

                    decimal totalCharge = totalCases * chargePerCase;

                    using (SqlConnection con2 = new SqlConnection(connectionString))
                    {
                        con2.Open();

                        string updateQuery = @"
                UPDATE LawyerProfiles
                SET Balance = Balance + @amount
                WHERE UserId = @id";

                        SqlCommand updateCmd = new SqlCommand(updateQuery, con2);
                        updateCmd.Parameters.AddWithValue("@amount", totalCharge);
                        updateCmd.Parameters.AddWithValue("@id", lawyerId);

                        updateCmd.ExecuteNonQuery();
                    }
                }

                reader.Close();

                // ✅ mark charged
                string markQuery = @"
        UPDATE Cases
        SET IsCharged = 1
        WHERE Status = 'Completed' AND IsCharged = 0";

                SqlCommand markCmd = new SqlCommand(markQuery, con);
                markCmd.ExecuteNonQuery();
            }

            MessageBox.Show("Charging completed");
            LoadFinanceData(); // auto refresh grid
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Hide();
        }

        private void btnUpdateSuperadmin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSuperUsername.Text) ||
        string.IsNullOrWhiteSpace(txtSuperPassword.Text))
            {
                MessageBox.Show("Fill all fields");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"
        UPDATE Users
        SET Username = @u, Password = @p
        WHERE Role = 'Superadmin'";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@u", txtSuperUsername.Text);
                cmd.Parameters.AddWithValue("@p", txtSuperPassword.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Superadmin updated successfully");
        }
    }

}