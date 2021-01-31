using IntegrationModeWebApp.IMImplementation.Interface;
using IntegrationModeWebApp.Services.Interface;

namespace IntegrationModeWebApp.Services.Implementation
{
    public  class IsolatedImplementation:IntegrationMode
    {
        private readonly IIsolatedIntegrationManager _isolatedIntegration;
        public IsolatedImplementation(IIsolatedIntegrationManager isolatedIntegration)
        {
            _isolatedIntegration = isolatedIntegration;
        }

        public override string SyncInformation()
        {
            return "Isolated";
        }
    }
}