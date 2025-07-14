using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Comments
{
    public int CommentId { get; set; }

    public string? Commit { get; set; }

    public DateTime CommentDate { get; set; }

    public int? DebtId { get; set; }

    public string? UserId { get; set; }

    public string? UserName { get; set; }

    public virtual ICollection<AppealEntities> AppealEntities { get; set; } = new List<AppealEntities>();

    public virtual ICollection<Appeals> Appeals { get; set; } = new List<Appeals>();

    public virtual Debts? Debt { get; set; }

    public virtual ICollection<ReportActivityWithDebtorTts> ReportActivityWithDebtorTts { get; set; } = new List<ReportActivityWithDebtorTts>();

    public virtual ICollection<ReportActivityWithGosTts> ReportActivityWithGosTts { get; set; } = new List<ReportActivityWithGosTts>();
}
