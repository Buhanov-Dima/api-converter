using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class ReportOutgoingTt
{
    public int Id { get; set; }

    public string? DocumentName { get; set; }

    public string? Shpi { get; set; }

    public DateTime SendDate { get; set; }

    public int TypeDocumentId { get; set; }

    public int AddressId { get; set; }

    public string? Recipient { get; set; }

    public decimal? AmountOfClaims { get; set; }

    public string? IdentifierCourt { get; set; }

    public string? DocumentName2 { get; set; }

    public int DebtId { get; set; }

    public int ClientId { get; set; }

    public string? DebtNumber { get; set; }

    public string? ReestrTitle { get; set; }

    public DateTime TransferReestrDate { get; set; }

    public string? UserId { get; set; }

    public virtual Address Address { get; set; } = null!;

    public virtual Debt Debt { get; set; } = null!;

    public virtual ICollection<FileModel> FileModels { get; set; } = new List<FileModel>();

    public virtual TypeDocument TypeDocument { get; set; } = null!;
}
