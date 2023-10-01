namespace DataCollector.Core;

public interface ITVShowRepository
{
    Task<int> AddIfNotExistAsync(TVShow tvShow);


}
