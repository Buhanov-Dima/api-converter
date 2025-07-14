using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class EntityTypes
{
    public int EntityTypeId { get; set; }

    public string? EntityTypeName { get; set; }

    public virtual ICollection<Phones> Phones { get; set; } = new List<Phones>();
}
