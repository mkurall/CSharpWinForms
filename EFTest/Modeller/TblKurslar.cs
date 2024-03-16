using System;
using System.Collections.Generic;

namespace EFTest.Modeller;

public partial class TblKurslar
{
    public int Id { get; set; }

    public string KursAdi { get; set; } = null!;

    public DateTime KursTarihi { get; set; }

    public string? EgitmenBilgisi { get; set; }

    public virtual ICollection<TblKursKatilim> TblKursKatilims { get; set; } = new List<TblKursKatilim>();
}
