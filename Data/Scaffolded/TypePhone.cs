using System;
using System.Collections.Generic;

namespace api_converter.Data.Scaffolded;

public partial class TypePhone
{
    public int TypePhoneId { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<Phone> Phones { get; set; } = new List<Phone>();
}
