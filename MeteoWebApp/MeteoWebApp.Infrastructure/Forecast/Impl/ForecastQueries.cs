using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeteoWebApp.Data;

namespace MeteoWebApp.Infrastructure.Forecast
{
    public class ForecastQueries : IForecastQueries
    {
        public IEnumerable<IForecast> GetForecastForCityByWeek(int cityId, DateTimeOffset firstDate)
        {
            using(var db = new DatabaseModelContainer())
            {
                var dbForecast = db.Forecasts
                                    .OrderBy(x => x.Time)
                                    .Where(x => (x.Time > firstDate) && x.CityId == cityId)
                                    .Take(7)
                                    .Select(forecast => new Forecast
                                    {
                                        Id = forecast.Id,
                                        GeneralState = forecast.GeneralState,
                                        RainChance = forecast.RainChance,
                                        Temperature = forecast.Temperature,
                                        Time = forecast.Time,
                                        WindDirection = forecast.WindDirection,
                                        WindSpeed = forecast.WindSpeed
                                    });
                if(dbForecast != null)
                {
                    return dbForecast.ToList();
                }
                
                return null;
            }
        }
    }
}
