using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanismanRezervasyonOtomasyonu.Entities
{
    internal class Hata
    {
        public static SortedList<int, string> Hatalar = new SortedList<int, string>()
        {
            {100,"Yönetici Giriş Başarılı"},
            {101,"Yönetici Şifre Hatası"},
            {200,"Danışan Giriş Başarılı"},
            {201,"Danışan Giriş Bilgileri Hatalı"},
            {202,"Alanlar Boş Geçilemez"},
            {203,"Danışan Ekleme Başarılı"},
            {204,"Aynı Email Kayıtlı"},
            {205,"Aynı TC Kayıtlı"},
            {206,"Aynı Telefon Numarası Kayıtlı"},
            
        };
    }
}
