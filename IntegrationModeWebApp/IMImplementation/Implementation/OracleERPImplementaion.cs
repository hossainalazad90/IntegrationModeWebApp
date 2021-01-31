using IntegrationModeWebApp.IMImplementation.Interface;
using IntegrationModeWebApp.Services.Interface;

namespace IntegrationModeWebApp.Services.Implementation
{
    public class OracleERPImplementaion : IntegrationMode,IEmployeeIntegration
    {
        IOracleERPIntegrationManager _oracleERPIntegration;
        public OracleERPImplementaion(IOracleERPIntegrationManager oracleERPIntegration)
        {
            _oracleERPIntegration = oracleERPIntegration;
        }

        public string SyncEmployeeInformation()
        {
            throw new System.NotImplementedException();
        }

        public override string SyncInformation()
        {
            return "Oracle";
        }
    }
}