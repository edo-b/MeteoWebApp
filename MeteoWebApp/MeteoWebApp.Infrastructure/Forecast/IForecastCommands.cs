using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoWebApp.Infrastructure.Forecast
{
    public interface IForecastCommands
    {
        void DeleteForecastRecord(int ForecastRecordId);
        void CreateForecastRecord(int temperature, int generalState, int windDirection, int windSpeed, int rainChance, string generalStateImageUrl, string generalStateCaption, string windDirectionImageUrl, DateTimeOffset date, int cityId);
        void EditForecastRecord(int id, int temperature, int generalState, int windDirection, int windSpeed, int rainChance, string generalStateImageUrl, string generalStateCaption, string windDirectionImageUrl);
    }
}
