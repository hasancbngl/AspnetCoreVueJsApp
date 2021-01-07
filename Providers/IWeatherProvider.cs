using System.Collections.Generic;
using my_vue_starter_new.Models;

namespace my_vue_starter_new.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
