using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class TransferToUses
{
    public int TransferId { get; set; }

    public int TransferStatus { get; set; }

    public string? SendUser { get; set; }

    public string? GetUser { get; set; }

    public int ClientId { get; set; }

    public int ReestrId { get; set; }

    public string? ClientName { get; set; }

    public string? ReestrName { get; set; }

    public DateTime Date { get; set; }

    public DateTime? ConfirmDate { get; set; }

    public virtual ICollection<TransferDebts> TransferDebts { get; set; } = new List<TransferDebts>();
}
