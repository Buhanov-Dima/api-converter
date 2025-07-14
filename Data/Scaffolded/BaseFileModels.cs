using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class BaseFileModels
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

    public virtual Debts Debt { get; set; } = null!;

    public virtual TypeDocuments TypeDocument { get; set; } = null!;

    public virtual TypeOfDocs TypeOfDoc { get; set; } = null!;
}
