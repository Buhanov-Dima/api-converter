using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class CourtSessionForDebts
{
    public int Id { get; set; }

    public DateTime DateCourtSession { get; set; }

    public int? DebtDebtId { get; set; }

    public virtual Debts? DebtDebt { get; set; }
}
