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

        public ActionResult Index2()
        {
            YowkoConfigSectionHandler clientConfiguration = ConfigurationManager.GetSection("yowkoData") as YowkoConfigSectionHandler;

            return View(clientConfiguration);
        }
        public ActionResult Index3()
        {
            yowkoConfigSection clientConfiguration = ConfigurationManager.GetSection("yowkoDataGroup1/yowkoConfig") as yowkoConfigSection;

            return View(clientConfiguration);
        }



        public ActionResult About()
        {
            var section = ConfigurationManager.GetSection("yowkoSettingGroup/yowkoSetting");// as YowkoSettingsSection;
            return View(section);
        }
    }
}