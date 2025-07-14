using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Organization
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

    public virtual Address? Address { get; set; }

    public virtual ICollection<AppealEntity> AppealEntities { get; set; } = new List<AppealEntity>();

    public virtual ICollection<Appeal> Appeals { get; set; } = new List<Appeal>();

    public virtual Debt? DebtDebt { get; set; }

    public virtual Person? Person { get; set; }

    public virtual ICollection<Phone> Phones { get; set; } = new List<Phone>();

    public virtual Requisite? Requisite { get; set; }

    public virtual TypeOfOrg? TypeOfOrg { get; set; }
}
