using System;
using System.Collections.Generic;

namespace BlazorSession4.DB;

public partial class StatusMaterial
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<Material> Materials { get; set; } = new List<Material>();
}
