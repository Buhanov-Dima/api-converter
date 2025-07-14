using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class DebtUserInfo
{
    public int DebtInfoId { get; set; }

    public string? UserId { get; set; }

    public string? UserInfo { get; set; }

    public string? UserExecutiveId { get; set; }

    public string? UserExecutiveInfo { get; set; }

    public string? UserCallingId { get; set; }

    public string? UserCallingInfo { get; set; }

    public virtual ICollection<Debt> Debts { get; set; } = new List<Debt>();
}
