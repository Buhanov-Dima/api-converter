using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class TypeDescription
{
    public int TypeId { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<DescriptionCourt> DescriptionCourts { get; set; } = new List<DescriptionCourt>();
}
