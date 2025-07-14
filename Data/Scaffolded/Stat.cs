using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Stat
{
    public int StatId { get; set; }

    public int StatusId { get; set; }

    public int Stat1 { get; set; }

    public int? ReportViewModelStatId { get; set; }

    public virtual ReportViewModel? ReportViewModelStat { get; set; }
}
