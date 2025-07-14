using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Reestr
{
    public int ReestrId { get; set; }

    public string? Title { get; set; }

    public DateTime DateOfReciving { get; set; }

    public DateTime DateOfStart { get; set; }

    public int ClientId { get; set; }

    public int? PinUserId { get; set; }

    public virtual ICollection<BenchmarkReestr> BenchmarkReestrs { get; set; } = new List<BenchmarkReestr>();

    public virtual Client Client { get; set; } = null!;

    public virtual ICollection<Debt> Debts { get; set; } = new List<Debt>();

    public virtual PinUser? PinUser { get; set; }
}
