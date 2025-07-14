using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class History
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public int? ActionId { get; set; }

    public string? Action { get; set; }

    public DateTime CreateDate { get; set; }

    public string? Description { get; set; }

    public int? DebtId { get; set; }
}
