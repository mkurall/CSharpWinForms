using System;
using System.Collections.Generic;

namespace EFTest.Modeller;

public partial class TblKursiyerler
{
    public int Id { get; set; }

    public string TcKimlikNo { get; set; } = null!;

    public string Ad { get; set; } = null!;

    public string Soyad { get; set; } = null!;

    public byte? Cinsiyet { get; set; }

    public string Eposta { get; set; } = null!;

    public virtual ICollection<TblKursKatilim> TblKursKatilims { get; set; } = new List<TblKursKatilim>();
}
