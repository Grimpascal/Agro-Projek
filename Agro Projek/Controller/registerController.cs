using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Agro_Projek.Controller
{
    internal class registerController
    {
        private string db = "Host=localhost;Username=postgres;Password=1;Database=Agromart";

        public bool cekUser(string username)
        {
            string queryCheck = "SELECT COUNT(*) FROM users WHERE username = @username";

            using (NpgsqlConnection conn = new NpgsqlConnection(db))
            {
                try
                {
                    conn.Open();

                    using (NpgsqlCommand check = new NpgsqlCommand(queryCheck, conn))
                    {
                        check.Parameters.AddWithValue("@username", username);
                        int checkUser = Convert.ToInt32(check.ExecuteScalar());
                        return checkUser > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    return false;
                }
            }
        }
        public bool RegisterUser(string username, string password, string no_telepon)
        {
            string queryRegis = "INSERT INTO users (username, password, no_telepon) VALUES (@username, @password, @no_telepon)";

            using (NpgsqlConnection conn = new NpgsqlConnection(db))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(queryRegis, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@no_telepon", no_telepon);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    return false;
                }
            }
        }
    }
}
