using IntegrationModeWebApp.IMImplementation.Interface;
using IntegrationModeWebApp.Services.Interface;

namespace IntegrationModeWebApp.Services.Implementation
{
    public class SmartERPImplementation : IntegrationMode
    {
        ISmartERPIntegrationManager _smartERPIntegration;
        public SmartERPImplementation(ISmartERPIntegrationManager smartERPIntegration)
        {
            _smartERPIntegration = smartERPIntegration;
        }

        public override string SyncInformation()
        {
            return "SmartERP";
        }
    }
}