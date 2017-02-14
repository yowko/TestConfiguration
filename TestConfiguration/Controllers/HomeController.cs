using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
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

        public ActionResult Action4()
        {
            var configFile = Path.Combine(Server.MapPath("~/App_Data"), "setting.config");
            //var section = ConfigurationManager.GetSection("yowkoSettingGroup/yowko");
            ConfigurationFileMap fileMap = new ConfigurationFileMap(configFile);
            //System.Configuration.Configuration managerConfiguration = System.Configuration.ConfigurationManager.OpenMappedMachineConfiguration(fileMap);
            YowkoSettings managerConfiguration =
                System.Configuration.ConfigurationManager.OpenMappedMachineConfiguration(fileMap).GetSection("yowko") as YowkoSettings;

            var test = managerConfiguration.yowkoSettings.Select(a => new DataSetting { Channel = a.Channel, UserName = a.UserName, UserSecret = a.UserSecret }).ToList();
            return View(managerConfiguration);
        }

        public ActionResult About()
        {
            var section = ConfigurationManager.GetSection("yowkoSettingGroup/yowkoSetting");// as YowkoSettingsSection;
            return View(section);
        }
    }
}