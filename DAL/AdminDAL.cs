using DanismanRezervasyonOtomasyonu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanismanRezervasyonOtomasyonu.DAL
{
    internal class AdminDAL
    {
        private readonly RezervasyonSistemiContext context;
        public AdminDAL()
        {
            context = new RezervasyonSistemiContext();
        }

        internal int DanisanEkle(Danisan danisan)
        {
            context.Danisans.Add(danisan);
            context.SaveChanges();

            return 300;
        }

        internal List<Danisan> DanisanListele()
        {
            return context.Danisans.ToList();
        }
    }
}