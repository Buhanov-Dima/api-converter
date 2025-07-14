using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Comment
{
    public int CommentId { get; set; }

    public string? Commit { get; set; }

    public DateTime CommentDate { get; set; }

    public int? DebtId { get; set; }

    public string? UserId { get; set; }

    public string? UserName { get; set; }

    public virtual ICollection<AppealEntity> AppealEntities { get; set; } = new List<AppealEntity>();

    public virtual ICollection<Appeal> Appeals { get; set; } = new List<Appeal>();

    public virtual Debt? Debt { get; set; }

    public virtual ICollection<ReportActivityWithDebtorTt> ReportActivityWithDebtorTts { get; set; } = new List<ReportActivityWithDebtorTt>();

    public virtual ICollection<ReportActivityWithGosTt> ReportActivityWithGosTts { get; set; } = new List<ReportActivityWithGosTt>();
}
