using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class ReasonForEndings
{
    public int ReasonForEndingId { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<ReportIncomingTts> ReportIncomingTts { get; set; } = new List<ReportIncomingTts>();
}
