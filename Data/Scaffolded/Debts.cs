using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Debts
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

    public virtual ICollection<AppealEntities> AppealEntities { get; set; } = new List<AppealEntities>();

    public virtual ICollection<Appeals> Appeals { get; set; } = new List<Appeals>();

    public virtual ICollection<BaseFileModels> BaseFileModels { get; set; } = new List<BaseFileModels>();

    public virtual ICollection<Comments> Comments { get; set; } = new List<Comments>();

    public virtual Courts? Court { get; set; }

    public virtual ICollection<CourtSessionForDebts> CourtSessionForDebts { get; set; } = new List<CourtSessionForDebts>();

    public virtual DatesOfDebts? DatesOfDebt { get; set; }

    public virtual DebtUserInfoes? DebtInfo { get; set; }

    public virtual Debtors Debtor { get; set; } = null!;

    public virtual ICollection<DescriptionCourts> DescriptionCourts { get; set; } = new List<DescriptionCourts>();

    public virtual ICollection<DeterminationOfReturns> DeterminationOfReturns { get; set; } = new List<DeterminationOfReturns>();

    public virtual ICollection<Dublicates> Dublicates { get; set; } = new List<Dublicates>();

    public virtual ExStatus? ExStatus { get; set; }

    public virtual ICollection<FileModels> FileModels { get; set; } = new List<FileModels>();

    public virtual Fssps? Fssp { get; set; }

    public virtual ICollection<Notifications> Notifications { get; set; } = new List<Notifications>();

    public virtual ICollection<Organizations> Organizations { get; set; } = new List<Organizations>();

    public virtual ICollection<Payments> Payments { get; set; } = new List<Payments>();

    public virtual ProductTypes? ProductType { get; set; }

    public virtual ICollection<Reasons> Reasons { get; set; } = new List<Reasons>();

    public virtual Reestrs Reestr { get; set; } = null!;

    public virtual Regions? Region { get; set; }

    public virtual ICollection<ReportActivityWithDebtorTts> ReportActivityWithDebtorTts { get; set; } = new List<ReportActivityWithDebtorTts>();

    public virtual ICollection<ReportActivityWithGosTts> ReportActivityWithGosTts { get; set; } = new List<ReportActivityWithGosTts>();

    public virtual ICollection<ReportIncomingTts> ReportIncomingTts { get; set; } = new List<ReportIncomingTts>();

    public virtual ICollection<ReportOutgoingTts> ReportOutgoingTts { get; set; } = new List<ReportOutgoingTts>();

    public virtual ICollection<RequestCourts> RequestCourts { get; set; } = new List<RequestCourts>();

    public virtual Status? Status { get; set; }

    public virtual TypeOfDocs? TypeOfDoc { get; set; }

    public virtual TypeOfProductions TypeOfProduction { get; set; } = null!;
}
