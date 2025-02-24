using System;
using System.Collections.Generic;

namespace BlazorSession4.DB;

public partial class Event
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime DateCreate { get; set; }

    public string Author { get; set; } = null!;
}
