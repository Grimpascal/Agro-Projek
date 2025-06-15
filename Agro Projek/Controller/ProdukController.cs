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
using Riwayat = Agro_Projek.Model.Riwayat;

namespace Agro_Projek.Controller
{
    internal class ProdukController
    {
        private string connDb = "Host=localhost;Username=postgres;Password=leon;Database=Agromart";

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

            using (var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=leon;Database=Agromart"))
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
                            listProduk.Add(produk);
                        }
                }
            }
            return listProduk;
        }

        public static List<Produk> ambilProduk()
        {
            var listProduk = new List<Produk>();
            using (var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=leon;Database=Agromart"))
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
                                id_produk = reader.GetInt32(0),
                                nama_produk = reader.GetString(1),
                                id_jenis_produk = reader.GetInt32(2),
                                harga = reader.GetInt32(3),
                                quantity = reader.GetInt32(4)
                            };
                            listProduk.Add(produk);
                        }
                }
            }
            return listProduk;
        }

        public void tambahStok(int idProduk)
        {
            string queryPlus = "UPDATE produk SET quantity = quantity + @jumlah WHERE id_produk = @id";
            using (var conn = new NpgsqlConnection(connDb))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(queryPlus, conn))
                {
                    cmd.Parameters.AddWithValue("@jumlah", 1);
                    cmd.Parameters.AddWithValue("@id", idProduk);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void keranjang(int userId, int idProduk, int Jumlah)
        {
            string query = "INSERT INTO keranjang (user_id, id_produk, jumlah) VALUES (@user_id, @id_produk, @jumlah)";
            using (var conn = new NpgsqlConnection(connDb))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user_id", userId);
                        cmd.Parameters.AddWithValue("@id_produk", idProduk);
                        cmd.Parameters.AddWithValue("@jumlah", Jumlah);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        public void riwayat(int userId, int produkId, int jumlah, int totalHarga)
        {
            string query = "INSERT INTO riwayat (user_id, id_produk, jumlah, total_harga) VALUES (@userId, @idProduk, @jumlah, @totalHarga)";
            using (var conn = new NpgsqlConnection(connDb))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@idProduk", produkId);
                        cmd.Parameters.AddWithValue("@jumlah", jumlah);
                        cmd.Parameters.AddWithValue("@totalHarga", totalHarga);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menyimpan riwayat: " + ex.Message);
                }
            }
        }

        public void kurangiStok(int idProduk, int jumlahDipesan)
        {
            int stokTersedia = cekStokProduk(idProduk);

            
            if (stokTersedia < jumlahDipesan)
            {
                MessageBox.Show($"Stok tidak mencukupi untuk jumlah yang diminta. Stok tersedia: {stokTersedia}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

           
            string query = "UPDATE produk SET quantity = quantity - @jumlah WHERE id_produk = @id";
            using (var conn = new NpgsqlConnection(connDb))
            {
                conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        using (var cmd = new NpgsqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@jumlah", jumlahDipesan);
                            cmd.Parameters.AddWithValue("@id", idProduk);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        MessageBox.Show("Pembayaran berhasil dilakukan dan stok produk telah diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Gagal mengurangi stok: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }









        public int cekStokProduk(int idProduk)
        {
            string query = "SELECT quantity FROM produk WHERE id_produk = @id_produk";
            using (var conn = new NpgsqlConnection(connDb))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_produk", idProduk);
                        int stok = Convert.ToInt32(cmd.ExecuteScalar());
                        Console.WriteLine($"Stok produk ID {idProduk}: {stok}"); 
                        return stok;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return 0;
                }
            }
        }


        public static List<Riwayat> cekRiwayat(int userId)
        {
            var listRiwayat = new List<Riwayat>();
            using (var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=leon;Database=Agromart"))
            {
                conn.Open();
                string query = @"
            SELECT 
                r.id_riwayat,
                p.nama_produk,
                r.jumlah,
                r.total_harga
            FROM riwayat r
            JOIN produk p ON p.id_produk = r.id_produk
            WHERE r.user_id = @user_id
        ";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user_id", userId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var riwayat = new Riwayat
                            {
                                id_riwayat = reader.GetInt32(0),
                                nama_produk = reader.GetString(1),
                                jumlah = reader.GetInt32(2),
                                total_harga = reader.GetInt32(3)
                            };
                            listRiwayat.Add(riwayat);
                        }
                    }
                }
            }
            return listRiwayat;
        }

    }
}
