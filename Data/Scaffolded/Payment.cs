using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Payment
{
    public int PayId { get; set; }

    public DateTime? PaymentDay { get; set; }

    public decimal PaymentCost { get; set; }

    public string? DebtNumber { get; set; }

    public int DebtId { get; set; }

    public virtual Debt Debt { get; set; } = null!;
}
