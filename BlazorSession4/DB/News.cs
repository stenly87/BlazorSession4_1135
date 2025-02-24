using System;
using System.Collections.Generic;

namespace BlazorSession4.DB;

public partial class News
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int CountLike { get; set; }

    public int CountDislike { get; set; }

    public DateTime DateCreate { get; set; }

    public byte[]? Foto { get; set; }
}
