using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeteoWebApp.Web.Models
{
    public class DeleteForecastViewModel
    {
        public int              ForecastRecordId    { get; set; }
        public int              CityId              { get; set; }
        public DateTimeOffset   FirstDate           { get; set; }
    }
}