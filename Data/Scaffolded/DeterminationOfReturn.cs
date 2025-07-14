using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class DeterminationOfReturn
{
    public int ReturnId { get; set; }

    public DateTime DateDefinitionsToReturn { get; set; }

    public DateTime? DateOfResubmissionToCourt { get; set; }

    public DateTime? DateOfReturnDoc { get; set; }

    public int? DebtId { get; set; }

    public virtual Debt? Debt { get; set; }

    public virtual ICollection<Reason> Reasons { get; set; } = new List<Reason>();
}
