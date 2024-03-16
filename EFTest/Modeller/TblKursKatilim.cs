using System;
using System.Collections.Generic;

namespace EFTest.Modeller;

public partial class TblKursKatilim
{
    public int Id { get; set; }

    public int KursId { get; set; }

    public int KursiyerId { get; set; }

    public virtual TblKurslar Kurs { get; set; } = null!;

    public virtual TblKursiyerler Kursiyer { get; set; } = null!;
}
