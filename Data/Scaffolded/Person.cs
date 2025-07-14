using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Person
{
    public int PersonId { get; set; }

    public string? Name { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public virtual ICollection<Organization> Organizations { get; set; } = new List<Organization>();
}
