using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class DatesOfDebts
{
    public int DatesOfDebtId { get; set; }

    public DateTime? ActualDate { get; set; }

    public DateTime? DateOfExpiration { get; set; }

    public DateTime? DateOfOrder { get; set; }

    public DateTime? DateOfLastPay { get; set; }

    public DateTime? DateOfPayStateDuty { get; set; }

    public DateTime? DateOfSendToCourt { get; set; }

    public DateTime? DateOfRecivedDoc { get; set; }

    public DateTime? StartContract { get; set; }

    public DateTime? LastChangeForDebt { get; set; }

    public DateTime? Statement { get; set; }

    public DateTime? HelpDetermination { get; set; }

    public DateTime? StatementIfns { get; set; }

    public DateTime? StateDutyReturn { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? DateOfSendToExecution { get; set; }

    public DateTime? Notification { get; set; }

    public DateTime? DateOfSubmission { get; set; }

    public DateTime? DateOfHearing { get; set; }

    public DateTime? DateOfReceipt { get; set; }

    public DateTime? DateOfFilingClaim { get; set; }

    public DateTime? DateСourtDecision { get; set; }

    public DateTime? DateOfEntryCourtDecision { get; set; }

    public DateTime? DateOfReceiptTheJudgment { get; set; }

    public DateTime? DateOfIssueIl { get; set; }

    public DateTime? DateOfGetIl { get; set; }

    public DateTime? DateOfCancellationSp { get; set; }

    public DateTime? DateOfReceiptCancelSp { get; set; }

    public DateTime? DateGetDisputeOverLaw { get; set; }

    public DateTime? DateDisputeOverLaw { get; set; }

    public DateTime? OverdueDate { get; set; }

    public DateTime? DateTransfer { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateOfInitiation { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public DateTime? DateOfPosting { get; set; }

    public string? NumberOfPosting { get; set; }

    public DateTime? DateArrestProperty { get; set; }

    public string? NumberArrestProperty { get; set; }

    public DateTime? RetirementDate { get; set; }

    public string? RetirementNember { get; set; }

    public DateTime? ExitRestrictionDate { get; set; }

    public string? ExitRestrictionNumber { get; set; }

    public DateTime? ComplitionDate { get; set; }

    public DateTime? DateOfSendToBank { get; set; }

    public DateTime? DateOfSendToOsp { get; set; }

    public DateTime? ComplitionDateOsp { get; set; }

    public DateTime? DateOutOfWork { get; set; }

    public virtual ICollection<Debts> Debts { get; set; } = new List<Debts>();
}
