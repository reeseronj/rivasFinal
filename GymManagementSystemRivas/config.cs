using BCrypt.Net;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GymManagementSystemRivas
{
    internal class config
    {
        public static string connectionString = "server=192.168.0.101;uid=root;pwd=NewPassword123!;database=gymRivas";

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
                    string adminQuery = "SELECT password FROM admin_tbl WHERE email = @email";
                    using (MySqlCommand cmd = new MySqlCommand(adminQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        object result = cmd.ExecuteScalar();
                        if (result != null && BCrypt.Net.BCrypt.Verify(password, result.ToString()))
                        {
                            return "Admin";
                        }
                    }

                    // 2. Check coach_tbl
                    string coachQuery = "SELECT password FROM coach_tbl WHERE email = @email";
                    using (MySqlCommand cmd = new MySqlCommand(coachQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        object result = cmd.ExecuteScalar();
                        if (result != null && BCrypt.Net.BCrypt.Verify(password, result.ToString()))
                        {
                            return "Coach";
                        }
                    }

                    // 3. Check member_tbl
                    string memberQuery = "SELECT password FROM member_tbl WHERE email = @email";
                    using (MySqlCommand cmd = new MySqlCommand(memberQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        object result = cmd.ExecuteScalar();
                        if (result != null && BCrypt.Net.BCrypt.Verify(password, result.ToString()))
                        {
                            return "Member";
                        }
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

        public static bool RegisterAdmin(string fname, string lname, string email, string role, string password)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO admin_tbl (fname, lname, email, role, password) " +
                                   "VALUES (@fname, @lname, @email, @role, @pass)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@fname", fname);
                        cmd.Parameters.AddWithValue("@lname", lname);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.Parameters.AddWithValue("@pass", hashedPassword);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Admin Registration Error: " + ex.Message);
                    return false;
                }
            }
        }
        public static DataRow GetAdminById(string id)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = GetConnection())
            {
                string query = "SELECT * FROM admin_tbl WHERE admin_id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }
        private static void EditAdmin(string id)
        {
            // 1. Fetch the specific admin data using the ID
            // You'll need a function like GetAdminById(id) that returns a DataRow or Object
            DataRow adminData = GetAdminById(id);

            if (adminData != null)
            {
                // 2. Initialize your form
                addEditStaff editForm = new addEditStaff();

                // 3. Fill the form's fields with the credentials
                editForm.txtFname.Text = adminData["fname"].ToString();
                editForm.txtLname.Text = adminData["lname"].ToString();
                editForm.txtEmail.Text = adminData["email"].ToString();

                // Use a Tag or a public property to tell the form it's in "Edit Mode"
                editForm.Tag = id;
                editForm.btnSave.Text = "Update Staff"; // Change button text to reflect action

                // 4. Show the form
                editForm.ShowDialog();
            }
        }

    }
}
