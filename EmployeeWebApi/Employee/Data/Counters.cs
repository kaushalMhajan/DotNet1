using System.ComponentModel.DataAnnotations.Schema;

namespace Employment.Data;

[Table("Counters")]
public class Counters{
    public string Id{get; set;}

    public int seedvalue{get; set;}

    public int currentvalue { get; set; }

}