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
    }
}
