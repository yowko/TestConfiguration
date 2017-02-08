using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestConfiguration.Handler;

namespace TestConfiguration.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            YowkoConfigSectionHandler clientConfiguration = ConfigurationManager.GetSection("yowkoDataGroup/yowkoData") as YowkoConfigSectionHandler;

            return View(clientConfiguration);
        }
    }
}