using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class TypeBenchmark
{
    public int TypeId { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<BenchmarkReestr> BenchmarkReestrs { get; set; } = new List<BenchmarkReestr>();
}
