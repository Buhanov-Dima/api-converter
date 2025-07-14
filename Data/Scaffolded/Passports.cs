using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Passports
{
    public int PassportId { get; set; }

    public string? PassportNumber { get; set; }

    public string? PassportSeries { get; set; }

    public DateTime? DateOfIssue { get; set; }

    public string? PassportIssuedBy { get; set; }

    public virtual ICollection<Debtors> Debtors { get; set; } = new List<Debtors>();
}
