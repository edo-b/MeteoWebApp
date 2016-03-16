using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoWebApp.Data.TestDataFactory
{
    public class TestDataFactory
    {
        public static void Fill()
        {
            using(var db = new DatabaseModelContainer())
            {
                if(!db.Cities.Any())
                {
                    _insertCities(db);
                    _insertForecasts(db);
                }

                db.SaveChanges();
            }
        }

        private static void _insertCities(DatabaseModelContainer db)
        {
            new[]
            {
                new City
                {
                    Id = 1,
                    Name = "Split"
                },
                new City
                {
                    Id = 2,
                    Name = "Zagreb"
                },
                new City
                {
                    Id = 3,
                    Name = "Rijeka"
                },
                new City
                {
                    Id = 4,
                    Name = "Osijek"
                },
                new City
                {
                    Id = 5,
                    Name = "Dubrovnik"
                }
            }.ToList().ForEach(city => db.Cities.Add(city));
        }

        private static void _insertForecasts(DatabaseModelContainer db)
        {
            new[]
            {
                new Forecast
                {
                    Id = 1,
                    Temperature = 10,
                    GeneralState = 1,
                    RainChance = 20,
                    WindDirection = 1,
                    WindSpeed = 0,
                    Time = new DateTime(2016, 3, 16),
                    CityId = 1
                },
                new Forecast
                {
                    Id = 2,
                    Temperature = 15,
                    GeneralState = 1,
                    RainChance = 0,
                    WindDirection = 0,
                    WindSpeed = 4,
                    Time = new DateTime(2016, 3, 16),
                    CityId = 2
                },
                new Forecast
                {
                    Id = 3,
                    Temperature = 5,
                    GeneralState = 1,
                    RainChance = 2,
                    WindDirection = 2,
                    WindSpeed = 20,
                    Time = new DateTime(2016, 3, 16),
                    CityId = 3
                },
                new Forecast
                {
                    Id = 4,
                    Temperature = 2,
                    GeneralState = 1,
                    RainChance = 60,
                    WindDirection = 3,
                    WindSpeed = 11,
                    Time = new DateTime(2016, 3, 16),
                    CityId = 4
                },
                new Forecast
                {
                    Id = 5,
                    Temperature = 7,
                    GeneralState = 1,
                    RainChance = 50,
                    WindDirection = 1,
                    WindSpeed = 3,
                    Time = new DateTime(2016, 3, 16),
                    CityId = 5
                },
                new Forecast
                {
                    Id = 6,
                    Temperature = 12,
                    GeneralState = 1,
                    RainChance = 80,
                    WindDirection = 2,
                    WindSpeed = 6,
                    Time = new DateTime(2016, 3, 17),
                    CityId = 1
                },
                new Forecast
                {
                    Id = 7,
                    Temperature = 0,
                    GeneralState = 1,
                    RainChance = 100,
                    WindDirection = 0,
                    WindSpeed = 21,
                    Time = new DateTime(2016, 3, 17),
                    CityId = 2
                },
                new Forecast
                {
                    Id = 8,
                    Temperature = -1,
                    GeneralState = 1,
                    RainChance = 25,
                    WindDirection = 3,
                    WindSpeed = 15,
                    Time = new DateTime(2016, 3, 17),
                    CityId = 3
                },
                new Forecast
                {
                    Id = 9,
                    Temperature = 4,
                    GeneralState = 1,
                    RainChance = 0,
                    WindDirection = 5,
                    WindSpeed = 18,
                    Time = new DateTime(2016, 3, 17),
                    CityId = 4
                },
                new Forecast
                {
                    Id = 10,
                    Temperature = 16,
                    GeneralState = 1,
                    RainChance = 15,
                    WindDirection = 7,
                    WindSpeed = 9,
                    Time = new DateTime(2016, 3, 17),
                    CityId = 5
                },
                new Forecast
                {
                    Id = 11,
                    Temperature = 2,
                    GeneralState = 1,
                    RainChance = 45,
                    WindDirection = 6,
                    WindSpeed = 0,
                    Time = new DateTime(2016, 3, 18),
                    CityId = 1
                },
                new Forecast
                {
                    Id = 12,
                    Temperature = -7,
                    GeneralState = 4,
                    RainChance = 25,
                    WindDirection = 1,
                    WindSpeed = 10,
                    Time = new DateTime(2016, 3, 18),
                    CityId = 2
                },
                new Forecast
                {
                    Id = 13,
                    Temperature = 6,
                    GeneralState = 1,
                    RainChance = 20,
                    WindDirection = 8,
                    WindSpeed = 8,
                    Time = new DateTime(2016, 3, 18),
                    CityId = 3
                },
                new Forecast
                {
                    Id = 14,
                    Temperature = 1,
                    GeneralState = 1,
                    RainChance = 30,
                    WindDirection = 0,
                    WindSpeed = 24,
                    Time = new DateTime(2016, 3, 18),
                    CityId = 4
                },
                new Forecast
                {
                    Id = 15,
                    Temperature = 0,
                    GeneralState = 1,
                    RainChance = 67,
                    WindDirection = 1,
                    WindSpeed = 0,
                    Time = new DateTime(2016, 3, 18),
                    CityId = 5
                },
                new Forecast
                {
                    Id = 16,
                    Temperature = 4,
                    GeneralState = 1,
                    RainChance = 32,
                    WindDirection = 4,
                    WindSpeed = 0,
                    Time = new DateTime(2016, 3, 19),
                    CityId = 1
                },
                new Forecast
                {
                    Id = 17,
                    Temperature = -1,
                    GeneralState = 1,
                    RainChance = 28,
                    WindDirection = 5,
                    WindSpeed = 6,
                    Time = new DateTime(2016, 3, 19),
                    CityId = 2
                },
                new Forecast
                {
                    Id = 18,
                    Temperature = 2,
                    GeneralState = 1,
                    RainChance = 0,
                    WindDirection = 3,
                    WindSpeed = 5,
                    Time = new DateTime(2016, 3, 19),
                    CityId = 3
                },
                new Forecast
                {
                    Id = 19,
                    Temperature = 1,
                    GeneralState = 1,
                    RainChance = 0,
                    WindDirection = 2,
                    WindSpeed = 7,
                    Time = new DateTime(2016, 3, 19),
                    CityId = 4
                },
                new Forecast
                {
                    Id = 20,
                    Temperature = 11,
                    GeneralState = 1,
                    RainChance = 0,
                    WindDirection = 7,
                    WindSpeed = 0,
                    Time = new DateTime(2016, 3, 19),
                    CityId = 4
                }
            }.ToList().ForEach(forecast => db.Forecasts.Add(forecast));
        }
    }
}
