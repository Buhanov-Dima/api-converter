using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Fssps
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

    public virtual Addresses? Address { get; set; }

    public virtual ICollection<AppealEntities> AppealEntities { get; set; } = new List<AppealEntities>();

    public virtual ICollection<Appeals> Appeals { get; set; } = new List<Appeals>();

    public virtual ICollection<Debts> Debts { get; set; } = new List<Debts>();

    public virtual ICollection<Phones> Phones { get; set; } = new List<Phones>();

    public virtual TypeFssps? TypeFssp { get; set; }
}
