using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Text;
using GymManagementSystemRivas.models;
using GymManagementSystemRivas;
using System.Linq.Expressions;

namespace GymManagementSystemRivas.repositories
{
    public class adminRepository
    {
        public List<admin> GetAdmins()
        {
            var admins = new List<admin>();
            try
            {
                string connectionString = GymManagementSystemRivas.config.connectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "SELECT * FROM admin_tbl ORDER BY admin_id DESC";
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                admin admin = new admin();
                                admin.admin_id = reader.GetInt32("admin_id");
                                admin.admin_fname = reader.GetString("fname");
                                admin.admin_lname = reader.GetString("lname");
                                admin.admin_email = reader.GetString("email");
                                admin.admin_role = reader.GetString("role");
                                admin.admin_password = reader.GetString("password");
                                admins.Add(admin);


                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return admins;
        }

        public admin? GetAdmin(int admin_id)
        {
            admin? foundAdmin = null;
            try
            {
                string connectionString = GymManagementSystemRivas.config.connectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM admin_tbl where admin_id=@admin_id";
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@admin_id", admin_id);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                foundAdmin = new admin();
                                foundAdmin.admin_id = reader.GetInt32("admin_id");
                                foundAdmin.admin_fname = reader.GetString("fname");
                                foundAdmin.admin_lname = reader.GetString("lname");
                                foundAdmin.admin_email = reader.GetString("email");
                                foundAdmin.admin_role = reader.GetString("role");
                                foundAdmin.admin_password = reader.GetString("password");

                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }


            return foundAdmin;
        }

        public void createAdmin(admin admin)
        {
            try
            {
                string connectionString = GymManagementSystemRivas.config.connectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "Insert into admin_tbl (fname, lname, email, role, password) VALUES (@admin_fname, @admin_lname, @admin_email, @admin_role, @admin_password)";
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(admin.admin_password);
                        command.Parameters.AddWithValue("@admin_id", admin.admin_id);
                        command.Parameters.AddWithValue("@admin_fname", admin.admin_fname);
                        command.Parameters.AddWithValue("@admin_lname", admin.admin_lname);
                        command.Parameters.AddWithValue("@admin_email", admin.admin_email);
                        command.Parameters.AddWithValue("@admin_role", admin.admin_role);
                        command.Parameters.AddWithValue("@admin_password", hashedPassword);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

        public void updateAdmin(admin admin)
        {
            try
            {
                string connectionString = GymManagementSystemRivas.config.connectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    bool updatePassword = !string.IsNullOrWhiteSpace(admin.admin_password);
                    string sql = "UPDATE admin_tbl SET fname=@admin_fname, lname=@admin_lname, email=@admin_email, role=@admin_role";

                    if (updatePassword)
                    {
                        sql += ", password=@admin_password";
                    }

                    sql += " WHERE admin_id=@admin_id";
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(admin.admin_password);
                        command.Parameters.AddWithValue("@admin_fname", admin.admin_fname);
                        command.Parameters.AddWithValue("@admin_lname", admin.admin_lname);
                        command.Parameters.AddWithValue("@admin_email", admin.admin_email);
                        command.Parameters.AddWithValue("@admin_role", admin.admin_role);
                        command.Parameters.AddWithValue("@admin_password", hashedPassword);
                        command.Parameters.AddWithValue("@admin_id", admin.admin_id);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

        public void deleteAdmin(int admin_id)
        {
            try
            {
                string connectionString = GymManagementSystemRivas.config.connectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "DELETE FROM admin_tbl WHERE admin_id=@admin_id";
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@admin_id", admin_id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

        }
    }
}
