using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class PinUsers
{
    public int PinUserId { get; set; }

    public string? JudicalUser { get; set; }

    public string? ExecutiveUser { get; set; }

    public string? CallingUser { get; set; }

    public virtual ICollection<Reestrs> Reestrs { get; set; } = new List<Reestrs>();
}
