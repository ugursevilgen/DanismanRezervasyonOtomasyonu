using DanismanRezervasyonOtomasyonu.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanismanRezervasyonOtomasyonu.BLL
{
    internal class UserManager
    {
        UserDAL userDAL;
        public UserManager()
        {
            userDAL = new UserDAL();
        }

        internal int GirisKontrol(string email, string sifre)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(sifre))
            {
                return 202;
            }
            return userDAL.GirisKontrol(email, sifre);
        }

    }
}
