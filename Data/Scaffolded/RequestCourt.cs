using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class RequestCourt
{
    public int RequestCourtId { get; set; }

    public DateTime DateOfTheRequest { get; set; }

    public DateTime? DateOfGetBackTheRequest { get; set; }

    public string? TxtRequest { get; set; }

    public int? DebtId { get; set; }

    public virtual Debt? Debt { get; set; }
}
