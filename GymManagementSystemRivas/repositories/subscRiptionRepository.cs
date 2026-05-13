using GymManagementSystemRivas.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagementSystemRivas.repositories
{
    internal class subscriptionRepository
    {
        public List<Subscription> GetSubscriptions()
        {
            var subscriptions = new List<Subscription>();
            try
            {
                string connectionString = GymManagementSystemRivas.config.connectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM subscription_tbl ORDER BY subscription_id DESC";
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Subscription sub = new Subscription();
                                sub.subscription_id = reader.GetInt32("subscription_id");
                                sub.plan = reader.GetString("plan");
                                sub.duration = reader.GetInt32("duration");
                                sub.price = reader.GetInt32("price");
                                subscriptions.Add(sub);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
            return subscriptions;
        }

        public Subscription? GetSubscription(int subscription_id)
        {
            Subscription? foundSub = null;
            try
            {
                string connectionString = GymManagementSystemRivas.config.connectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM subscription_tbl WHERE subscription_id=@subscription_id";
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@subscription_id", subscription_id);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                foundSub = new Subscription();
                                foundSub.subscription_id = reader.GetInt32("subscription_id");
                                foundSub.plan = reader.GetString("plan");
                                foundSub.duration = reader.GetInt32("duration");
                                foundSub.price = reader.GetInt32("price");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
            return foundSub;
        }

        public void createSubscription(Subscription sub)
        {
            try
            {
                string connectionString = GymManagementSystemRivas.config.connectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "INSERT INTO subscription_tbl (plan, duration, price) VALUES (@plan, @duration, @price)";
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@plan", sub.plan);
                        command.Parameters.AddWithValue("@duration", sub.duration);
                        command.Parameters.AddWithValue("@price", sub.price);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        public void updateSubscription(Subscription sub)
        {
            try
            {
                string connectionString = GymManagementSystemRivas.config.connectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "UPDATE subscription_tbl SET plan=@plan, duration=@duration, price=@price WHERE subscription_id=@subscription_id";
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@plan", sub.plan);
                        command.Parameters.AddWithValue("@duration", sub.duration);
                        command.Parameters.AddWithValue("@price", sub.price);
                        command.Parameters.AddWithValue("@subscription_id", sub.subscription_id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        public void deleteSubscription(int subscription_id)
        {
            try
            {
                string connectionString = GymManagementSystemRivas.config.connectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "DELETE FROM subscription_tbl WHERE subscription_id=@subscription_id";
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@subscription_id", subscription_id);
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
