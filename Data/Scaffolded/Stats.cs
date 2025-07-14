using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Stats
{
    public int StatId { get; set; }

    public int StatusId { get; set; }

    public int Stat { get; set; }

    public int? ReportViewModelStatId { get; set; }

    public virtual ReportViewModels? ReportViewModelStat { get; set; }
}
