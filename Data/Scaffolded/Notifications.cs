using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Notifications
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? UserId { get; set; }

    public bool Active { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? TmpDate { get; set; }

    public int? NotificationId { get; set; }

    public int TypeNotificationId { get; set; }

    public int? DebtDebtId { get; set; }

    public virtual Debts? DebtDebt { get; set; }

    public virtual TypeNotifications TypeNotification { get; set; } = null!;
}
