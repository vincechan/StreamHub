using DataCollector.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace DataCollector.Api;

public class DataContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to postgres with connection string from app settings
        // options.UseNpgsql(Configuration.GetConnectionString("StreamHubDatabase"));
        options.UseNpgsql($"Host=localhost; Database=streamhub; Username=postgres; Password=example");
    }

    public DbSet<TVShow> TVShows { get; set; }
}