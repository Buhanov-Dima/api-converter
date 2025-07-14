using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class DeterminationOfReturns
{
    public int ReturnId { get; set; }

    public DateTime DateDefinitionsToReturn { get; set; }

    public DateTime? DateOfResubmissionToCourt { get; set; }

    public DateTime? DateOfReturnDoc { get; set; }

    public int? DebtId { get; set; }

    public virtual Debts? Debt { get; set; }

    public virtual ICollection<Reasons> Reasons { get; set; } = new List<Reasons>();
}
