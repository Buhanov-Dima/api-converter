using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class TypeCom
{
    public int TypeComId { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<AppealEntity> AppealEntities { get; set; } = new List<AppealEntity>();

    public virtual ICollection<Appeal> Appeals { get; set; } = new List<Appeal>();
}
