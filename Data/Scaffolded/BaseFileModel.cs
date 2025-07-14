using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class BaseFileModel
{
    public int FileModelId { get; set; }

    public string? Title { get; set; }

    public DateTime DownloadDate { get; set; }

    public DateTime CreateDate { get; set; }

    public string? FilePath { get; set; }

    public int DebtId { get; set; }

    public int TypeOfDocId { get; set; }

    public int TypeDocumentId { get; set; }

    public string? Properties { get; set; }

    public virtual Debt Debt { get; set; } = null!;

    public virtual TypeDocument TypeDocument { get; set; } = null!;

    public virtual TypeOfDoc TypeOfDoc { get; set; } = null!;
}
