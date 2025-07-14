using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class TypeOfDoc
{
    public int TypeOfDocId { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<BaseFileModel> BaseFileModels { get; set; } = new List<BaseFileModel>();

    public virtual ICollection<Debt> Debts { get; set; } = new List<Debt>();
}
