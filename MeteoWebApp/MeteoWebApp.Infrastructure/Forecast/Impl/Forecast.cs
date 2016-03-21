using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoWebApp.Infrastructure.Forecast
{
    public class Forecast : IForecast
    {
        public int              Id              { get; set; }
        public int              Temperature     { get; set; }
        public int              GeneralState    { get; set; }
        public int              WindDirection   { get; set; }
        public int              WindSpeed       { get; set; }
        public int              RainChance      { get; set; }
        public DateTimeOffset   Time            { get; set; }
    }
}
