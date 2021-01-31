using IntegrationModeWebApp.IMImplementation.Interface;
using IntegrationModeWebApp.Services.Implementation;
using IntegrationModeWebApp.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static IntegrationModeWebApp.IMImplementation.Interface.IntegrationMode;

namespace IntegrationModeWebApp.IMImplementation.Implementation
{
    public static class IntegrationModeFactory
    {

        public static IntegrationMode GetIntegrationMode(IIsolatedIntegrationManager isolatedIntegration, IOracleERPIntegrationManager oracleERPIntegration, ISmartERPIntegrationManager smartERPIntegration, GeneralConfig generalConfig)
        {
            IntegrationMode integrationMode = null;            
            if (generalConfig.OrgName == IntegrationModeName.Isolated.ToString())
            {
                integrationMode = new IsolatedImplementation(isolatedIntegration);
            }
            
            else if (generalConfig.OrgName == IntegrationModeName.SmartERP.ToString())
            {
                integrationMode = new SmartERPImplementation(smartERPIntegration);
            }
            
            else if (generalConfig.OrgName == IntegrationModeName.OracleERP.ToString())
            {
                integrationMode = new OracleERPImplementaion(oracleERPIntegration);
            }

            return integrationMode;

        }

        internal enum IntegrationModeName
        {
            SmartERP,
            OracleERP,
            Isolated
        }
    }
}