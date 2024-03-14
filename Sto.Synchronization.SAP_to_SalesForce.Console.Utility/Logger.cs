using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sto.Synchronization.SAP_to_SalesForce.Console.Utility
{
    public sealed class Logger
    {
        Logger() {
            Log.Logger = new LoggerConfiguration()
               .MinimumLevel.Debug()
               .WriteTo.File(ConfigurationManager.GetConfigurationValueByKey("logFilePath"), rollingInterval: RollingInterval.Day)
               .CreateLogger();

        }
        private static readonly object block = new object();
        private static Logger instance = null;
        public static Logger Instance
        {
            get
            {
                lock (block)
                {
                    if (instance == null)
                    {
                        instance = new Logger();
                    }
                    return instance;
                }
            }
        }

        public void WriteInformation(string message, bool isFull = false)
        {
           // if (!isFull || Environment.fullRegisterLog)
           Log.Information(string.Format("STO - [{0}]", message));
        }

        public void WriteError(string message)
        {
            Log.Error(string.Format("STO - [{0}]", message));
        }
    }
}
