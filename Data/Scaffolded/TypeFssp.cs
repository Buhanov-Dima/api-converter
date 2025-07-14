using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class TypeFssp
{
    public int TypeFsspId { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<Fssp> Fssps { get; set; } = new List<Fssp>();
}
