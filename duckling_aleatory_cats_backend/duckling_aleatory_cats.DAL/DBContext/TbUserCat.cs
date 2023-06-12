using System;
using System.Collections.Generic;

namespace duckling_aleatory_cats.DAL.DBContext;

public partial class TbUserCat
{
    public int IdUserCat { get; set; }

    public int? IdUser { get; set; }

    public int? IdCat { get; set; }

    public virtual TbCat? IdCatNavigation { get; set; }

    public virtual TbUser? IdUserNavigation { get; set; }
}
