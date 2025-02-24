﻿using System;
using System.Collections.Generic;

namespace BlazorSession4.DB;

public partial class TypeAbsence
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<AbsenceCalendar> AbsenceCalendars { get; set; } = new List<AbsenceCalendar>();
}
