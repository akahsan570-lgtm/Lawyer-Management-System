using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Drawing;

namespace lawer_management_system
{
    public partial class frmClientDashboard : Form
    {
        int userId;

        string connectionString =
            @"Data Source=LAPTOP-FCNJDGTG;Initial Catalog=LawyerDB;Integrated Security=True;TrustServerCertificate=True";

        System.Windows.Forms.Timer statusTimer = new System.Windows.Forms.Timer();
        DataTable previousState = new DataTable();

        public frmClientDashboard(int id)
        {
            InitializeComponent();
            userId = id;

            statusTimer.Interval = 5000;
            statusTimer.Tick += StatusTimer_Tick;
            statusTimer.Start();
        }

        private void frmClientDashboard_Load(object sender, EventArgs e)
        {
            cmbSpecialization.Items.AddRange(new string[]
            {
                "All","Criminal Law","Civil Law","Family Law",
                "Corporate Law","Tax Law","Property Law","Cyber Law"
            });

            cmbFee.Items.AddRange(new string[]
            {
                "Any","Below 1000","1000 - 3000","3000 - 5000","Above 5000"
            });

            cmbExperience.Items.AddRange(new string[]
            {
                "Any","1+ Years","3+ Years","5+ Years","10+ Years"
            });

            cmbSpecialization.SelectedIndex = 0;
            cmbFee.SelectedIndex = 0;
            cmbExperience.SelectedIndex = 0;

            LoadCompletedCases(); // 🔥 ADDED
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            LoadMyCases();
            LoadCompletedCases(); // 🔥 ADDED
        }

        // ================= LOAD ACTIVE CASES =================
        private void LoadMyCases()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"
                SELECT 
                    c.CaseId,
                    lp.FullName AS LawyerName,
                    c.Status,
                    c.CreatedAt
                FROM Cases c
                JOIN LawyerProfiles lp ON c.LawyerUserId = lp.UserId
                WHERE c.ClientUserId = @id
                AND c.Status IN ('Pending', 'Accepted')";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@id", userId);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCases.DataSource = dt;
            }
        }

        // ================= LOAD COMPLETED CASES =================
        private void LoadCompletedCases()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"
                SELECT 
                    c.CaseId,
                    lp.UserId AS LawyerUserId,
                    lp.FullName AS LawyerName,
                    c.CreatedAt
                FROM Cases c
                JOIN LawyerProfiles lp ON c.LawyerUserId = lp.UserId
                WHERE c.ClientUserId = @id
                AND c.Status = 'Completed'";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@id", userId);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCompletedCases.DataSource = dt;
            }
        }

        // ================= SEARCH =================
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"
        SELECT UserId, FullName, Specialization, Experience, HourlyFee
        FROM LawyerProfiles
        WHERE 1=1";

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;

                // ================= SPECIALIZATION FILTER =================
                if (cmbSpecialization.SelectedItem != null &&
                    cmbSpecialization.SelectedItem.ToString() != "All")
                {
                    query += " AND Specialization = @spec";
                    cmd.Parameters.AddWithValue("@spec", cmbSpecialization.SelectedItem.ToString());
                }

                // ================= EXPERIENCE FILTER =================
                if (cmbExperience.SelectedItem != null &&
                    cmbExperience.SelectedItem.ToString() != "Any")
                {
                    string exp = cmbExperience.SelectedItem.ToString();

                    if (exp == "1+ Years")
                        query += " AND Experience >= 1";
                    else if (exp == "3+ Years")
                        query += " AND Experience >= 3";
                    else if (exp == "5+ Years")
                        query += " AND Experience >= 5";
                    else if (exp == "10+ Years")
                        query += " AND Experience >= 10";
                }

                // ================= FEE FILTER =================
                if (cmbFee.SelectedItem != null &&
                    cmbFee.SelectedItem.ToString() != "Any")
                {
                    string fee = cmbFee.SelectedItem.ToString();

                    if (fee == "Below 1000")
                        query += " AND HourlyFee < 1000";
                    else if (fee == "1000 - 3000")
                        query += " AND HourlyFee BETWEEN 1000 AND 3000";
                    else if (fee == "3000 - 5000")
                        query += " AND HourlyFee BETWEEN 3000 AND 5000";
                    else if (fee == "Above 5000")
                        query += " AND HourlyFee > 5000";
                }

                cmd.CommandText = query;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvLawyers.DataSource = dt;
            }
        }

        // ================= HIRE =================
        private void btnHire_Click_1(object sender, EventArgs e)
        {
            if (dgvLawyers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a lawyer first.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string checkQuery = @"
                SELECT COUNT(*) 
                FROM Cases 
                WHERE ClientUserId = @client
                AND Status IN ('Pending', 'Accepted')";

                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@client", userId);

                int activeCases = (int)checkCmd.ExecuteScalar();

                if (activeCases > 0)
                {
                    MessageBox.Show("You already have a Pending or Accepted case.");
                    return;
                }

                int lawyerUserId =
                    Convert.ToInt32(dgvLawyers.SelectedRows[0].Cells["UserId"].Value);

                string insertQuery = @"
                INSERT INTO Cases (ClientUserId, LawyerUserId, Status)
                VALUES (@client, @lawyer, 'Pending')";

                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@client", userId);
                cmd.Parameters.AddWithValue("@lawyer", lawyerUserId);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Case created!");
                LoadMyCases();
            }
        }

        // ================= RATING SYSTEM =================


        // ================= TIMER =================
        private void StatusTimer_Tick(object sender, EventArgs e)
        {
            DataTable current = GetAllCases();

            if (previousState.Rows.Count == 0)
            {
                previousState = current;
                return;
            }

            foreach (DataRow newRow in current.Rows)
            {
                int caseId = Convert.ToInt32(newRow["CaseId"]);
                string newStatus = newRow["Status"].ToString();

                DataRow[] oldRows = previousState.Select($"CaseId = {caseId}");

                if (oldRows.Length > 0)
                {
                    string oldStatus = oldRows[0]["Status"].ToString();

                    if (oldStatus != newStatus)
                    {
                        ShowFloatingPopup(caseId, newStatus);
                    }
                }
            }

            previousState = current;
        }

        private DataTable GetAllCases()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"
                SELECT CaseId, Status 
                FROM Cases 
                WHERE ClientUserId = @id";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@id", userId);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        private void ShowFloatingPopup(int caseId, string status)
        {
            Form popup = new Form();
            popup.Width = 260;
            popup.Height = 80;
            popup.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            popup.StartPosition = FormStartPosition.Manual;
            popup.TopMost = true;
            popup.BackColor = Color.Black;

            popup.Location = new Point(
                Screen.PrimaryScreen.WorkingArea.Width - 270,
                Screen.PrimaryScreen.WorkingArea.Height - 100
            );

            Label lbl = new Label();
            lbl.Text = $"Case #{caseId} is now {status}";
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.ForeColor = Color.White;

            popup.Controls.Add(lbl);
            popup.Show();

            System.Windows.Forms.Timer closeTimer = new System.Windows.Forms.Timer();
            closeTimer.Interval = 3000;
            closeTimer.Tick += (s, e) =>
            {
                popup.Close();
                closeTimer.Stop();
            };
            closeTimer.Start();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Hide();
        }

        private void btnSubmitRating_Click(object sender, EventArgs e)
        {
            if (dgvCompletedCases.CurrentRow == null)
            {
                MessageBox.Show("Select a completed case.");
                return;
            }

            if (cmbRating.SelectedItem == null)
            {
                MessageBox.Show("Select rating (1-5).");
                return;
            }

            int caseId = Convert.ToInt32(
                dgvCompletedCases.CurrentRow.Cells["CaseId"].Value
            );

            int lawyerId = Convert.ToInt32(
                dgvCompletedCases.CurrentRow.Cells["LawyerUserId"].Value
            );

            int rating = Convert.ToInt32(cmbRating.SelectedItem);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // 🔥 CHECK IF THIS CASE ALREADY USED FOR RATING
                string checkQuery = @"
        SELECT COUNT(*) 
        FROM Cases 
        WHERE CaseId = @caseId 
        AND ClientUserId = @clientId
        AND Status = 'Completed'";

                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@caseId", caseId);
                checkCmd.Parameters.AddWithValue("@clientId", userId);

                int exists = (int)checkCmd.ExecuteScalar();

                if (exists == 0)
                {
                    MessageBox.Show("Invalid case.");
                    return;
                }

                // 🔥 STEP 2: UPDATE LAWYER RATING
                string updateQuery = @"
        UPDATE LawyerProfiles
        SET Rating = 
            CASE 
                WHEN Rating IS NULL THEN @rating
                ELSE (Rating + @rating) / 2
            END
        WHERE UserId = @id";

                SqlCommand cmd = new SqlCommand(updateQuery, con);
                cmd.Parameters.AddWithValue("@rating", rating);
                cmd.Parameters.AddWithValue("@id", lawyerId);
                cmd.ExecuteNonQuery();

                // 🔥 STEP 3: DELETE FROM GRID LOGIC (NOT DB STATUS)
                string deleteQuery = @"
        DELETE FROM Cases
        WHERE CaseId = @caseId
        AND ClientUserId = @clientId
        AND Status = 'Completed'";

                SqlCommand delCmd = new SqlCommand(deleteQuery, con);
                delCmd.Parameters.AddWithValue("@caseId", caseId);
                delCmd.Parameters.AddWithValue("@clientId", userId);

                delCmd.ExecuteNonQuery();
            }

            MessageBox.Show("Rating submitted successfully!");

            LoadCompletedCases();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }

}