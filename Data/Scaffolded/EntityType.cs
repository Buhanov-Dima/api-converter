using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class EntityType
{
    public int EntityTypeId { get; set; }

    public string? EntityTypeName { get; set; }

    public virtual ICollection<Phone> Phones { get; set; } = new List<Phone>();
}
