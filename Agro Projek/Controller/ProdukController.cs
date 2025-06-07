using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Agro_Projek.Model;
using Agro_Projek.View;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Agro_Projek.Controller
{
    internal class ProdukController
    {
        private string connDb = "Host=localhost;Username=postgres;Password=1;Database=Agromart";

        public void tambah(string nama, int id_jenis, int harga, int quantity)
        {
            string query = "INSERT INTO produk (nama_produk, id_jenis_produk, harga, quantity) VALUES (@nama, @id_jenis, @harga, @quantity)";

            using (NpgsqlConnection conn = new NpgsqlConnection(connDb))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@id_jenis", id_jenis);
                        cmd.Parameters.AddWithValue("@harga", harga);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        public bool cekNamaProduk(string namaProduk)
        {
            string query = "SELECT COUNT(*) FROM produk WHERE nama_produk = @nama_produk";
            using (NpgsqlConnection conn = new NpgsqlConnection(connDb))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama_produk", namaProduk);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ada error yang ditemukan : " + ex.Message);
                    return false;
                }
            }
        }

        public static List<Produk> TampilanProduk()
        {
            var listProduk = new List<Produk>();

            using (var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=1;Database=Agromart"))
            {
                conn.Open();
                string query = "SELECT * FROM produk";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            var produk = new Produk
                            {
                                nama_produk = reader.GetString(1),
                                harga = reader.GetInt32(3),
                            };
                        }
                }
            }
            return listProduk;
        }

    }
}
