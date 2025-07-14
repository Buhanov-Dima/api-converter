using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class TypeDescriptions
{
    public int TypeId { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<DescriptionCourts> DescriptionCourts { get; set; } = new List<DescriptionCourts>();
}
