using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoWebApp.Infrastructure.City
{
    public interface ICityQueries
    {
        string GetCityNameById(int cityId);
        IEnumerable<ICity> GetAllCities();
    }
}
