using IntegrationModeWebApp.IMImplementation.Implementation;
using IntegrationModeWebApp.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGrease.Configuration;
using static IntegrationModeWebApp.IMImplementation.Implementation.IntegrationModeFactory;
using static IntegrationModeWebApp.IMImplementation.Interface.IntegrationMode;

namespace IntegrationModeWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IIsolatedIntegrationManager _isolatedIntegration;
        private readonly IOracleERPIntegrationManager _oracleERPIntegration;
        private readonly ISmartERPIntegrationManager _smartERPIntegration;

        public HomeController(IIsolatedIntegrationManager isolatedIntegration, IOracleERPIntegrationManager oracleERPIntegration, ISmartERPIntegrationManager smartERPIntegration)
        {
            _isolatedIntegration = isolatedIntegration;
            _oracleERPIntegration = oracleERPIntegration;
            _smartERPIntegration = smartERPIntegration;
        }
        public ActionResult Index()
        {
            var generalConfig = new GeneralConfig();
            generalConfig.OrgName = IntegrationModeName.Isolated.ToString();
            var integrationMode= IntegrationModeFactory.GetIntegrationMode(_isolatedIntegration, _oracleERPIntegration, _smartERPIntegration, generalConfig);
            var result= integrationMode?.SyncInformation();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}