using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agro_Projek.Model;

namespace Agro_Projek.Controller
{
    public interface IUserController
    {
        void tambah(string username, string password, string nomor);
        void hapusPengguna(int userId);
        void editPengguna(int userId, string username, string password, string noTelepon);
        List<Login> tampilPengguna();
    }
}
