using Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic.Class;
using Sto.Synchronization.SAP_to_SalesForce.Console.Common;

namespace Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic
{
    public class Invoice : SynchronizerManager
    {
       
        public override List<GenericFile> SynchronizeDataAsync(FileConfig data)
        {
            List<GenericFile> genericFiles = new List<GenericFile>();
            List<string> fileList = FileHelper.GetFiles(data);
            // 1.Ciclo para recorrer archivos a procesar
            foreach (string file in fileList)
            {
                // 1.1 Leer el contenido del archivo
                try
                {
                    List<string[]> row = FileHelper.ReadFile(file,data);

                }
                catch { 
                
                }

                
            }
            // 1.2 Convertir cada row a objeto common
            // 1.3 agregar objeto common a una lista de objetos common padre
            // 1.4 mover el aarchivo a complete o error dependiendo del caso
            return genericFiles;
        }
    }
}
