using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Agro_Projek.Controller
{
    internal class DashboardController
    {
        private string connDb = "Host=localhost;Username=postgres;Password=1;Database=Agromart";

        public int produkTotal()
        {
            int totalProduk = 0;
            string query = "SELECT COUNT(*) FROM produk";

            using (NpgsqlConnection conn = new NpgsqlConnection(connDb))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        object hasil = cmd.ExecuteScalar();
                        if (hasil != DBNull.Value && hasil != null)
                        {
                            totalProduk = 0;
                        }else
                        {
                            totalProduk = Convert.ToInt32(hasil);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return produkTotal();

        }
    }
}
