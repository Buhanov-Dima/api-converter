using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Appeals
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

    public virtual Addresses? Address { get; set; }

    public virtual ComStatus? ComStatus { get; set; }

    public virtual Comments? Comment { get; set; }

    public virtual Courts? Court { get; set; }

    public virtual Debts? DebtDebt { get; set; }

    public virtual Fssps? Fssp { get; set; }

    public virtual Organizations? OrganizationCompany { get; set; }

    public virtual TypeComs? TypeCom { get; set; }
}
