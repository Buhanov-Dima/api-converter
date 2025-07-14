using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class FileModel
{
    public int FileModelId { get; set; }

    public string? Title { get; set; }

    public string? PathToFile { get; set; }

    public DateTime DownloadDate { get; set; }

    public int? DebtId { get; set; }

    public int? TypeDocumentId { get; set; }

    public int? ReportOutgoingTtid { get; set; }

    public int? ReportIncomingTtid { get; set; }

    public string? ReasonForRefusal { get; set; }

    public int? Shpi { get; set; }

    public DateTime? RecivedDate { get; set; }

    public DateTime? DateOfIssue { get; set; }

    public string? CaseNumber { get; set; }

    public string? NumberOfDocumentIl { get; set; }

    public string? NumberOfProductiontIl { get; set; }

    public string? MainDebt { get; set; }

    public string? Percent { get; set; }

    public string? Penalties { get; set; }

    public string? StateDuty { get; set; }

    public virtual Debt? Debt { get; set; }

    public virtual ReportIncomingTt? ReportIncomingTt { get; set; }

    public virtual ReportOutgoingTt? ReportOutgoingTt { get; set; }

    public virtual TypeDocument? TypeDocument { get; set; }
}
