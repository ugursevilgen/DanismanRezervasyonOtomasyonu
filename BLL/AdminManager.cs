using DanismanRezervasyonOtomasyonu.DAL;
using DanismanRezervasyonOtomasyonu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanismanRezervasyonOtomasyonu.BLL
{
    internal class AdminManager
    {

        AdminDAL adminDAL;

        public AdminManager()
        {
            adminDAL = new AdminDAL();
        }

        internal int DanisanEkle(string ad,string soyad,string yas,string adres, string telefon, string email,string password,string test_MoCA,string test_MMSE,string test_GDS)
        {
            Danisan danisan = new Danisan()
            {
                Ad = ad,
                Soyad = soyad,
                Yas = yas,
                Adres = adres,
                Telefon = telefon,
                Email = email,
                Password = password,
                TestGds = test_GDS,
                TestMmse = test_MMSE,
                TestMoCa = test_MoCA,


            };

           return  adminDAL.DanisanEkle(danisan);
        }

        internal List<Danisan> DanisanListele()
        {
            return adminDAL.DanisanListele();
        }
    }
}
