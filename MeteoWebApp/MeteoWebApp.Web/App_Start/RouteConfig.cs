using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MeteoWebApp.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("ViewForecast", "prognoza/{CityId}", new { controller = "Forecast", action = "Index" }, namespaces: new[] { "MeteoWebApp.Web.Controllers" });
            routes.MapRoute("AdminCities", "admin/gradovi", new { controller = "Admin", action = "Index" }, namespaces: new[] { "MeteoWebApp.Web.Controllers" });
            routes.MapRoute("EditForecast", "admin/uredi-prognozu/{CityId}", new { controller = "Admin", action = "EditForecast" }, namespaces: new[] { "MeteoWebApp.Web.Controllers" });
            routes.MapRoute("EditForecastRecord", "admin/uredi-zapis/{CityId}/{ForecastRecordId}", new { controller = "Admin", action = "EditForecastRecord" }, namespaces: new[] { "MeteoWebApp.Web.Controllers" });
            routes.MapRoute("DeleteForecastRecord", "admin/izbriši-zapis/{CityId}/{ForecastRecordId}", new { controller = "Admin", action = "DeleteForecastRecord" }, namespaces: new[] { "MeteoWebApp.Web.Controllers" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}