using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Regions
{
    public int RegionId { get; set; }

    public string? RegionTitle { get; set; }

    public string? UserId { get; set; }

    public string? SubStrings { get; set; }

    public string? Utc { get; set; }

    public string? Postcode { get; set; }

    public virtual ICollection<Addresses> Addresses { get; set; } = new List<Addresses>();

    public virtual ICollection<Debts> Debts { get; set; } = new List<Debts>();
}
