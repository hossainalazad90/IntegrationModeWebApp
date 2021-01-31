using Autofac;
using Autofac.Integration.Mvc;
using IntegrationModeWebApp.Services.Implementation;
using IntegrationModeWebApp.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace IntegrationModeWebApp.App_Start
{

    public class AutofacConfig
    {
        public static void RegisterComponent()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<IsolatedIntegrationManager>().As<IIsolatedIntegrationManager>();
            builder.RegisterType<OracleERPIntegrationManager>().As<IOracleERPIntegrationManager>();
            builder.RegisterType<SmartERPIntegrationManager>().As<ISmartERPIntegrationManager>();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}