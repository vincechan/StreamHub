using System.Text.Json;
using System.Text.Json.Serialization;
using DataCollector.Core;
using RestSharp;
using System.Linq;

namespace DataCollector.Api;

public class TmdbClient : ITmdbClient
{
    private readonly IConfiguration configuration;

    public TmdbClient(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    public async Task<IList<TVShow>> FetchPopularTVShowsAsync()
    {
        var accessToken = configuration.GetValue<string>("STREAMHUB:TMDB:ACCESSTOKEN");
        var options = new RestClientOptions("https://api.themoviedb.org/3/tv/popular?language=en-US&page=1");
        var client = new RestClient(options);
        var request = new RestRequest("");
        request.AddHeader("accept", "application/json");
        request.AddHeader("Authorization", $"Bearer {accessToken}");
        var response = await client.GetAsync(request);

        var tvShowList = new List<TVShow>();
        if (response.Content != null)
        {
            var tmdbResponse = JsonSerializer.Deserialize<TmdbTVShowResponse>(response.Content);
            if (tmdbResponse == null)
            {
                throw new Exception($"Unable to parse TMDB response. respone: {response.Content}");
            }
            foreach (var item in tmdbResponse.Results)
            {
                tvShowList.Add(new TVShow()
                {
                    Name = item.Name,
                    Overview = item.Overview,
                    OriginalName = item.OriginalName
                });
            }
        }

        return tvShowList;
    }
}
