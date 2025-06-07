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
            string query = "SELECT * FROM users";
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
    }
}

