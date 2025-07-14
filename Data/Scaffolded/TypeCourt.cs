using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class TypeCourt
{
    public int TypeCourtId { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<Court> Courts { get; set; } = new List<Court>();
}
