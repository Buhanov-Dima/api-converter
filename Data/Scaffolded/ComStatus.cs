using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class ComStatus
{
    public int ComStatusId { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<AppealEntities> AppealEntities { get; set; } = new List<AppealEntities>();

    public virtual ICollection<Appeals> Appeals { get; set; } = new List<Appeals>();
}
