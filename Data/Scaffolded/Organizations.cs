using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Organizations
{
    public int CompanyId { get; set; }

    public string? Identificator { get; set; }

    public string? ParentCode { get; set; }

    public int? PersonId { get; set; }

    public int? RequisiteId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Email { get; set; }

    public int? AddressId { get; set; }

    public int? TypeOfOrgId { get; set; }

    public int? DebtDebtId { get; set; }

    public virtual Addresses? Address { get; set; }

    public virtual ICollection<AppealEntities> AppealEntities { get; set; } = new List<AppealEntities>();

    public virtual ICollection<Appeals> Appeals { get; set; } = new List<Appeals>();

    public virtual Debts? DebtDebt { get; set; }

    public virtual People? Person { get; set; }

    public virtual ICollection<Phones> Phones { get; set; } = new List<Phones>();

    public virtual Requisites? Requisite { get; set; }

    public virtual TypeOfOrgs? TypeOfOrg { get; set; }
}
