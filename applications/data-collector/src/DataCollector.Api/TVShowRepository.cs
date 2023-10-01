using DataCollector.Core;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataCollector.Api;

public class TVShowRepository : ITVShowRepository
{
    private readonly DataContext dataContext;

    public TVShowRepository(DataContext dataContext)
    {
        this.dataContext = dataContext;
    }

    public async Task<int> AddIfNotExistAsync(TVShow tvShow)
    {
        var existing = await dataContext.TVShows.FirstOrDefaultAsync(x => x.Name == tvShow.Name);
        if (existing == null)
        {
            tvShow.Id = Guid.NewGuid();
            dataContext.Add(tvShow);
            return await dataContext.SaveChangesAsync();
        }
        return 0;
    }
}
