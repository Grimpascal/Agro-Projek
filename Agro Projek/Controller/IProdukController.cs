using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agro_Projek.Model;

namespace Agro_Projek.Controller
{
    public interface IProdukController
    {
        void tambah(string nama, int id_jenis, int harga, int quantity);
        bool cekNamaProduk(string namaProduk);
        List<Produk> ambilProduk();
        void tambahStok(int idProduk);
        void kurangStokProduk(int idProduk);
        void kurangiStok(int idProduk, int jumlahDipesan);
    }
}
