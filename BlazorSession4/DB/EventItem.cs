namespace BlazorSession4.DB;

public partial class EventItem
{
    public ulong Uid { get; set; }

    public string Summary { get; set; } 

    public string Description { get; set; } 

    public DateTime DtStamp { get; set; }
    public DateTime DtStart { get; set; }
    public DateTime DtEnd { get; set; }

    public string Location { get; set; }
    public string Organizer { get; set; }
}