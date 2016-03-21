using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MeteoWebApp.Infrastructure.Forecast;
using MeteoWebApp.Infrastructure.City;

namespace MeteoWebApp.Web.Models
{
    public partial class ForecastViewModel
    {
        public int CityId { get; set; }
        public DateTimeOffset FirstDate { get; set; }
    }

    public partial class ForecastViewModel
    {
        public IEnumerable<IForecast> Forecasts
        {
            get
            {
                if(_forecasts == null)
                {
                    _forecasts = new Lazy<IEnumerable<IForecast>>(() => _forecastQueries.GetForecastForCityByWeek(CityId, FirstDate));
                }
                return _forecasts.Value;
            }
        }
        private Lazy<IEnumerable<IForecast>> _forecasts;

        public string City
        {
            get
            {
                return _cityQueries.GetCityNameById(CityId);
            }
        }
    }

    public partial class ForecastViewModel
    {
        private IForecastQueries _forecastQueries;
        private ICityQueries _cityQueries;
        public ForecastViewModel ()
	    {
            _forecastQueries = new ForecastQueries();
            _cityQueries = new CityQueries();
	    }
    }
}