using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Region
{
    public int RegionId { get; set; }

    public string? RegionTitle { get; set; }

    public string? UserId { get; set; }

    public string? SubStrings { get; set; }

    public string? Utc { get; set; }

    public string? Postcode { get; set; }

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    public virtual ICollection<Debt> Debts { get; set; } = new List<Debt>();
}
