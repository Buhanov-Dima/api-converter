using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Status
{
    public int StatusId { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<Debts> Debts { get; set; } = new List<Debts>();
}
