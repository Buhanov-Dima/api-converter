using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class TypeAddress
{
    public int TypeAddressId { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();
}
