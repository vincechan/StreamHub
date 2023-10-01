using System.ComponentModel.DataAnnotations.Schema;

namespace DataCollector.Core;

[Table("tv_show")]
public class TVShow
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public string? OriginalName { get; set; }

    public string? Overview { get; set; }
}
