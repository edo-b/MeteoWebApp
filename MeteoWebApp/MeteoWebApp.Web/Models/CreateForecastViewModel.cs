using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeteoWebApp.Web.Models
{
    public partial class CreateForecastViewModel
    {
        public int CityId { get; set; }
        public DateTimeOffset Date { get; set; }
        public DateTimeOffset FirstDate { get; set; }
    }

    public partial class CreateForecastViewModel
    {
        public bool ValidateInputValues()
        {
            //validate this object
            return true;
        }
    }
}