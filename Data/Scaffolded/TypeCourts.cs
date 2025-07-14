using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class TypeCourts
{
    public int TypeCourtId { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<Courts> Courts { get; set; } = new List<Courts>();
}
