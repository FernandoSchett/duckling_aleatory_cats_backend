using System;
using System.Collections.Generic;

namespace duckling_aleatory_cats.DAL.DBContext;

public partial class TbCat
{
    public int IdCat { get; set; }

    public string? UrlBanner { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<TbUserCat> TbUserCats { get; set; } = new List<TbUserCat>();
}
