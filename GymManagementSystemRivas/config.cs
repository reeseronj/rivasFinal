using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace GymManagementSystemRivas
{
    internal class config
    {
        public static string connectionString = "server=127.0.0.1;uid=root;pwd=NewPassword123!;database=gymRivas";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static string GetUserRole(string email, string password)
        {
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();

                    // 1. Check admin_tbl
                    string adminQuery = "SELECT COUNT(*) FROM admin_tbl WHERE email = @email AND password = @pass";
                    using (MySqlCommand cmd = new MySqlCommand(adminQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@pass", password);
                        if (Convert.ToInt32(cmd.ExecuteScalar()) > 0) return "Admin";
                    }

                    // 2. Check coach_tbl
                    string coachQuery = "SELECT COUNT(*) FROM coach_tbl WHERE email = @email AND password = @pass";
                    using (MySqlCommand cmd = new MySqlCommand(coachQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@pass", password);
                        if (Convert.ToInt32(cmd.ExecuteScalar()) > 0) return "Coach";
                    }

                    // 3. Check member_tbl
                    string memberQuery = "SELECT COUNT(*) FROM member_tbl WHERE email = @email AND password = @pass";
                    using (MySqlCommand cmd = new MySqlCommand(memberQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@pass", password);
                        if (Convert.ToInt32(cmd.ExecuteScalar()) > 0) return "Member";
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Database Error: " + ex.Message);
                }
            }
            return "None";
        }
    }
}
