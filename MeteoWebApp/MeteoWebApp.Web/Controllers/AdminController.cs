using MeteoWebApp.Infrastructure.Forecast;
using MeteoWebApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeteoWebApp.Web.Controllers
{
    public partial class AdminController : Controller
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteForecastRecord(DeleteForecastViewModel model)
        {
            if(model.ForecastRecordId > 0)
            {
                _forecastCommands.DeleteForecastRecord(model.ForecastRecordId);
            }
            if (model.FirstDate == null || model.FirstDate.Year < 2016)
            {
                model.FirstDate = new DateTimeOffset(new DateTime(2016, 3, 18));
            }
            if (model.CityId == null || model.CityId <= 0)
            {
                model.CityId = 1;
            }

            return RedirectToRoute("EditForecast", new { CityId = model.CityId, FirstDate = model.FirstDate});
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("CreateForecastRecord")]
        public ActionResult CreateForecastRecord_post(CreateForecastViewModel model)
        {
            if(model.ValidateInputValues())
            {
                model.PrepareDataForStoring();
                _forecastCommands.CreateForecastRecord(model.Temperature, model.GeneralState, model.WindDirection, model.WindSpeed, model.RainChance, model.GeneralStateImageUrl, model.GeneralStateCaption, model.WindDirectionImageUrl, model.Date, model.CityId);
            }

            return RedirectToRoute("EditForecast", new { CityId = model.CityId, FirstDate = model.FirstDate });
        }
    }

    public partial class AdminController
    {
        private IForecastCommands _forecastCommands;

        public AdminController()
        {
            _forecastCommands = new ForecastCommands();
        }
    }
}
