using MeteoWebApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeteoWebApp.Web.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index(AdminCitiesViewModel model)
        {
            return View(model);
        }

        public ActionResult EditForecast(ForecastViewModel model)
        {
            if (model.FirstDate == null || model.FirstDate.Year < 2016)
            {
                model.FirstDate = new DateTimeOffset(new DateTime(2016, 3, 18));
            }
            if (model.CityId == null || model.CityId <= 0)
            {
                model.CityId = 1;
            }
            
            return View(model);
        }

        public string EditForecastRecord()
        {
            return "Test";
        }

        public string DeleteForecastRecord()
        {
            return "Test";
        }
    }
}
