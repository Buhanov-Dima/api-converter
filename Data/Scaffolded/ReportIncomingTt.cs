using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class ReportIncomingTt
{
    public int Id { get; set; }

    public string? DocumentName { get; set; }

    public string? Shpi { get; set; }

    public DateTime RecivedDate { get; set; }

    public int TypeDocumentId { get; set; }

    public DateTime? DateOfIssue { get; set; }

    public string? ReasonForRefusal { get; set; }

    public string? CaseNumber { get; set; }

    public string? NumberOfDocumentIl { get; set; }

    public string? NumberOfProductiontIl { get; set; }

    public decimal? MainDebt { get; set; }

    public decimal? Percent { get; set; }

    public decimal? Penalties { get; set; }

    public decimal? StateDuty { get; set; }

    public int TypeOfResolutionId { get; set; }

    public int? ReasonForEndingId { get; set; }

    public int DebtId { get; set; }

    public int ClientId { get; set; }

    public string? DebtNumber { get; set; }

    public string? ReestrTitle { get; set; }

    public DateTime TransferReestrDate { get; set; }

    public string? UserId { get; set; }

    public virtual Debt Debt { get; set; } = null!;

    public virtual ICollection<FileModel> FileModels { get; set; } = new List<FileModel>();

    public virtual ReasonForEnding? ReasonForEnding { get; set; }

    public virtual TypeDocument TypeDocument { get; set; } = null!;

    public virtual TypeOfResolution TypeOfResolution { get; set; } = null!;
}
