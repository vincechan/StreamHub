using System.Text.Json.Serialization;

namespace DataCollector.Api;

public class TmdbTVShowResponse
{
    [JsonPropertyName("page")]
    public int Page { get; set; }

    [JsonPropertyName("results")]
    public IList<TmdbTVShow> Results { get; set; } = new List<TmdbTVShow>();

}

public class TmdbTVShow
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("overview")]
    public string? Overview { get; set; }

    [JsonPropertyName("original_name")]
    public string? OriginalName { get; set; }
}