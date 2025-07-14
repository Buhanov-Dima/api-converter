using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class ProductType
{
    public int ProductTypeId { get; set; }

    public string? Title { get; set; }

    public int Client { get; set; }

    public virtual ICollection<Debt> Debts { get; set; } = new List<Debt>();

    public virtual ICollection<ProductClient> ProductClients { get; set; } = new List<ProductClient>();
}
