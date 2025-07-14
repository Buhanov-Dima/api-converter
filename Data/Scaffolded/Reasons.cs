using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Reasons
{
    public int ReasonId { get; set; }

    public int ReasonGroupId { get; set; }

    public string? Title { get; set; }

    public int? Primary { get; set; }

    public int? DebtId { get; set; }

    public int? ReturnId { get; set; }

    public virtual Debts? Debt { get; set; }

    public virtual DeterminationOfReturns? Return { get; set; }
}
