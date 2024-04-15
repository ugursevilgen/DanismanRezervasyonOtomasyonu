using DanismanRezervasyonOtomasyonu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanismanRezervasyonOtomasyonu.DAL
{
    internal class UserDAL
    {
        public static int DanisanId;
        private readonly RezervasyonSistemiContext context;

        public UserDAL()
        {
            context = new RezervasyonSistemiContext();
        }

        internal int GirisKontrol(string email, string sifre)
        {
            //AdminKontrolü
            if (email == "ugursevilgen@gmail.com")
            {
                Yonetici yonetici = context.Yoneticis.Where(i => i.Email == email && i.Password == sifre).FirstOrDefault();

                if (yonetici != null)
                {
                    //Admin Panel
                    return 100;
                }
                else
                {
                    return 101; //Yönetici Şifre Hatası
                }
            }
            else
            {
                Danisan danisan = context.Danisans.Where(i => i.Email == email && i.Password == sifre).FirstOrDefault();

                if (danisan != null)
                {
                    DanisanId = danisan.Id;
                    
                    return 200;//Giriş Başarılı
                }
                else
                {
                    return 201;//Email veya Şifre hatalı
                }
            }

        }
    }
}
