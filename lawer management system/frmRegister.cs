using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lawer_management_system
{
    public partial class frmRegister : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-FCNJDGTG;Initial Catalog=LawyerDB;Integrated Security=True;TrustServerCertificate=True;");
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // 🔴 1. Empty field check
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtConfirmPassword.Text == "")
            {
                MessageBox.Show("All fields are required");
                return;
            }

            // 🔴 2. Role check
            if (cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a role");
                return;
            }

            // 🔴 3. Password match check
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            try
            {
                con.Open();

                // 🔍 4. Check duplicate username
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username=@u";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@u", txtUsername.Text);

                int exists = (int)checkCmd.ExecuteScalar();

                if (exists > 0)
                {
                    MessageBox.Show("Username already exists");
                    con.Close();
                    return;
                }

                // 💾 5. Insert user
                string query = "INSERT INTO Users (Username, Password, Role) VALUES (@u, @p, @r)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@u", txtUsername.Text);
                cmd.Parameters.AddWithValue("@p", txtPassword.Text);
                cmd.Parameters.AddWithValue("@r", cmbRole.Text);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Registration Successful");

                // 🔁 6. Go back to Login Form
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                con.Close();
            }
        }
    }
}
