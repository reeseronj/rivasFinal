using GymManagementSystemRivas.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagementSystemRivas.repositories
{
    internal class equipmentRepository
    {
        public class equipRepository
        {
            public List<Equipment> GetEquipments()
            {
                var equipments = new List<Equipment>();
                try
                {
                    string connectionString = GymManagementSystemRivas.config.connectionString;
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string sql = "SELECT * FROM equipment_tbl ORDER BY equip_id DESC";
                        using (MySqlCommand command = new MySqlCommand(sql, conn))
                        {
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Equipment equipment = new Equipment();
                                    equipment.equip_id = reader.GetInt32("equip_id");
                                    equipment.name = reader.GetString("name");
                                    equipment.quantity = reader.GetInt32("quantity");
                                    equipment.status = reader.GetString("status");
                                    equipments.Add(equipment);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
                return equipments;
            }

            public Equipment? GetEquipment(int equip_id)
            {
                Equipment? foundEquipment = null;
                try
                {
                    string connectionString = GymManagementSystemRivas.config.connectionString;
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string sql = "SELECT * FROM equipment_tbl WHERE equip_id=@equip_id";
                        using (MySqlCommand command = new MySqlCommand(sql, conn))
                        {
                            command.Parameters.AddWithValue("@equip_id", equip_id);
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    foundEquipment = new Equipment();
                                    foundEquipment.equip_id = reader.GetInt32("equip_id");
                                    foundEquipment.name = reader.GetString("name");
                                    foundEquipment.quantity = reader.GetInt32("quantity");
                                    foundEquipment.status = reader.GetString("status");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
                return foundEquipment;
            }

            public void createEquipment(Equipment equipment)
            {
                try
                {
                    string connectionString = GymManagementSystemRivas.config.connectionString;
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string sql = "INSERT INTO equipment_tbl (name, quantity, status) VALUES (@name, @quantity, @status)";
                        using (MySqlCommand command = new MySqlCommand(sql, conn))
                        {
                            command.Parameters.AddWithValue("@name", equipment.name);
                            command.Parameters.AddWithValue("@quantity", equipment.quantity);
                            command.Parameters.AddWithValue("@status", equipment.status);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }

            public void updateEquipment(Equipment equipment)
            {
                try
                {
                    string connectionString = GymManagementSystemRivas.config.connectionString;
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string sql = "UPDATE equipment_tbl SET name=@name, quantity=@quantity, status=@status WHERE equip_id=@equip_id";
                        using (MySqlCommand command = new MySqlCommand(sql, conn))
                        {
                            command.Parameters.AddWithValue("@name", equipment.name);
                            command.Parameters.AddWithValue("@quantity", equipment.quantity);
                            command.Parameters.AddWithValue("@status", equipment.status);
                            command.Parameters.AddWithValue("@equip_id", equipment.equip_id);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }

            public void deleteEquipment(int equip_id)
            {
                try
                {
                    string connectionString = GymManagementSystemRivas.config.connectionString;
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string sql = "DELETE FROM equipment_tbl WHERE equip_id=@equip_id";
                        using (MySqlCommand command = new MySqlCommand(sql, conn))
                        {
                            command.Parameters.AddWithValue("@equip_id", equip_id);
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
}
