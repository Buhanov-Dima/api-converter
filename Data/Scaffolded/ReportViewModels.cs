using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class ReportViewModels
{
    public int StatId { get; set; }

    public string? CourtTitle { get; set; }

    public string? ClientTitle { get; set; }

    public string? ReestrTitle { get; set; }

    public string? RegionTitle { get; set; }

    public int CourtId { get; set; }

    public int ReestrId { get; set; }

    public int RegionId { get; set; }

    public int ClientId { get; set; }

    public int DebtCountReestr { get; set; }

    public int DebtCountNotinWork { get; set; }

    public int CancellCount { get; set; }

    public int ReturnCount { get; set; }

    public int RefusalsCount { get; set; }

    public int OrderCount { get; set; }

    public int SheetCount { get; set; }

    public int DispatchOrder { get; set; }

    public int DispatchSheet { get; set; }

    public int DublicateCountSend { get; set; }

    public int DublicateCountGet { get; set; }

    public int SlipCount { get; set; }

    public int ComplaintCountSend { get; set; }

    public int ComplaintCountGet { get; set; }

    public int SubmissionCount { get; set; }

    public int RequestCount { get; set; }

    public string? UserId { get; set; }

    public DateTime Date { get; set; }

    public virtual ICollection<Stats> Stats { get; set; } = new List<Stats>();
}
