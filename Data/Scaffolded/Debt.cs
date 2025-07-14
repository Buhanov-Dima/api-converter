using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Debt
{
    public int DebtId { get; set; }

    public string? DebtNumber { get; set; }

    public string? Product { get; set; }

    public string? ProductGroup { get; set; }

    public string? AmountContract { get; set; }

    public string? Currency { get; set; }

    public string? CountDayesExpiration { get; set; }

    public string? InvoiceForPayment { get; set; }

    public string? MainDebt { get; set; }

    public string? OverdueDebt { get; set; }

    public string? Percent { get; set; }

    public string? Comission { get; set; }

    public string? Surcharge { get; set; }

    public string? PercentSurchargeDebt { get; set; }

    public string? TotalDebt { get; set; }

    public string? Forfeit { get; set; }

    public string? StateDuty { get; set; }

    public string? TermInMonths { get; set; }

    public string? MonthlyPayment { get; set; }

    public string? InterestRate { get; set; }

    public string? CommitForLoad { get; set; }

    public int CountOfSend { get; set; }

    public string? NumberOfOrder { get; set; }

    public string? CaseNumber { get; set; }

    public string? Ilnumber { get; set; }

    public bool CheckTransfer { get; set; }

    public string? CancelSp { get; set; }

    public string? Penalties { get; set; }

    public int ReestrId { get; set; }

    public int DebtorId { get; set; }

    public int? CourtId { get; set; }

    public int? StatusId { get; set; }

    public int? TypeOfDocId { get; set; }

    public int TypeOfProductionId { get; set; }

    public int? DebtInfoId { get; set; }

    public int? ProductTypeId { get; set; }

    public int? DatesOfDebtId { get; set; }

    public int? RegionId { get; set; }

    public int? ExStatusId { get; set; }

    public int? FsspId { get; set; }

    public string? NumberPov { get; set; }

    public int PaymentCount { get; set; }

    public decimal PaymentAll { get; set; }

    public decimal AmountContractD { get; set; }

    public decimal MainDebtD { get; set; }

    public decimal OverdueDebtD { get; set; }

    public decimal StateDutyD { get; set; }

    public decimal TotalDebtD { get; set; }

    public decimal MonthlyPaymentD { get; set; }

    public string? IdentiferTt { get; set; }

    public string? Postcode { get; set; }

    public string? Shpi { get; set; }

    public virtual ICollection<AppealEntity> AppealEntities { get; set; } = new List<AppealEntity>();

    public virtual ICollection<Appeal> Appeals { get; set; } = new List<Appeal>();

    public virtual ICollection<BaseFileModel> BaseFileModels { get; set; } = new List<BaseFileModel>();

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual Court? Court { get; set; }

    public virtual ICollection<CourtSessionForDebt> CourtSessionForDebts { get; set; } = new List<CourtSessionForDebt>();

    public virtual DatesOfDebt? DatesOfDebt { get; set; }

    public virtual DebtUserInfo? DebtInfo { get; set; }

    public virtual Debtor Debtor { get; set; } = null!;

    public virtual ICollection<DescriptionCourt> DescriptionCourts { get; set; } = new List<DescriptionCourt>();

    public virtual ICollection<DeterminationOfReturn> DeterminationOfReturns { get; set; } = new List<DeterminationOfReturn>();

    public virtual ICollection<Dublicate> Dublicates { get; set; } = new List<Dublicate>();

    public virtual ExStatus? ExStatus { get; set; }

    public virtual ICollection<FileModel> FileModels { get; set; } = new List<FileModel>();

    public virtual Fssp? Fssp { get; set; }

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    public virtual ICollection<Organization> Organizations { get; set; } = new List<Organization>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ProductType? ProductType { get; set; }

    public virtual ICollection<Reason> Reasons { get; set; } = new List<Reason>();

    public virtual Reestr Reestr { get; set; } = null!;

    public virtual Region? Region { get; set; }

    public virtual ICollection<ReportActivityWithDebtorTt> ReportActivityWithDebtorTts { get; set; } = new List<ReportActivityWithDebtorTt>();

    public virtual ICollection<ReportActivityWithGosTt> ReportActivityWithGosTts { get; set; } = new List<ReportActivityWithGosTt>();

    public virtual ICollection<ReportIncomingTt> ReportIncomingTts { get; set; } = new List<ReportIncomingTt>();

    public virtual ICollection<ReportOutgoingTt> ReportOutgoingTts { get; set; } = new List<ReportOutgoingTt>();

    public virtual ICollection<RequestCourt> RequestCourts { get; set; } = new List<RequestCourt>();

    public virtual Status? Status { get; set; }

    public virtual TypeOfDoc? TypeOfDoc { get; set; }

    public virtual TypeOfProduction TypeOfProduction { get; set; } = null!;
}
