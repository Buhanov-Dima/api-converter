using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class ReportActivityWithDebtorTt
{
    public int Id { get; set; }

    public DateTime ActivityDate { get; set; }

    public int TypeActivityId { get; set; }

    public string? ActivityContact { get; set; }

    public string? ActivityPerson { get; set; }

    public string? ActivityResult { get; set; }

    public decimal? PromiseAmount { get; set; }

    public DateTime? PromiseDate { get; set; }

    public int? CommentId { get; set; }

    public string? Recomendations { get; set; }

    public int DebtId { get; set; }

    public int ClientId { get; set; }

    public string? DebtNumber { get; set; }

    public string? ReestrTitle { get; set; }

    public DateTime TransferReestrDate { get; set; }

    public string? UserId { get; set; }

    public virtual Comment? Comment { get; set; }

    public virtual Debt Debt { get; set; } = null!;

    public virtual TypeActivity TypeActivity { get; set; } = null!;
}
