using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Phones
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

    public virtual Courts? CourtCourt { get; set; }

    public virtual Debtors? DebtorDebtor { get; set; }

    public virtual EntityTypes EntityType { get; set; } = null!;

    public virtual Fssps? FsspFssp { get; set; }

    public virtual Organizations? OrganizationCompany { get; set; }

    public virtual TypePhones? TypePhoneTypePhone { get; set; }
}
