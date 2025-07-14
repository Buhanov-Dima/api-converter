using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Address
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

    public virtual ICollection<AppealEntity> AppealEntities { get; set; } = new List<AppealEntity>();

    public virtual ICollection<Appeal> Appeals { get; set; } = new List<Appeal>();

    public virtual ICollection<Court> Courts { get; set; } = new List<Court>();

    public virtual Debtor? DebtorDebtor { get; set; }

    public virtual ICollection<Fssp> Fssps { get; set; } = new List<Fssp>();

    public virtual ICollection<Organization> Organizations { get; set; } = new List<Organization>();

    public virtual Region? RegionNavigation { get; set; }

    public virtual ICollection<ReportOutgoingTt> ReportOutgoingTts { get; set; } = new List<ReportOutgoingTt>();

    public virtual TypeAddress TypeAddress { get; set; } = null!;
}
