using System;
using System.Collections.Generic;

namespace duckling_days.MODEL;

public partial class TbPhoto
{
    public int IdPhoto { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime DtDay { get; set; }
}
