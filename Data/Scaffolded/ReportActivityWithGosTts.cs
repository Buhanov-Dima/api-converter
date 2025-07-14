using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class ReportActivityWithGosTts
{
    public int Id { get; set; }

    public DateTime ActivityDate { get; set; }

    public int TypeActivityId { get; set; }

    public string? ActivityContact { get; set; }

    public string? ActivityPerson { get; set; }

    public string? ActivityPersonFio { get; set; }

    public string? ActivityPersonPosition { get; set; }

    public string? Organization { get; set; }

    public string? OrganizationAddress { get; set; }

    public string? ActivityResult { get; set; }

    public int? CommentId { get; set; }

    public string? Recomendations { get; set; }

    public int DebtId { get; set; }

    public int ClientId { get; set; }

    public string? DebtNumber { get; set; }

    public string? ReestrTitle { get; set; }

    public DateTime TransferReestrDate { get; set; }

    public string? UserId { get; set; }

    public virtual Comments? Comment { get; set; }

    public virtual Debts Debt { get; set; } = null!;

    public virtual TypeActivities TypeActivity { get; set; } = null!;
}
