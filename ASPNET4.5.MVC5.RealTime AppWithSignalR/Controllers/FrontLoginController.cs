using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNET4._5.MVC5.RealTime_AppWithSignalR.Controllers
{
    public class FrontLoginController : Controller
    {
        // GET: FrontLogin
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Test_Login()
        {           
            return RedirectToAction("Index", "AdminHome");
        }
    }
}