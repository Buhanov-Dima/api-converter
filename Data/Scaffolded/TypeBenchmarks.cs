using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class TypeBenchmarks
{
    public int TypeId { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<BenchmarkReestrs> BenchmarkReestrs { get; set; } = new List<BenchmarkReestrs>();
}
