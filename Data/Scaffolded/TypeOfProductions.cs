using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class TypeOfProductions
{
    public int TypeOfProductionId { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<Debts> Debts { get; set; } = new List<Debts>();

    public virtual ICollection<TypePatterns> TypePatterns { get; set; } = new List<TypePatterns>();
}
