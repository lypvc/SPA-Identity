﻿using System.Web.Mvc;

namespace SinglePageApplication.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
