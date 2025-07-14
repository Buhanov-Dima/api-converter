using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Fssp
{
    public int FsspId { get; set; }

    public string? Title { get; set; }

    public string? BailiffName { get; set; }

    public string? HigherFssp { get; set; }

    public string? HigherFsspaddress { get; set; }

    public string? Email { get; set; }

    public string? Identifer { get; set; }

    public int? RullerFsspid { get; set; }

    public int? AddressId { get; set; }

    public int? TypeFsspId { get; set; }

    public string? ParentCode { get; set; }

    public virtual Address? Address { get; set; }

    public virtual ICollection<AppealEntity> AppealEntities { get; set; } = new List<AppealEntity>();

    public virtual ICollection<Appeal> Appeals { get; set; } = new List<Appeal>();

    public virtual ICollection<Debt> Debts { get; set; } = new List<Debt>();

    public virtual ICollection<Phone> Phones { get; set; } = new List<Phone>();

    public virtual TypeFssp? TypeFssp { get; set; }
}
