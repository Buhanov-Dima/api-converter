using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class TypeOfProduction
{
    public int TypeOfProductionId { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<Debt> Debts { get; set; } = new List<Debt>();

    public virtual ICollection<TypePattern> TypePatterns { get; set; } = new List<TypePattern>();
}
