using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agro_Projek.Model;
using Npgsql;

namespace Agro_Projek.Controller
{
    internal class PenggunaController
    {
        public string connDb = "Host=localhost;Username=postgres;Password=1;Database=Agromart";

        public static List<Login> tampilPengguna()
        {
            string connDb2 = "Host=localhost;Username=postgres;Password=1;Database=Agromart";
            List<Login> listPengguna = new List<Login>();
            string query = "SELECT * FROM users WHERE role = 'user'";
            using (NpgsqlConnection conn = new NpgsqlConnection(connDb2))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Login pengguna = new Login
                                {
                                    user_id = reader.GetInt32(0),
                                    Username = reader.GetString(1),
                                    no_telepon = reader.GetString(2),
                                };
                                listPengguna.Add(pengguna);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ada error yang ditemukan : " + ex.Message);
                }
            }
            return listPengguna;
        }

        public void hapusPengguna(int userId)
        {
            string query = "DELETE FROM users WHERE user_id = @userId";
            using (NpgsqlConnection conn = new NpgsqlConnection(connDb))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ada error yang ditemukan : " + ex.Message);
                }
            }
        }

        public void tambah(string username, string password, string nomor)
        {
            string query = "INSERT INTO users (username, password, no_telepon, role) VALUES (@username, @password, @no_telepon, @role)";
            using (NpgsqlConnection conn = new NpgsqlConnection(connDb))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@no_telepon", nomor);
                        cmd.Parameters.AddWithValue("@role", "user");
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ada error yang ditemukan : " + ex.Message);
                }
            }
        }
    }
}

