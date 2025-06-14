using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro_Projek.Model
{
    internal class Pembayaran
    {
        public int id_metode_pembayaran { get; set; }
        public string nama_metode_pembayaran { get; set; }
        public int id_jenis_metode_pembayaran { get; set; }
    }
}
