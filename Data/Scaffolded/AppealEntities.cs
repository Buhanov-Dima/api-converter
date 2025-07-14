using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class AppealEntities
{
    public int AppealEntityId { get; set; }

    public DateTime DateOfTheComplaint { get; set; }

    public DateTime? DateOfConsideration { get; set; }

    public DateTime? Result { get; set; }

    public DateTime? DateGetResult { get; set; }

    public DateTime? DateOfRulingAppeal { get; set; }

    public string? Docs { get; set; }

    public string? Shpi { get; set; }

    public string? UserId { get; set; }

    public int? CommentId { get; set; }

    public int? AddressId { get; set; }

    public int? TypeComId { get; set; }

    public int? ComStatusId { get; set; }

    public int? CourtId { get; set; }

    public int? FsspId { get; set; }

    public int? DebtDebtId { get; set; }

    public int ResultStatus { get; set; }

    public int? CompanyId { get; set; }

    public string? UserName { get; set; }

    public string? DocNumber { get; set; }

    public virtual Addresses? Address { get; set; }

    public virtual ComStatus? ComStatus { get; set; }

    public virtual Comments? Comment { get; set; }

    public virtual Organizations? Company { get; set; }

    public virtual Courts? Court { get; set; }

    public virtual Debts? DebtDebt { get; set; }

    public virtual Fssps? Fssp { get; set; }

    public virtual TypeComs? TypeCom { get; set; }
}
