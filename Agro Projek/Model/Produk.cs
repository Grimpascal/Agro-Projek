using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro_Projek.Model
{
    public class Produk
    {
        public int id_produk { get; set; }
        public string nama_produk { get; set; }
        public int id_jenis_produk { get; set; }
        public int harga { get; set; }
        public int quantity { get; set; }
    }
}
