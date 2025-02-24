using System;
using System.Collections.Generic;

namespace BlazorSession4.DB;

public partial class TypeEvent
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<EventCalendar> EventCalendars { get; set; } = new List<EventCalendar>();
}
