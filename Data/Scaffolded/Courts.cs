using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Courts
{
    public int CourtId { get; set; }

    public string? Title { get; set; }

    public string? Name { get; set; }

    public string? Oktmo { get; set; }

    public string? Bik { get; set; }

    public string? Inn { get; set; }

    public string? Kpp { get; set; }

    public string? PaymentAcc { get; set; }

    public string? Ufk { get; set; }

    public string? Kbk { get; set; }

    public string? BankClient { get; set; }

    public string? Identifer { get; set; }

    public int? AddressId { get; set; }

    public int? TypeCourtId { get; set; }

    public int? RullerCourtId { get; set; }

    public string? TreasuryAcc { get; set; }

    public string? ParentCode { get; set; }

    public string? Email { get; set; }

    public virtual Addresses? Address { get; set; }

    public virtual ICollection<AppealEntities> AppealEntities { get; set; } = new List<AppealEntities>();

    public virtual ICollection<Appeals> Appeals { get; set; } = new List<Appeals>();

    public virtual ICollection<Debts> Debts { get; set; } = new List<Debts>();

    public virtual ICollection<Phones> Phones { get; set; } = new List<Phones>();

    public virtual TypeCourts? TypeCourt { get; set; }
}
