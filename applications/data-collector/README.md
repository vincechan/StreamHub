# StreamHub DataCollector

Fetch data from TVDB api and store in postgres database for further analysis.

## Setup

- Get access token from [TVDB](https://developer.themoviedb.org/reference/intro/getting-started)

## Running
- Update env var `STREAMHUB__TMDB__APIKEY` to your TVDB access token
- From `data-collector/src`, run `docker-compose up` to run db in container
- From `data-collector/src/DataCollector.Api`, run `dotnet run`
- Browse to `https://localhost:8080/swagger/index.html`, try `api/TVShow/CollectPopularTVShows` route

## Migrations
* Manage migration using `dotnet ef`. To install the tool globally, run `dotnet tool 
* Create Migration - `dotnet ef migrations add name_of_migration`
* Execute Migration - `dotnet ef database update`