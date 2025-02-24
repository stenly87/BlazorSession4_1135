﻿using System;
using System.Collections.Generic;

namespace BlazorSession4.DB;

public partial class Cabinet
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
