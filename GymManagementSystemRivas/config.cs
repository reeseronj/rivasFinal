using MySql.Data.MySqlClient;
using BCrypt.Net;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.Text;

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

        public static bool IsEmailDuplicate(string email)
        {
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();

                    // We use UNION to check all three tables in a single query for efficiency
                    string query = @"
                SELECT email FROM admin_tbl WHERE email = @email
                UNION
                SELECT email FROM coach_tbl WHERE email = @email
                UNION
                SELECT email FROM member_tbl WHERE email = @email";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            return reader.HasRows;
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Validation Error: " + ex.Message);
                    return true;
                }
            }
        }

        public static bool RegisterUser(string role, string fname, string lname, string email, string password)
        {
            string tableName = (role == "Coach") ? "coach_tbl" : "member_tbl";

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();

                    // 2. Insert with simplified column names and 'inactive' status
                    string query = $"INSERT INTO {tableName} (fname, lname, email, password, status) " +
                                   $"VALUES (@fname, @lname, @email, @pass, 'inactive')";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@fname", fname);
                        cmd.Parameters.AddWithValue("@lname", lname);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@pass", hashedPassword);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Registration Error: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
