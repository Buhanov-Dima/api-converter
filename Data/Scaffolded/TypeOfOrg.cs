using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class TypeOfOrg
{
    public int TypeOfOrgId { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<Organization> Organizations { get; set; } = new List<Organization>();
}
