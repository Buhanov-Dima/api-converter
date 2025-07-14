using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class TypePhones
{
    public int TypePhoneId { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<Phones> Phones { get; set; } = new List<Phones>();
}
