using System;
using System.Collections.Generic;

namespace duckling_days.MODEL;

public partial class TbUser
{
    public int IdUser { get; set; }

    public string User { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime? DtBirth { get; set; }
}
