using IntegrationModeWebApp.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationModeWebApp.IMImplementation.Interface
{
    public abstract class IntegrationMode
    {
       
        public IntegrationMode()
        {
           
        }

        public abstract string SyncInformation();

        public class GeneralConfig
        {
            public string OrgName { get; set; }

            public string FilePath { get; set; }

            public string FileName { get; set; }

            public string FileExtension { get; set; }

            public string FileNameWithPathAndExtention { get; set; }

            public string[] SheetList { get; set; }

            public string SourceConnection { get; set; }

            public string DestinationConnection { get; set; }

            public string DefaultConnection { get; set; }

            public string FromDate { get; set; }

            public string Todate { get; set; }

            public string Date { get; set; }           
            
        }
    }
}