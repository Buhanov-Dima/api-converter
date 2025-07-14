using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class ExStatus
{
    public int ExStatusId { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<Debts> Debts { get; set; } = new List<Debts>();
}
