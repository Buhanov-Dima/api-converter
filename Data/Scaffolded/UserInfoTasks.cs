using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class UserInfoTasks
{
    public int UserInfoTaskId { get; set; }

    public string? UserId { get; set; }

    public virtual ICollection<UserTasks> UserTasks { get; set; } = new List<UserTasks>();
}
