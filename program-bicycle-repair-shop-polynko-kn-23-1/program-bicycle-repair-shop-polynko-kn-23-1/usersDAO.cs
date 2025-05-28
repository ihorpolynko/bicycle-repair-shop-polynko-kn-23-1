using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;

namespace program_bicycle_repair_shop_polynko_kn_23_1
{
    public class usersDAO
    {
        public List<Users> users = new List<Users>();

        public List<Users> getALLUsers()
        {
            List<Users> users = new List<Users>();
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand("select * from users;", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Users u = new Users
                    {
                        user_id = reader.GetInt32(0),
                        login = reader.GetString(1),
                        password = reader.GetString(2),
                        role = reader.GetString(3)
                    };
                    users.Add(u);
                }
            }
            connection.Close();
            return users;
        }

        internal int addUser(Users user)
        {
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "insert into users (login, password, role) values(@login, @password, @role);";
            command.Parameters.AddWithValue("@login", user.login);
            command.Parameters.AddWithValue("@password", user.password);
            command.Parameters.AddWithValue("@role", user.role);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        internal int deleteUser(Users user)
        {
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "delete from users where (user_id = @user_id);";
            command.Parameters.AddWithValue("@user_id", user.user_id);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        internal int updateUser(Users user)
        {
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "update users set login = @login, password = @password, role = @role WHERE (user_id = @user_id);";
            command.Parameters.AddWithValue("@user_id", user.user_id);
            command.Parameters.AddWithValue("@login", user.login);
            command.Parameters.AddWithValue("@password", user.password);
            command.Parameters.AddWithValue("@role", user.role);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public List<Users> getSearchUsers(Users user)
        {
            List<Users> users = new List<Users>();
            MySqlConnection connection = new MySqlConnection(DBConfig.LoadConfig());
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select * from users where role = @role;";
            command.Parameters.AddWithValue("@role", user.role);
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Users u = new Users
                    {
                        user_id = reader.GetInt32(0),
                        login = reader.GetString(1),
                        password = reader.GetString(2),
                        role = reader.GetString(3)
                    };
                    users.Add(u);
                }
            }
            connection.Close();
            return users;
        }
    }
}