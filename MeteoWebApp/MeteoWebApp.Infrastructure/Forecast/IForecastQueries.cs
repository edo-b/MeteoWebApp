using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoWebApp.Infrastructure.Forecast
{
    public interface IForecastQueries
    {
        IEnumerable<IForecast> GetForecastForCityByWeek(int cityId, DateTimeOffset firstDate);
    }
}
