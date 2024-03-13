using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace Sto.Synchronization.SAP_to_SalesForce.Console.Utility
{
    public static class ConfigurationManager
    {
        public static string GetConfigurationValueByKey(string key)
        {
            return (string.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings[key])) 
                   ? string.Empty 
                   : System.Configuration.ConfigurationManager.AppSettings[key];
        }
    }
}
