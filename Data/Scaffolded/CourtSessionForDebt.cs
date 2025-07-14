using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class CourtSessionForDebt
{
    public int Id { get; set; }

    public DateTime DateCourtSession { get; set; }

    public int? DebtDebtId { get; set; }

    public virtual Debt? DebtDebt { get; set; }
}
