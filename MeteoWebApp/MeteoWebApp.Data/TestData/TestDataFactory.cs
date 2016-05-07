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
                    _insertUsers(db);
                    _insertWarnings(db);
                }

                db.SaveChanges();
            }
        }

        private static void _insertUsers(DatabaseModelContainer db)
        {
            new[]
            {
                new User
                {
                    Id = 1,
                    Username = "admin",
                    Password = "9c1de23a6e94f017a0d32d40e777fb94223a6fe3",
                    Salt = "12345678"
                },
                new User
                {
                    Id = 2,
                    Username = "vakula",
                    Password = "2e7948f362e627fdb96f3169b5e99c89f613c289",
                    Salt = "abcdefgh"
                }
            }.ToList().ForEach(user => db.Users.Add(user));
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
                    Date = new DateTime(2016, 3, 16),
                    CityId = 1,
                    GeneralStateImageUrl = "/Content/Images/WeatherImages/Status-weather-clear-icon.png",
                    GeneralStateCaption = "Sunčano",
                    WindDirectionImageUrl = "/Content/Images/WindArrows/ArrowRight.png"
                },
                new Forecast
                {
                    Id = 2,
                    Temperature = 15,
                    GeneralState = 1,
                    RainChance = 0,
                    WindDirection = 0,
                    WindSpeed = 4,
                    Date = new DateTime(2016, 3, 16),
                    CityId = 2,
                    GeneralStateImageUrl = "/Content/Images/WeatherImages/Status-weather-clear-icon.png",
                    GeneralStateCaption = "Sunčano",
                    WindDirectionImageUrl = "/Content/Images/WindArrows/ArrowLeft.png"
                },
                new Forecast
                {
                    Id = 3,
                    Temperature = 5,
                    GeneralState = 1,
                    RainChance = 2,
                    WindDirection = 2,
                    WindSpeed = 20,
                    Date = new DateTime(2016, 3, 16),
                    CityId = 3,
                    GeneralStateImageUrl = "/Content/Images/WeatherImages/Status-weather-clear-icon.png",
                    GeneralStateCaption = "Sunčano",
                    WindDirectionImageUrl = "/Content/Images/WindArrows/ArrowUp.png"
                },
                new Forecast
                {
                    Id = 4,
                    Temperature = 2,
                    GeneralState = 1,
                    RainChance = 60,
                    WindDirection = 3,
                    WindSpeed = 11,
                    Date = new DateTime(2016, 3, 16),
                    CityId = 4,
                    GeneralStateImageUrl = "/Content/Images/WeatherImages/Status-weather-clear-icon.png",
                    GeneralStateCaption = "Sunčano",
                    WindDirectionImageUrl = "/Content/Images/WindArrows/ArrowDown.png"
                },
                new Forecast
                {
                    Id = 5,
                    Temperature = 7,
                    GeneralState = 1,
                    RainChance = 50,
                    WindDirection = 1,
                    WindSpeed = 3,
                    Date = new DateTime(2016, 3, 16),
                    CityId = 5,
                    GeneralStateImageUrl = "/Content/Images/WeatherImages/Status-weather-clear-icon.png",
                    GeneralStateCaption = "Sunčano",
                    WindDirectionImageUrl = "/Content/Images/WindArrows/ArrowUpRight.png"
                },
                new Forecast
                {
                    Id = 6,
                    Temperature = 12,
                    GeneralState = 1,
                    RainChance = 80,
                    WindDirection = 2,
                    WindSpeed = 6,
                    Date = new DateTime(2016, 3, 17),
                    CityId = 1,
                    GeneralStateImageUrl = "/Content/Images/WeatherImages/Status-weather-many-clouds-icon.png",
                    GeneralStateCaption = "Oblačno",
                    WindDirectionImageUrl = "/Content/Images/WindArrows/ArrowUpRight.png"
                },
                new Forecast
                {
                    Id = 7,
                    Temperature = 0,
                    GeneralState = 1,
                    RainChance = 100,
                    WindDirection = 0,
                    WindSpeed = 21,
                    Date = new DateTime(2016, 3, 17),
                    CityId = 2,
                    GeneralStateImageUrl = "/Content/Images/WeatherImages/Status-weather-many-clouds-icon.png",
                    GeneralStateCaption = "Oblačno",
                    WindDirectionImageUrl = "/Content/Images/WindArrows/ArrowDownLeft.png"
                },
                new Forecast
                {
                    Id = 8,
                    Temperature = -1,
                    GeneralState = 1,
                    RainChance = 25,
                    WindDirection = 3,
                    WindSpeed = 15,
                    Date = new DateTime(2016, 3, 17),
                    CityId = 3,
                    GeneralStateImageUrl = "/Content/Images/WeatherImages/Status-weather-many-clouds-icon.png",
                    GeneralStateCaption = "Oblačno",
                    WindDirectionImageUrl = "/Content/Images/WindArrows/ArrowDown.png"
                },
                new Forecast
                {
                    Id = 9,
                    Temperature = 4,
                    GeneralState = 1,
                    RainChance = 0,
                    WindDirection = 5,
                    WindSpeed = 18,
                    Date = new DateTime(2016, 3, 17),
                    CityId = 4,
                    GeneralStateImageUrl = "/Content/Images/WeatherImages/Status-weather-many-clouds-icon.png",
                    GeneralStateCaption = "Oblačno",
                    WindDirectionImageUrl = "/Content/Images/WindArrows/ArrowUp.png"
                },
                new Forecast
                {
                    Id = 10,
                    Temperature = 16,
                    GeneralState = 1,
                    RainChance = 15,
                    WindDirection = 7,
                    WindSpeed = 9,
                    Date = new DateTime(2016, 3, 17),
                    CityId = 5,
                    GeneralStateImageUrl = "/Content/Images/WeatherImages/Status-weather-many-clouds-icon.png",
                    GeneralStateCaption = "Oblačno",
                    WindDirectionImageUrl = "/Content/Images/WindArrows/ArrowLeft.png"
                },
                new Forecast
                {
                    Id = 11,
                    Temperature = 2,
                    GeneralState = 1,
                    RainChance = 45,
                    WindDirection = 6,
                    WindSpeed = 0,
                    Date = new DateTime(2016, 3, 18),
                    CityId = 1,
                    GeneralStateImageUrl = "/Content/Images/WeatherImages/Status-weather-clouds-icon.png",
                    GeneralStateCaption = "Djelomično oblačno",
                    WindDirectionImageUrl = "/Content/Images/WindArrows/ArrowDown.png"
                },
                new Forecast
                {
                    Id = 12,
                    Temperature = -7,
                    GeneralState = 4,
                    RainChance = 25,
                    WindDirection = 1,
                    WindSpeed = 10,
                    Date = new DateTime(2016, 3, 18),
                    CityId = 2,
                    GeneralStateImageUrl = "/Content/Images/WeatherImages/Status-weather-clouds-icon.png",
                    GeneralStateCaption = "Djelomično oblačno",
                    WindDirectionImageUrl = "/Content/Images/WindArrows/ArrowRight.png"
                },
                new Forecast
                {
                    Id = 13,
                    Temperature = 6,
                    GeneralState = 1,
                    RainChance = 20,
                    WindDirection = 8,
                    WindSpeed = 8,
                    Date = new DateTime(2016, 3, 18),
                    CityId = 3,
                    GeneralStateImageUrl = "/Content/Images/WeatherImages/Status-weather-clouds-icon.png",
                    GeneralStateCaption = "Djelomično oblačno",
                    WindDirectionImageUrl = "/Content/Images/WindArrows/ArrowDownLeft.png"
                },
                new Forecast
                {
                    Id = 14,
                    Temperature = 1,
                    GeneralState = 1,
                    RainChance = 30,
                    WindDirection = 0,
                    WindSpeed = 24,
                    Date = new DateTime(2016, 3, 18),
                    CityId = 4,
                    GeneralStateImageUrl = "/Content/Images/WeatherImages/Status-weather-clouds-icon.png",
                    GeneralStateCaption = "Djelomično oblačno",
                    WindDirectionImageUrl = "/Content/Images/WindArrows/ArrowDownRight.png"
                },
                new Forecast
                {
                    Id = 15,
                    Temperature = 0,
                    GeneralState = 1,
                    RainChance = 67,
                    WindDirection = 1,
                    WindSpeed = 0,
                    Date = new DateTime(2016, 3, 18),
                    CityId = 5,
                    GeneralStateImageUrl = "/Content/Images/WeatherImages/Status-weather-clouds-icon.png",
                    GeneralStateCaption = "Djelomično oblačno",
                    WindDirectionImageUrl = "/Content/Images/WindArrows/ArrowUpRight.png"
                },
                new Forecast
                {
                    Id = 16,
                    Temperature = 4,
                    GeneralState = 1,
                    RainChance = 32,
                    WindDirection = 4,
                    WindSpeed = 0,
                    Date = new DateTime(2016, 3, 19),
                    CityId = 1,
                    GeneralStateImageUrl = "/Content/Images/WeatherImages/Status-weather-showers-scattered-icon.png",
                    GeneralStateCaption = "Kiša",
                    WindDirectionImageUrl = "/Content/Images/WindArrows/ArrowUpLeft.png"
                },
                new Forecast
                {
                    Id = 17,
                    Temperature = -1,
                    GeneralState = 1,
                    RainChance = 28,
                    WindDirection = 5,
                    WindSpeed = 6,
                    Date = new DateTime(2016, 3, 19),
                    CityId = 2,
                    GeneralStateImageUrl = "/Content/Images/WeatherImages/Status-weather-snow-scattered-icon.png",
                    GeneralStateCaption = "Snijeg",
                    WindDirectionImageUrl = "/Content/Images/WindArrows/ArrowUpLeft.png"
                },
                new Forecast
                {
                    Id = 18,
                    Temperature = 2,
                    GeneralState = 1,
                    RainChance = 0,
                    WindDirection = 3,
                    WindSpeed = 5,
                    Date = new DateTime(2016, 3, 19),
                    CityId = 3,
                    GeneralStateImageUrl = "/Content/Images/WeatherImages/Status-weather-storm-night-icon.png",
                    GeneralStateCaption = "Pljusak s grmljavinom",
                    WindDirectionImageUrl = "/Content/Images/WindArrows/ArrowUpLeft.png"
                },
                new Forecast
                {
                    Id = 19,
                    Temperature = 1,
                    GeneralState = 1,
                    RainChance = 0,
                    WindDirection = 2,
                    WindSpeed = 7,
                    Date = new DateTime(2016, 3, 19),
                    CityId = 4,
                    GeneralStateImageUrl = "/Content/Images/WeatherImages/Status-weather-showers-scattered-icon.png",
                    GeneralStateCaption = "Kiša",
                    WindDirectionImageUrl = "/Content/Images/WindArrows/ArrowUpLeft.png"
                },
                new Forecast
                {
                    Id = 20,
                    Temperature = 11,
                    GeneralState = 1,
                    RainChance = 0,
                    WindDirection = 7,
                    WindSpeed = 0,
                    Date = new DateTime(2016, 3, 19),
                    CityId = 5,
                    GeneralStateImageUrl = "/Content/Images/WeatherImages/Status-weather-showers-scattered-icon.png",
                    GeneralStateCaption = "Kiša",
                    WindDirectionImageUrl = "/Content/Images/WindArrows/ArrowUpLeft.png"
                }
            }.ToList().ForEach(forecast => db.Forecasts.Add(forecast));
        }

        private static void _insertWarnings(DatabaseModelContainer db)
        {
            new[]
            {
                new Warning
                {
                    Id = 1,
                    TItle = "Lorem ipsum",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ut nulla quis dolor volutpat mollis. Proin ligula ex, tincidunt at purus a, mollis posuere eros.",
                    PublishedOn = new DateTimeOffset(2016, 5, 1, 0, 0, 0, new TimeSpan(0)),
                    PublishedBy = "admin"
                },
                new Warning
                {
                    Id = 2,
                    TItle = "Lorem ipsum",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ut nulla quis dolor volutpat mollis. Proin ligula ex, tincidunt at purus a, mollis posuere eros.",
                    PublishedOn = new DateTimeOffset(2016, 5, 2, 0, 0, 0, new TimeSpan(0)),
                    PublishedBy = "vakula"
                },
                new Warning
                {
                    Id = 3,
                    TItle = "Lorem ipsum",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ut nulla quis dolor volutpat mollis. Proin ligula ex, tincidunt at purus a, mollis posuere eros.",
                    PublishedOn = new DateTimeOffset(2016, 5, 1, 0, 0, 0, new TimeSpan(0)),
                    PublishedBy = "admin"
                },
                new Warning
                {
                    Id = 4,
                    TItle = "Lorem ipsum",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ut nulla quis dolor volutpat mollis. Proin ligula ex, tincidunt at purus a, mollis posuere eros.",
                    PublishedOn = new DateTimeOffset(2016, 4, 1, 0, 0, 0, new TimeSpan(0)),
                    PublishedBy = "admin"
                },
                new Warning
                {
                    Id = 5,
                    TItle = "Lorem ipsum",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ut nulla quis dolor volutpat mollis. Proin ligula ex, tincidunt at purus a, mollis posuere eros.",
                    PublishedOn = new DateTimeOffset(2016, 4, 12, 0, 0, 0, new TimeSpan(0)),
                    PublishedBy = "admin"
                },
                new Warning
                {
                    Id = 6,
                    TItle = "Lorem ipsum",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ut nulla quis dolor volutpat mollis. Proin ligula ex, tincidunt at purus a, mollis posuere eros.",
                    PublishedOn = new DateTimeOffset(2016, 4, 21, 0, 0, 0, new TimeSpan(0)),
                    PublishedBy = "vakula"
                },
                new Warning
                {
                    Id = 7,
                    TItle = "Lorem ipsum",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ut nulla quis dolor volutpat mollis. Proin ligula ex, tincidunt at purus a, mollis posuere eros.",
                    PublishedOn = new DateTimeOffset(2016, 5, 3, 0, 0, 0, new TimeSpan(0)),
                    PublishedBy = "admin"
                },
                new Warning
                {
                    Id = 8,
                    TItle = "Lorem ipsum",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ut nulla quis dolor volutpat mollis. Proin ligula ex, tincidunt at purus a, mollis posuere eros.",
                    PublishedOn = new DateTimeOffset(2016, 5, 6, 0, 0, 0, new TimeSpan(0)),
                    PublishedBy = "vakula"
                },
                new Warning
                {
                    Id = 9,
                    TItle = "Lorem ipsum",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ut nulla quis dolor volutpat mollis. Proin ligula ex, tincidunt at purus a, mollis posuere eros.",
                    PublishedOn = new DateTimeOffset(2016, 5, 4, 0, 0, 0, new TimeSpan(0)),
                    PublishedBy = "admin"
                },
                new Warning
                {
                    Id = 1,
                    TItle = "Lorem ipsum",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ut nulla quis dolor volutpat mollis. Proin ligula ex, tincidunt at purus a, mollis posuere eros.",
                    PublishedOn = new DateTimeOffset(2016, 5, 5, 0, 0, 0, new TimeSpan(0)),
                    PublishedBy = "vakula"
                },
                new Warning
                {
                    Id = 10,
                    TItle = "Lorem ipsum",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ut nulla quis dolor volutpat mollis. Proin ligula ex, tincidunt at purus a, mollis posuere eros.",
                    PublishedOn = new DateTimeOffset(2016, 3, 28, 0, 0, 0, new TimeSpan(0)),
                    PublishedBy = "admin"
                },
                new Warning
                {
                    Id = 11,
                    TItle = "Lorem ipsum",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ut nulla quis dolor volutpat mollis. Proin ligula ex, tincidunt at purus a, mollis posuere eros.",
                    PublishedOn = new DateTimeOffset(2016, 3, 18, 0, 0, 0, new TimeSpan(0)),
                    PublishedBy = "admin"
                },
                new Warning
                {
                    Id = 12,
                    TItle = "Lorem ipsum",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ut nulla quis dolor volutpat mollis. Proin ligula ex, tincidunt at purus a, mollis posuere eros.",
                    PublishedOn = new DateTimeOffset(2016, 4, 6, 0, 0, 0, new TimeSpan(0)),
                    PublishedBy = "admin"
                },
                new Warning
                {
                    Id = 13,
                    TItle = "Lorem ipsum",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ut nulla quis dolor volutpat mollis. Proin ligula ex, tincidunt at purus a, mollis posuere eros.",
                    PublishedOn = new DateTimeOffset(2016, 4, 13, 0, 0, 0, new TimeSpan(0)),
                    PublishedBy = "admin"
                },
                new Warning
                {
                    Id = 14,
                    TItle = "Lorem ipsum",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ut nulla quis dolor volutpat mollis. Proin ligula ex, tincidunt at purus a, mollis posuere eros.",
                    PublishedOn = new DateTimeOffset(2016, 3, 12, 0, 0, 0, new TimeSpan(0)),
                    PublishedBy = "admin"
                },
                new Warning
                {
                    Id = 15,
                    TItle = "Lorem ipsum",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ut nulla quis dolor volutpat mollis. Proin ligula ex, tincidunt at purus a, mollis posuere eros.",
                    PublishedOn = new DateTimeOffset(2016, 4, 30, 0, 0, 0, new TimeSpan(0)),
                    PublishedBy = "admin"
                },
                new Warning
                {
                    Id = 16,
                    TItle = "Lorem ipsum",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ut nulla quis dolor volutpat mollis. Proin ligula ex, tincidunt at purus a, mollis posuere eros.",
                    PublishedOn = new DateTimeOffset(2016, 5, 1, 0, 0, 0, new TimeSpan(0)),
                    PublishedBy = "admin"
                },
                new Warning
                {
                    Id = 17,
                    TItle = "Lorem ipsum",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ut nulla quis dolor volutpat mollis. Proin ligula ex, tincidunt at purus a, mollis posuere eros.",
                    PublishedOn = new DateTimeOffset(2016, 2, 11, 0, 0, 0, new TimeSpan(0)),
                    PublishedBy = "admin"
                },
                new Warning
                {
                    Id = 18,
                    TItle = "Lorem ipsum",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ut nulla quis dolor volutpat mollis. Proin ligula ex, tincidunt at purus a, mollis posuere eros.",
                    PublishedOn = new DateTimeOffset(2016, 2, 5, 0, 0, 0, new TimeSpan(0)),
                    PublishedBy = "admin"
                },
                new Warning
                {
                    Id = 19,
                    TItle = "Lorem ipsum",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ut nulla quis dolor volutpat mollis. Proin ligula ex, tincidunt at purus a, mollis posuere eros.",
                    PublishedOn = new DateTimeOffset(2016, 5, 6, 0, 0, 0, new TimeSpan(0)),
                    PublishedBy = "admin"
                },
                new Warning
                {
                    Id = 20,
                    TItle = "Lorem ipsum",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ut nulla quis dolor volutpat mollis. Proin ligula ex, tincidunt at purus a, mollis posuere eros.",
                    PublishedOn = new DateTimeOffset(2016, 3, 31, 0, 0, 0, new TimeSpan(0)),
                    PublishedBy = "admin"
                },
                new Warning
                {
                    Id = 21,
                    TItle = "Lorem ipsum",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ut nulla quis dolor volutpat mollis. Proin ligula ex, tincidunt at purus a, mollis posuere eros.",
                    PublishedOn = new DateTimeOffset(2016, 3, 2, 0, 0, 0, new TimeSpan(0)),
                    PublishedBy = "admin"
                },
                new Warning
                {
                    Id = 22,
                    TItle = "Lorem ipsum",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ut nulla quis dolor volutpat mollis. Proin ligula ex, tincidunt at purus a, mollis posuere eros.",
                    PublishedOn = new DateTimeOffset(2016, 4, 15, 0, 0, 0, new TimeSpan(0)),
                    PublishedBy = "admin"
                },
                new Warning
                {
                    Id = 23,
                    TItle = "Lorem ipsum",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ut nulla quis dolor volutpat mollis. Proin ligula ex, tincidunt at purus a, mollis posuere eros.",
                    PublishedOn = new DateTimeOffset(2016, 4, 17, 0, 0, 0, new TimeSpan(0)),
                    PublishedBy = "admin"
                }
            }.ToList().ForEach(x => db.Warnings.Add(x));
        }
    }
}
