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
    }
}
