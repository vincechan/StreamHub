using DataCollector.Core;
using Microsoft.AspNetCore.Mvc;

namespace DataCollector.Api.Controllers;



[Route("api/[controller]")]
public class TVShowController : Controller
{
    private readonly IDataCollectorService dataCollectorService;

    public TVShowController(IDataCollectorService dataCollectorService)
    {
        this.dataCollectorService = dataCollectorService;
    }

    // CRUD for dev / demo
    [HttpGet("CollectPopularTVShows")]
    public Task CollectPopularTVShows()
    {
        return dataCollectorService.CollectPopularTVShowsAsync();
    }
}
