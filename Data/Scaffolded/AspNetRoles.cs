using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class AspNetRoles
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Discriminator { get; set; } = null!;

    public virtual ICollection<AspNetUsers> User { get; set; } = new List<AspNetUsers>();
}
