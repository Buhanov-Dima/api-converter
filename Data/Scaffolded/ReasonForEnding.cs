using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class ReasonForEnding
{
    public int ReasonForEndingId { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<ReportIncomingTt> ReportIncomingTts { get; set; } = new List<ReportIncomingTt>();
}
