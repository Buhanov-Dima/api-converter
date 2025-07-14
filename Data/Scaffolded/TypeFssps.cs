using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class TypeFssps
{
    public int TypeFsspId { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<Fssps> Fssps { get; set; } = new List<Fssps>();
}
