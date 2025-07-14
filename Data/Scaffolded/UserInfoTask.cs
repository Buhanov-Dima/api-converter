using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class UserInfoTask
{
    public int UserInfoTaskId { get; set; }

    public string? UserId { get; set; }

    public virtual ICollection<UserTask> UserTasks { get; set; } = new List<UserTask>();
}
