using MeteoWebApp.Infrastructure.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MeteoWebApp.Web.Controllers
{
    public partial class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Login()
        {
            if (Request.IsAuthenticated)
            {
                return RedirectToRoute("AdminCities");
            }
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string username, string password)
        {
            if(!String.IsNullOrEmpty(username) && !String.IsNullOrEmpty(password))
            {
                var salt = _userQueries.GetUserSalt(username);
                password = FormsAuthentication.HashPasswordForStoringInConfigFile(password + salt, "SHA1");

                var isUserValid = _userQueries.ValidateUser(username, password);

                if (isUserValid)
                {
                    FormsAuthentication.SetAuthCookie(username, false);
                    return RedirectToRoute("AdminCities");
                }
            }

            ViewBag.Error = true;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

    }

    public partial class AccountController
    {
        private IUserQueries _userQueries = new UserQueries();
    }
}
