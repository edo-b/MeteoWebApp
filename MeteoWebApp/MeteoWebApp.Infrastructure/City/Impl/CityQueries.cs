using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeteoWebApp.Data;

namespace MeteoWebApp.Infrastructure.City
{
    public class CityQueries : ICityQueries
    {
        public string GetCityNameById(int cityId)
        {
            using(var db = new DatabaseModelContainer())
            {
                var dbCity = db.Cities
                                .Where(x => x.Id == cityId)
                                .SingleOrDefault();

                if(dbCity != null)
                {
                    return dbCity.Name;
                }

                return null;
            }
        }
    }
}
