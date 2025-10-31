using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindFormPraktikum9.Models
{
    public class RegisterContext
    {
        private readonly NpgsqlConnection conn;

        public RegisterContext()
        {
            string env = Environment.GetEnvironmentVariable("CONNECTION_STRING")!;
            conn = new NpgsqlConnection(env);
            conn.Open();
        }

        public bool Register(User user)
        {
            string query = $"INSERT INTO users(username, password) VALUES(@username, @password)";
            using (var cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
