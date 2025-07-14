using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class TypeDocuments
{
    public int TypeDocumentId { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<BaseFileModels> BaseFileModels { get; set; } = new List<BaseFileModels>();

    public virtual ICollection<FileModels> FileModels { get; set; } = new List<FileModels>();

    public virtual ICollection<ReportIncomingTts> ReportIncomingTts { get; set; } = new List<ReportIncomingTts>();

    public virtual ICollection<ReportOutgoingTts> ReportOutgoingTts { get; set; } = new List<ReportOutgoingTts>();
}
