using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class TypeAddresses
{
    public int TypeAddressId { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<Addresses> Addresses { get; set; } = new List<Addresses>();
}
