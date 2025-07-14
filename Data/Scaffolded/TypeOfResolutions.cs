using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class TypeOfResolutions
{
    public int TypeOfResolutionId { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<ReportIncomingTts> ReportIncomingTts { get; set; } = new List<ReportIncomingTts>();
}
