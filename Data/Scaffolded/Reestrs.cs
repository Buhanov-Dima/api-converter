using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Reestrs
{
    public int ReestrId { get; set; }

    public string? Title { get; set; }

    public DateTime DateOfReciving { get; set; }

    public DateTime DateOfStart { get; set; }

    public int ClientId { get; set; }

    public int? PinUserId { get; set; }

    public virtual ICollection<BenchmarkReestrs> BenchmarkReestrs { get; set; } = new List<BenchmarkReestrs>();

    public virtual Clients Client { get; set; } = null!;

    public virtual ICollection<Debts> Debts { get; set; } = new List<Debts>();

    public virtual PinUsers? PinUser { get; set; }
}
