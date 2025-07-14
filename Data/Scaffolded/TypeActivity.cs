using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class TypeActivity
{
    public int TypeActivityId { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<ReportActivityWithDebtorTt> ReportActivityWithDebtorTts { get; set; } = new List<ReportActivityWithDebtorTt>();

    public virtual ICollection<ReportActivityWithGosTt> ReportActivityWithGosTts { get; set; } = new List<ReportActivityWithGosTt>();
}
