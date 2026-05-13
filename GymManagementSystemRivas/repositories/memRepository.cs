using GymManagementSystemRivas.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagementSystemRivas.repositories
{
    internal class memRepository
    {
        public List<Member> GetMembers()
        {
            var members = new List<Member>();
            try
            {
                string connectionString = GymManagementSystemRivas.config.connectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "SELECT * FROM member_tbl ORDER BY member_id DESC";
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Member member = new Member();
                                member.mem_id = reader.GetInt32("member_id");
                                member.mem_fname = reader.GetString("mem_fname");
                                member.mem_lname = reader.GetString("mem_lname");
                                member.mem_email = reader.GetString("email");
                                member.mem_password = reader.GetString("password");
                                members.Add(member);


                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return members;
        }

        public Member? GetMember(int member_id)
        {
            Member? foundMember = null;
            try
            {
                string connectionString = GymManagementSystemRivas.config.connectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM member_tbl where member_id=@member_id";
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@member_id", member_id);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                foundMember = new Member();
                                foundMember.mem_id = reader.GetInt32("member_id");
                                foundMember.mem_fname = reader.GetString("mem_fname");
                                foundMember.mem_lname = reader.GetString("mem_lname");
                                foundMember.mem_email = reader.GetString("email");
                                foundMember.mem_password = reader.GetString("password");

                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }


            return foundMember;
        }

        public void createMember(Member member)
        {
            try
            {
                string connectionString = GymManagementSystemRivas.config.connectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "Insert into member_tbl (mem_fname, mem_lname, email, password) VALUES (@mem_fname, @mem_lname, @mem_email, @mem_password)";
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(member.mem_password);
                        command.Parameters.AddWithValue("@mem_fname", member.mem_fname);
                        command.Parameters.AddWithValue("@mem_lname", member.mem_lname);
                        command.Parameters.AddWithValue("@mem_email", member.mem_email);
                        command.Parameters.AddWithValue("@mem_password", hashedPassword);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        public void updateMember(Member member)
        {
            try
            {
                string connectionString = GymManagementSystemRivas.config.connectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    bool updatePassword = !string.IsNullOrWhiteSpace(member.mem_password);
                    string sql = "UPDATE member_tbl SET mem_fname=@mem_fname, mem_lname=@mem_lname, email=@mem_email";

                    if (updatePassword)
                    {
                        sql += ", password=@mem_password";
                    }

                    sql += " WHERE member_id=@mem_id";
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(member.mem_password);
                        command.Parameters.AddWithValue("@mem_fname", member.mem_fname);
                        command.Parameters.AddWithValue("@mem_lname", member.mem_lname);
                        command.Parameters.AddWithValue("@mem_email", member.mem_email);
                        command.Parameters.AddWithValue("@mem_password", hashedPassword);
                        command.Parameters.AddWithValue("@mem_id", member.mem_id);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        public void deleteMember(int mem_id)
        {
            try
            {
                string connectionString = GymManagementSystemRivas.config.connectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "DELETE FROM member_tbl WHERE member_id=@mem_id";
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@mem_id", mem_id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }

        }
    }
}
