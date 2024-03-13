using NPOI.SS.Formula.Functions;
using Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic.Class;
using Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic.Interface;
using Sto.Synchronization.SAP_to_SalesForce.Console.Common;
using Sto.Synchronization.SAP_to_SalesForce.Console.Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic
{
    public class FileManager : IDisposable
    {
        private ISynchronizerCreator _synchronizerCreator;

        public FileManager(ISynchronizerCreator synchronizerCreator)
        {
            _synchronizerCreator = synchronizerCreator;
        }
        //Ejecutamos nuestro exec que lo ejecuta el program aca es donde entra primera vea el programa
        //obtenemos la configuracion de los archivos 
        //obtenemos la clase para cada archivo 
        public void Execute()
        {
            IEnumerable<FilesConfig> allConfigFiles = GetConfigurationFiles();
            foreach (FilesConfig configFile in allConfigFiles)
            {
                var fileProcessor = _synchronizerCreator.GetSynchronizerObject(configFile.Id);
                //var obtainClass = GetFileType(configFile.Id);
                var result = fileProcessor.SynchronizeDataAsync(configFile);
            }
        }
        //obtenemos la configuración de todos los archivos
        public static IEnumerable<FilesConfig> GetConfigurationFiles()
        {
            string jsonFilesConfig = File.ReadAllText(ConfigurationManager.GetConfigurationValueByKey("filesConfigPath"));
            return Extender.DeSerializeObject<IEnumerable<FilesConfig>>(jsonFilesConfig);
            
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

