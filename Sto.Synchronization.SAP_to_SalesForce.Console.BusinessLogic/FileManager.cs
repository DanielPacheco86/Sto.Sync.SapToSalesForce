using Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic.Interface;
using Sto.Synchronization.SAP_to_SalesForce.Console.Common;
using Sto.Synchronization.SAP_to_SalesForce.Console.Utility;

namespace Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic
{
    public class FileManager : IDisposable
    {
        private ISynchronizerCreator _synchronizerCreator;

        public FileManager(ISynchronizerCreator synchronizerCreator)
        {
            _synchronizerCreator = synchronizerCreator;
        }

        public void Execute()
        {
            Utility.Logger.Instance.WriteInformation("Starting process getting the class per configuration");
            IEnumerable<FileConfig> allConfigFiles = GetConfigurationFiles();
            foreach (FileConfig configFile in allConfigFiles)
            {
                var fileProcessor = _synchronizerCreator.GetSynchronizerObject(configFile.Id);
                var result = fileProcessor.SynchronizeDataAsync(configFile);
            }
        }
        public static IEnumerable<FileConfig> GetConfigurationFiles()
        {
            Utility.Logger.Instance.WriteInformation("Getting configuration files and desearizable configuration data");
            string jsonFilesConfig = File.ReadAllText(ConfigurationManager.GetConfigurationValueByKey("filesConfigPath"));
            return Extender.DeSerializeObject<IEnumerable<FileConfig>>(jsonFilesConfig);
            
        }

        #region Region [Dispose]
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~FileManager()
        {
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {

            }
        }
        #endregion
    }
}

