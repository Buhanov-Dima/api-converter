using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Client
{
    public int ClientId { get; set; }

    public string? ClientName { get; set; }

    public string? FullName { get; set; }

    public string? Inn { get; set; }

    public string? Kpp { get; set; }

    public string? Bik { get; set; }

    public string? PaymentAcc { get; set; }

    public string? CorAcc { get; set; }

    public string? Ogrn { get; set; }

    public string? BankName { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Reestr> Reestrs { get; set; } = new List<Reestr>();
}
