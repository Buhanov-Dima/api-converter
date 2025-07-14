using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Dublicates
{
    public int DublicateId { get; set; }

    public DateTime DateOfSendDuplicate { get; set; }

    public DateTime? DateOfGetDuplicate { get; set; }

    public string? DocumentName { get; set; }

    public int? DebtId { get; set; }

    public virtual Debts? Debt { get; set; }
}
