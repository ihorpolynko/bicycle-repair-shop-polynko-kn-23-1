using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace program_bicycle_repair_shop_polynko_kn_23_1
{
    public static class UserAuth
    {
        public static string ConnectionString { get; set; }

        public static Users Authenticate(string username, string password)
        {
            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT login, password, role FROM users WHERE login = @login AND password = @password LIMIT 1";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@login", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Users
                            {
                                login = reader.GetString("login"),
                                password = reader.GetString("password"),
                                role = reader.GetString("role")
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}