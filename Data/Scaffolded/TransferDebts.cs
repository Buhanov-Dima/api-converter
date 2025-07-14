using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class TransferDebts
{
    public int TransferDebtId { get; set; }

    public string? DebtName { get; set; }

    public string? DebtNumber { get; set; }

    public string? OrderNumber { get; set; }

    public DateTime OrderDate { get; set; }

    public string? TypeOfDoc { get; set; }

    public string? CourtName { get; set; }

    public string? CourtAddress { get; set; }

    public DateTime TransferDate { get; set; }

    public int? TransferId { get; set; }

    public virtual TransferToUses? Transfer { get; set; }
}
