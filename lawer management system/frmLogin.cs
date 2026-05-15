using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace lawer_management_system
{
    public partial class frmLogin : Form
    {
        string connectionString =
            @"Data Source=LAPTOP-FCNJDGTG;Initial Catalog=LawyerDB;Integrated Security=True;TrustServerCertificate=True";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // 🔐 LOGIN CHECK
                string query = "SELECT UserId, Role FROM Users WHERE Username=@u AND Password=@p";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@u", txtUsername.Text);
                cmd.Parameters.AddWithValue("@p", txtPassword.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Invalid Username or Password");
                    return;
                }

                int userId = Convert.ToInt32(reader["UserId"]);
                string role = reader["Role"].ToString();
                reader.Close();

                // ================= CLIENT =================
                if (role == "Client")
                {
                    if (ClientProfileExists(con, userId))
                    {
                        frmClientDashboard frm = new frmClientDashboard(userId);
                        frm.Show();
                    }
                    else
                    {
                        frmClientProfileSetup frm = new frmClientProfileSetup(userId);
                        frm.Show();
                    }

                    this.Hide();
                }

                // ================= LAWYER =================
                else if (role == "Lawyer")
                {
                    if (LawyerProfileExists(con, userId))
                    {
                        frmLawyerDashboard frm = new frmLawyerDashboard(userId);
                        frm.Show();
                    }
                    else
                    {
                        frmLawyerProfileSetup frm = new frmLawyerProfileSetup(userId);
                        frm.Show();
                    }

                    this.Hide();
                }

                // ================= ADMIN =================
                else if (role == "Admin")
                {
                    frmAdminDashboard frm = new frmAdminDashboard();
                    frm.Show();
                    this.Hide();
                }
                else if (role == "Superadmin")
                {
                    SuperadminDashboard frm = new SuperadminDashboard();
                    frm.Show();
                    this.Hide();
                }
            }
        }

        // ================= CHECK CLIENT PROFILE =================
        private bool ClientProfileExists(SqlConnection con, int userId)
        {
            string query = "SELECT COUNT(*) FROM ClientProfiles WHERE UserId=@id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", userId);

            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }

        // ================= CHECK LAWYER PROFILE =================
        private bool LawyerProfileExists(SqlConnection con, int userId)
        {
            string query = "SELECT COUNT(*) FROM LawyerProfiles WHERE UserId=@id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", userId);

            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }

        // ================= REGISTER =================
        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister regForm = new frmRegister();
            regForm.Show();
            this.Hide();
        }
    }
}