using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class BenchmarkReestrs
{
    public int BenchmarkId { get; set; }

    public int BenchmarkStep { get; set; }

    public int? ReestrId { get; set; }

    public decimal ValueMoney { get; set; }

    public decimal ValuePercent { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int TypeId { get; set; }

    public virtual Reestrs? Reestr { get; set; }

    public virtual TypeBenchmarks Type { get; set; } = null!;
}
