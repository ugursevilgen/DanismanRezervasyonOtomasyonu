using System;
using System.Collections.Generic;

namespace DanismanRezervasyonOtomasyonu.Models;

public partial class Danisman
{
    public int Id { get; set; }

    public string Ad { get; set; } = null!;

    public string Soyad { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Telefon { get; set; } = null!;

    public string Password { get; set; } = null!;
}
