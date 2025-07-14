using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class TypeOfOrgs
{
    public int TypeOfOrgId { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<Organizations> Organizations { get; set; } = new List<Organizations>();
}
