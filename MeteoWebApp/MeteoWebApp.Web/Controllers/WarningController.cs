using MeteoWebApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeteoWebApp.Web.Controllers
{
    public class WarningController : Controller
    {
        //
        // GET: /Warning/

        public ActionResult Index(WarningViewModel model)
        {
            if(model.PageNumber <= 0)
            {
                model.PageNumber = 1;
            }
            
            return View(model);
        }

    }
}
