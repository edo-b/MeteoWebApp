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
        void CreateForecastRecord(int Temperature, int GeneralState, int WindDirection, int WindSpeed, int RainChance, string GeneralStateImageUrl, string GeneralStateCaption, string WindDirectionImageUrl, DateTimeOffset Date, int cityId);
    }
}
