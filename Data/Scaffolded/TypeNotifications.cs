using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class TypeNotifications
{
    public int TypeNotificationId { get; set; }

    public string? Title { get; set; }

    public string? Path { get; set; }

    public virtual ICollection<Notifications> Notifications { get; set; } = new List<Notifications>();
}
