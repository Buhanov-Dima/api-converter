using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class TypeDocument
{
    public int TypeDocumentId { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<BaseFileModel> BaseFileModels { get; set; } = new List<BaseFileModel>();

    public virtual ICollection<FileModel> FileModels { get; set; } = new List<FileModel>();

    public virtual ICollection<ReportIncomingTt> ReportIncomingTts { get; set; } = new List<ReportIncomingTt>();

    public virtual ICollection<ReportOutgoingTt> ReportOutgoingTts { get; set; } = new List<ReportOutgoingTt>();
}
