using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Appeal
{
    public int AppealId { get; set; }

    public DateTime DateOfTheComplaint { get; set; }

    public DateTime? DateOfConsideration { get; set; }

    public DateTime? Result { get; set; }

    public DateTime? DateGetResult { get; set; }

    public DateTime? DateOfRulingAppeal { get; set; }

    public string? ResultOfConsideration { get; set; }

    public string? Recipient { get; set; }

    public string? Sender { get; set; }

    public string? Docs { get; set; }

    public int? CommentId { get; set; }

    public int? AddressId { get; set; }

    public int? TypeComId { get; set; }

    public int? ComStatusId { get; set; }

    public int? DebtDebtId { get; set; }

    public string? Shpi { get; set; }

    public int? CourtId { get; set; }

    public int? FsspId { get; set; }

    public int? OrgId { get; set; }

    public int? OrganizationCompanyId { get; set; }

    public virtual Address? Address { get; set; }

    public virtual ComStatus? ComStatus { get; set; }

    public virtual Comment? Comment { get; set; }

    public virtual Court? Court { get; set; }

    public virtual Debt? DebtDebt { get; set; }

    public virtual Fssp? Fssp { get; set; }

    public virtual Organization? OrganizationCompany { get; set; }

    public virtual TypeCom? TypeCom { get; set; }
}
