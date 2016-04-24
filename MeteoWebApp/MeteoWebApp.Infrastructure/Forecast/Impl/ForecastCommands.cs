using MeteoWebApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoWebApp.Infrastructure.Forecast
{
    public class ForecastCommands : IForecastCommands
    {
        public void DeleteForecastRecord(int ForecastRecordId)
        {
            using(var db = new DatabaseModelContainer())
            {
                var dbForecast = db.Forecasts.SingleOrDefault(x => x.Id == ForecastRecordId);

                if(dbForecast != null)
                {
                    db.Forecasts.Remove(dbForecast);
                    db.SaveChanges();
                }
            }
        }

        public void CreateForecastRecord(int temperature, int generalState, int windDirection, int windSpeed, int rainChance, string generalStateImageUrl, string generalStateCaption, string windDirectionImageUrl, DateTimeOffset date, int cityId)
        {
            using(var db = new DatabaseModelContainer())
            {

                if (db.Forecasts.SingleOrDefault(x => x.CityId == cityId && x.Date == date) == null)
                {
                    var newForecast = new MeteoWebApp.Data.Forecast()
                    {
                        Temperature = temperature,
                        GeneralState = generalState,
                        WindDirection = windDirection,
                        WindSpeed = windSpeed,
                        RainChance = rainChance,
                        GeneralStateImageUrl = generalStateImageUrl,
                        GeneralStateCaption = generalStateCaption,
                        WindDirectionImageUrl = windDirectionImageUrl,
                        Date = date,
                        CityId = cityId
                    };

                    db.Forecasts.Add(newForecast);
                    db.SaveChanges();
                }
            }
        }

        public void EditForecastRecord(int id, int temperature, int generalState, int windDirection, int windSpeed, int rainChance, string generalStateImageUrl, string generalStateCaption, string windDirectionImageUrl)
        {
            using(var db = new DatabaseModelContainer())
            {
                var dbForecast = db.Forecasts.SingleOrDefault(x => x.Id == id);

                if(dbForecast != null)
                {
                    dbForecast.Temperature = temperature;
                    dbForecast.RainChance = rainChance;
                    dbForecast.GeneralState = generalState;
                    dbForecast.GeneralStateCaption = generalStateCaption;
                    dbForecast.GeneralStateImageUrl = generalStateImageUrl;
                    dbForecast.WindSpeed = windSpeed;
                    dbForecast.WindDirection = windDirection;
                    dbForecast.WindDirectionImageUrl = windDirectionImageUrl;
                }

                db.SaveChanges();
            }
        }
    }
}
