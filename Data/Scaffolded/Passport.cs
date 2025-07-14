using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Passport
{
    public int PassportId { get; set; }

    public string? PassportNumber { get; set; }

    public string? PassportSeries { get; set; }

    public DateTime? DateOfIssue { get; set; }

    public string? PassportIssuedBy { get; set; }

    public virtual ICollection<Debtor> Debtors { get; set; } = new List<Debtor>();
}
