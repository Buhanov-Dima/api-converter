using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class TypeActivities
{
    public int TypeActivityId { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<ReportActivityWithDebtorTts> ReportActivityWithDebtorTts { get; set; } = new List<ReportActivityWithDebtorTts>();

    public virtual ICollection<ReportActivityWithGosTts> ReportActivityWithGosTts { get; set; } = new List<ReportActivityWithGosTts>();
}
