namespace DataCollector.Core;

public interface ITmdbClient
{
    Task<IList<TVShow>> FetchPopularTVShowsAsync();

}
