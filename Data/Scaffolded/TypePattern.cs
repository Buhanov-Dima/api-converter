using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class TypePattern
{
    public int TypePatternId { get; set; }

    public string? Title { get; set; }

    public string? Path { get; set; }

    public int TypeOfProductionId { get; set; }

    public string? EmailText { get; set; }

    public int? SendCount { get; set; }

    public virtual TypeOfProduction TypeOfProduction { get; set; } = null!;
}
