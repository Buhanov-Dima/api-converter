using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Addresses
{
    public int AddressId { get; set; }

    public string? Region { get; set; }

    public string? Postcode { get; set; }

    public string? Settlement { get; set; }

    public string? District { get; set; }

    public string? TypeOfSettlement { get; set; }

    public string? StreetName { get; set; }

    public string? HouseNum { get; set; }

    public string? HousingNum { get; set; }

    public string? ApartmentNum { get; set; }

    public int TypeAddressId { get; set; }

    public int? DebtorDebtorId { get; set; }

    public int? RegionId { get; set; }

    public string? FullAddress { get; set; }

    public virtual ICollection<AppealEntities> AppealEntities { get; set; } = new List<AppealEntities>();

    public virtual ICollection<Appeals> Appeals { get; set; } = new List<Appeals>();

    public virtual ICollection<Courts> Courts { get; set; } = new List<Courts>();

    public virtual Debtors? DebtorDebtor { get; set; }

    public virtual ICollection<Fssps> Fssps { get; set; } = new List<Fssps>();

    public virtual ICollection<Organizations> Organizations { get; set; } = new List<Organizations>();

    public virtual Regions? RegionNavigation { get; set; }

    public virtual ICollection<ReportOutgoingTts> ReportOutgoingTts { get; set; } = new List<ReportOutgoingTts>();

    public virtual TypeAddresses TypeAddress { get; set; } = null!;
}
