using System;
using System.Collections.Generic;

namespace DanismanRezervasyonOtomasyonu.Models;

public partial class Rezervasyon
{
    public int Id { get; set; }

    public int DanisanId { get; set; }

    public int DanismanId { get; set; }

    public DateOnly? RezervasyonBaslama { get; set; }

    public DateOnly? RezervasyonBitis { get; set; }

    public decimal? Odeme { get; set; }

    public int? GunSayisi { get; set; }
}
