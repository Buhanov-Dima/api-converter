using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class UserTask
{
    public int UserTaskId { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public bool Active { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? UserId { get; set; }

    public int? DebtId { get; set; }

    public int? UserInfoTaskUserInfoTaskId { get; set; }

    public int OverdueDays { get; set; }

    public bool Visible { get; set; }

    public DateTime UpdateDate { get; set; }

    public virtual UserInfoTask? UserInfoTaskUserInfoTask { get; set; }
}
