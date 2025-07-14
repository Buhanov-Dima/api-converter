using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class DescriptionCourts
{
    public int DescriptionCourtId { get; set; }

    public DateTime SendToCourtSlip { get; set; }

    public DateTime? GetToCourtSlip { get; set; }

    public DateTime? DateOfTransferSlip { get; set; }

    public string? ReasonOfSlip { get; set; }

    public int? DebtId { get; set; }

    public string? NumberOfSlip { get; set; }

    public int? TypeId { get; set; }

    public DateTime? DateSendToBank { get; set; }

    public virtual Debts? Debt { get; set; }

    public virtual TypeDescriptions? Type { get; set; }
}
