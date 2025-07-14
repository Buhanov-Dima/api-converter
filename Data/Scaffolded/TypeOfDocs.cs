using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class TypeOfDocs
{
    public int TypeOfDocId { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<BaseFileModels> BaseFileModels { get; set; } = new List<BaseFileModels>();

    public virtual ICollection<Debts> Debts { get; set; } = new List<Debts>();
}
