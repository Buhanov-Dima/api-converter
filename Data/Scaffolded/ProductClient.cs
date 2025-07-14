using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class ProductClient
{
    public int ProductClientId { get; set; }

    public string? Title { get; set; }

    public int? ProductTypeProductTypeId { get; set; }

    public virtual ProductType? ProductTypeProductType { get; set; }
}
