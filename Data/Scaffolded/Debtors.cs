using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class Debtors
{
    public int DebtorId { get; set; }

    public string? FName { get; set; }

    public string? SName { get; set; }

    public string? LName { get; set; }

    public DateTime DateOfBirth { get; set; }

    public string? PlaceOfBirth { get; set; }

    public string? PlaceOfWork { get; set; }

    public string? Education { get; set; }

    public string? Position { get; set; }

    public string? Experience { get; set; }

    public string? Status { get; set; }

    public string? TheSalary { get; set; }

    public int AddressId { get; set; }

    public string? Gender { get; set; }

    public string? MaritalStatus { get; set; }

    public string? Nationality { get; set; }

    public int PassportId { get; set; }

    public virtual ICollection<Addresses> Addresses { get; set; } = new List<Addresses>();

    public virtual ICollection<Debts> Debts { get; set; } = new List<Debts>();

    public virtual Passports Passport { get; set; } = null!;

    public virtual ICollection<Phones> Phones { get; set; } = new List<Phones>();
}
