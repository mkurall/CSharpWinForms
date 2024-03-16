using System;
using System.Collections.Generic;

namespace EFTest.Modeller;

public partial class TblKullanicilar
{
    public int Id { get; set; }

    public string Ad { get; set; } = null!;

    public string Soyad { get; set; } = null!;

    public string Eposta { get; set; } = null!;

    public string Parola { get; set; } = null!;
}
