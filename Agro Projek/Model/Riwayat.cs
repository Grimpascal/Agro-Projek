using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro_Projek.Model
{
    public class Riwayat
    {
        public int id_riwayat { get; set; }
        public int user_id { get; set; }

        public string nama_produk { get; set; }
        public int jumlah { get; set; }
        public int total_harga { get; set; }
    }
}
