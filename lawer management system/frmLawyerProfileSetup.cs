using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace lawer_management_system
{
    public partial class frmLawyerProfileSetup : Form
    {
        int userId;

        public frmLawyerProfileSetup(int id)
        {
            InitializeComponent();
            userId = id;
        }

        private void frmLawyerProfileSetup_Load(object sender, EventArgs e)
        {
            cmbSpecialization.Items.Add("Criminal Law");
            cmbSpecialization.Items.Add("Civil Law");
            cmbSpecialization.Items.Add("Family Law");
            cmbSpecialization.Items.Add("Corporate Law");
            cmbSpecialization.Items.Add("Tax Law");
            cmbSpecialization.Items.Add("Property Law");
            cmbSpecialization.Items.Add("Cyber Law");
            cmbSpecialization.Items.Add("Immigration Law");
            cmbSpecialization.Items.Add("Human Rights Law");
            cmbSpecialization.Items.Add("Labour Law");
            cmbSpecialization.Items.Add("Constitutional Law");

            cmbSpecialization.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 🔹 Validation
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtLicenseNumber.Text) ||
                cmbSpecialization.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtExperience.Text) ||
                string.IsNullOrWhiteSpace(txtHourlyFee.Text))
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            // 🔹 Convert Experience safely
            int experience;
            if (!int.TryParse(txtExperience.Text, out experience))
            {
                MessageBox.Show("Enter valid experience (number)");
                return;
            }

            // 🔹 Convert Hourly Fee safely
            decimal fee;
            if (!decimal.TryParse(txtHourlyFee.Text, out fee))
            {
                MessageBox.Show("Enter valid hourly fee");
                return;
            }

            using (SqlConnection con = new SqlConnection(
                @"Data Source=LAPTOP-FCNJDGTG;Initial Catalog=LawyerDB;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();

                // 🔹 Check if profile already exists
                SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM LawyerProfiles WHERE UserId=@UserId", con);

                checkCmd.Parameters.AddWithValue("@UserId", userId);

                int exists = (int)checkCmd.ExecuteScalar();

                if (exists == 0)
                {
                    // 🔹 Insert with HourlyFee
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO LawyerProfiles " +
                        "(UserId, FullName, Email, Phone, Address, LicenseNumber, Specialization, Experience, HourlyFee) " +
                        "VALUES (@UserId, @FullName, @Email, @Phone, @Address, @License, @Spec, @Exp, @Fee)", con);

                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@License", txtLicenseNumber.Text);
                    cmd.Parameters.AddWithValue("@Spec", cmbSpecialization.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Exp", experience);
                    cmd.Parameters.AddWithValue("@Fee", fee);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Lawyer Profile Saved Successfully!");
                }
                else
                {
                    MessageBox.Show("Profile already exists!");
                }

                // 🔹 Always go to dashboard
                frmLawyerDashboard frmDash = new frmLawyerDashboard(userId);
                frmDash.Show();
                this.Hide();
            }
        }
    }
}