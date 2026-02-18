namespace RankingTournament.Services.Caching;
using WeatherForecast = RankingTournament.Client.Models.WeatherForecast;
public interface IWeatherCache
{
    ValueTask<IImmutableList<WeatherForecast>> GetForecast(CancellationToken token);
}
