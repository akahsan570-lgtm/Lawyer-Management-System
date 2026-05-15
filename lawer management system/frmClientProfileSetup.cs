using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace lawer_management_system
{
    public partial class frmClientProfileSetup : Form
    {
        int userId;

        public frmClientProfileSetup(int id)
        {
            InitializeComponent();
            userId = id;
        }

        private void frmClientProfileSetup_Load(object sender, EventArgs e)
        {
            // optional: preload data later
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            using (SqlConnection con = new SqlConnection(
                @"Data Source=LAPTOP-FCNJDGTG;Initial Catalog=LawyerDB;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();

                SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM ClientProfiles WHERE UserId=@UserId", con);

                checkCmd.Parameters.AddWithValue("@UserId", userId);

                int exists = (int)checkCmd.ExecuteScalar();

                if (exists > 0)
                {
                    MessageBox.Show("Profile already exists!");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO ClientProfiles (UserId, FullName, Email, Phone, Address) " +
                        "VALUES (@UserId, @FullName, @Email, @Phone, @Address)", con);

                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Profile Saved Successfully!");
                }

                frmClientDashboard frmDash = new frmClientDashboard(userId);
                frmDash.Show();
                this.Hide();
            
        }
    }
    }
}
