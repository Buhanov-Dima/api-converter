using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class ProductTypes
{
    public int ProductTypeId { get; set; }

    public string? Title { get; set; }

    public int Client { get; set; }

    public virtual ICollection<Debts> Debts { get; set; } = new List<Debts>();

    public virtual ICollection<ProductClients> ProductClients { get; set; } = new List<ProductClients>();
}
