using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Requisite
{
    public int RequisiteId { get; set; }

    public string? Oktmo { get; set; }

    public string? Bik { get; set; }

    public string? Inn { get; set; }

    public string? Kpp { get; set; }

    public string? PaymentAcc { get; set; }

    public string? TreasuryAcc { get; set; }

    public string? Ufk { get; set; }

    public string? Kbk { get; set; }

    public string? Bank { get; set; }

    public virtual ICollection<Organization> Organizations { get; set; } = new List<Organization>();
}
