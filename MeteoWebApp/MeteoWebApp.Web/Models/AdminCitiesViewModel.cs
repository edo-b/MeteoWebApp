using MeteoWebApp.Infrastructure.City;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeteoWebApp.Web.Models
{
    public partial class AdminCitiesViewModel
    {
        public IEnumerable<ICity> Cities
        {
            get
            {
                if(_cities == null)
                {
                    _cities = new Lazy<IEnumerable<ICity>>(() => _cityQueries.GetAllCities());
                }

                return _cities.Value;
            }
        }
        private Lazy<IEnumerable<ICity>> _cities;
    }

    public partial class AdminCitiesViewModel
    {
        private ICityQueries _cityQueries;
        
        public AdminCitiesViewModel()
	    {
            _cityQueries = new CityQueries();
	    }
    }
}