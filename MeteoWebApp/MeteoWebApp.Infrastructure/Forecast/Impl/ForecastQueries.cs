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
                var endDate = firstDate.AddDays(7);

                var dbForecast = db.Forecasts
                                    .OrderBy(x => x.Date)
                                    .Where(x => x.CityId == cityId && (x.Date >= firstDate) && (x.Date < endDate))
                                    .Select(forecast => new Forecast
                                    {
                                        Id = forecast.Id,
                                        GeneralState = forecast.GeneralState,
                                        RainChance = forecast.RainChance,
                                        Temperature = forecast.Temperature,
                                        Date = forecast.Date,
                                        WindDirection = forecast.WindDirection,
                                        WindSpeed = forecast.WindSpeed,
                                        WindDirectionImageUrl = forecast.WindDirectionImageUrl,
                                        GeneralStateCaption = forecast.GeneralStateCaption,
                                        GeneralStateImageUrl = forecast.GeneralStateImageUrl
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
