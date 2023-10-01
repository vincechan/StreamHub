
namespace DataCollector.Core;

public class DataCollectorService : IDataCollectorService
{
    private readonly ITVShowRepository tvShowRepo;

    private readonly ITmdbClient tmdbClient;

    public DataCollectorService(ITVShowRepository tvShowRepo, ITmdbClient tmdbClient)
    {
        this.tvShowRepo = tvShowRepo;
        this.tmdbClient = tmdbClient;
    }

    public async Task CollectPopularTVShowsAsync()
    {
        var shows = await tmdbClient.FetchPopularTVShowsAsync();

        foreach (var show in shows)
        {
            await tvShowRepo.AddIfNotExistAsync(show);
        }
    }
}
