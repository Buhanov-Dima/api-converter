using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class AspNetUsers
{
    public string Id { get; set; } = null!;

    public string? UserFirstname { get; set; }

    public string? UserSurname { get; set; }

    public string? UserLastname { get; set; }

    public string? Phone { get; set; }

    public string? Position { get; set; }

    public string? UserEmail { get; set; }

    public string? Identificator { get; set; }

    public string? Email { get; set; }

    public bool EmailConfirmed { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTime? LockoutEndDateUtc { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public string UserName { get; set; } = null!;

    public int? SendCount { get; set; }

    public virtual ICollection<AspNetUserClaims> AspNetUserClaims { get; set; } = new List<AspNetUserClaims>();

    public virtual ICollection<AspNetUserLogins> AspNetUserLogins { get; set; } = new List<AspNetUserLogins>();

    public virtual ICollection<AspNetRoles> Role { get; set; } = new List<AspNetRoles>();
}
