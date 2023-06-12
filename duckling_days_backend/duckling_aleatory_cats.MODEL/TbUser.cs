using System;
using System.Collections.Generic;

namespace duckling_aleatory_cats.MODEL;

public partial class TbUser
{
    public int IdUser { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<TbUserCat> TbUserCats { get; set; } = new List<TbUserCat>();
}
