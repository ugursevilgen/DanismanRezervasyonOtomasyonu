using System;
using System.Collections.Generic;

namespace DanismanRezervasyonOtomasyonu.Models;

public partial class Yonetici
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;
}
