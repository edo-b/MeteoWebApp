using MeteoWebApp.Infrastructure.Forecast;
using MeteoWebApp.Infrastructure.Warning;
using MeteoWebApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeteoWebApp.Web.Controllers
{
    [Authorize]
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
            if (model.CityId <= 0)
            {
                model.CityId = 1;
            }
            
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditForecastRecord(EditForecastViewModel model)
        {
            if (model.ValidateInputValues())
            {
                model.PrepareDataForStoring();
                _forecastCommands.EditForecastRecord(model.ForecastRecordId, model.Temperature, model.GeneralStateEdit, model.WindDirectionEdit, model.WindSpeed, model.RainChance, model.GeneralStateImageUrl, model.GeneralStateCaption, model.WindDirectionImageUrl);
            }

            return RedirectToRoute("EditForecast", new { CityId = model.CityId, FirstDate = model.FirstDate });
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
            if (model.CityId <= 0)
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

        public ActionResult EditWarnings(WarningViewModel model)
        {
            if(model.PageNumber <= 0)
            {
                model.PageNumber = 1;
            }
            
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteWarning(int WarningId, int PageNumber)
        {
            if(WarningId > 0)
            {
                _warningCommands.DeleteWarning(WarningId);
            }
            if(PageNumber <= 0)
            {
                PageNumber = 1;
            }

            return RedirectToRoute("EditWarnings", new { PageNumber = PageNumber });
        }

        public ActionResult CreateWarning()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("CreateWarning")]
        public ActionResult CreateWarning_post(CreateWarningViewModel model)
        {
            if(model.ValidateInputValues())
            {
                var publishedOn = new DateTimeOffset(DateTime.Now);
                var publishedBy = User.Identity.Name;

                _warningCommands.CreateWarning(model.Title, model.Text, publishedBy, publishedOn);
            }

            return RedirectToRoute("EditWarnings", new { PageNumber = 1 });
        }
    }

    public partial class AdminController
    {
        private IForecastCommands _forecastCommands;
        private IWarningCommands _warningCommands;

        public AdminController()
        {
            _forecastCommands = new ForecastCommands();
            _warningCommands = new WarningCommands();
        }
    }
}
