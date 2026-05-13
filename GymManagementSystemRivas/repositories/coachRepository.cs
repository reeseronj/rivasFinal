using GymManagementSystemRivas.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagementSystemRivas.repositories
{
    internal class coachRepository
    {
        public List<Coach> GetCoach()
        {
            var coaches = new List<Coach>();
            try
            {
                string connectionString = GymManagementSystemRivas.config.connectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "SELECT * FROM coach_tbl ORDER BY coach_id DESC";
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Coach coach = new Coach();
                                coach.coach_id = reader.GetInt32("coach_id");
                                coach.coach_fname = reader.GetString("coach_fname");
                                coach.coach_lname = reader.GetString("coach_lname");
                                coach.email = reader.GetString("email");
                                coach.password = reader.GetString("password");
                                coaches.Add(coach);


                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
            return coaches;
        }

        public Coach? GetCoach(int coach_id)
        {
            Coach? foundCoach = null;
            try
            {
                string connectionString = GymManagementSystemRivas.config.connectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM coach_tbl WHERE coach_id=@coach_id";
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@coach_id", coach_id);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                foundCoach = new Coach();
                                foundCoach.coach_id = reader.GetInt32("coach_id");
                                foundCoach.coach_fname = reader.GetString("coach_fname");
                                foundCoach.coach_lname = reader.GetString("coach_lname");
                                foundCoach.email = reader.GetString("email");
                                foundCoach.password = reader.GetString("password");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
            return foundCoach;
        }

        public void createCoach(Coach coach)
        {
            try
            {
                string connectionString = GymManagementSystemRivas.config.connectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "INSERT INTO coach_tbl (coach_fname, coach_lname, email, password) VALUES (@coach_fname, @coach_lname, @email, @password)";
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(coach.password);
                        command.Parameters.AddWithValue("@coach_fname", coach.coach_fname);
                        command.Parameters.AddWithValue("@coach_lname", coach.coach_lname);
                        command.Parameters.AddWithValue("@email", coach.email);
                        command.Parameters.AddWithValue("@password", hashedPassword);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        public void updateCoach(Coach coach)
        {
            try
            {
                string connectionString = GymManagementSystemRivas.config.connectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    bool updatePassword = !string.IsNullOrWhiteSpace(coach.password);

                    string sql = "UPDATE coach_tbl SET coach_fname=@coach_fname, coach_lname=@coach_lname, email=@email";
                    if (updatePassword)
                    {
                        sql += ", password=@password";
                    }
                    sql += " WHERE coach_id=@coach_id";

                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@coach_fname", coach.coach_fname);
                        command.Parameters.AddWithValue("@coach_lname", coach.coach_lname);
                        command.Parameters.AddWithValue("@email", coach.email);
                        command.Parameters.AddWithValue("@coach_id", coach.coach_id);

                        if (updatePassword)
                        {
                            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(coach.password);
                            command.Parameters.AddWithValue("@password", hashedPassword);
                        }

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        public void deleteCoach(int coach_id)
        {
            try
            {
                string connectionString = GymManagementSystemRivas.config.connectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "DELETE FROM coach_tbl WHERE coach_id=@coach_id";
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@coach_id", coach_id);
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
