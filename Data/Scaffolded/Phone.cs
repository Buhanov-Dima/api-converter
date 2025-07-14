using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Phone
{
    public int PhoneId { get; set; }

    public string? Number { get; set; }

    public int? ModelId { get; set; }

    public int? PhoneStatusId { get; set; }

    public int? CourtCourtId { get; set; }

    public int? DebtorDebtorId { get; set; }

    public int? FsspFsspId { get; set; }

    public int? TypePhoneTypePhoneId { get; set; }

    public int? OrganizationCompanyId { get; set; }

    public int EntityId { get; set; }

    public int EntityTypeId { get; set; }

    public virtual Court? CourtCourt { get; set; }

    public virtual Debtor? DebtorDebtor { get; set; }

    public virtual EntityType EntityType { get; set; } = null!;

    public virtual Fssp? FsspFssp { get; set; }

    public virtual Organization? OrganizationCompany { get; set; }

    public virtual TypePhone? TypePhoneTypePhone { get; set; }
}
