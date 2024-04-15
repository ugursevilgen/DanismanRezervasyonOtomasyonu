using System;
using System.Collections.Generic;

namespace DanismanRezervasyonOtomasyonu.Models;

public partial class Danisan
{
    public int Id { get; set; }

    public string Ad { get; set; } = null!;

    public string Soyad { get; set; } = null!;

    public string Yas { get; set; }

    public string Adres { get; set; } = null!;

    public string Telefon { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? TestMoCa { get; set; }

    public string? TestMmse { get; set; }

    public string? TestGds { get; set; }
}
