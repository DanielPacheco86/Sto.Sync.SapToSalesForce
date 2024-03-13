using NPOI.SS.Formula.Functions;
using Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic.Class;
using Sto.Synchronization.SAP_to_SalesForce.Console.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic
{
    public class InvoiceProcess : SynchronizerManager
    {
       
        public override List<string> SynchronizeDataAsync(FilesConfig data)
        {
            List<string> fileList = LogicFiles.ObtainFiles(data);
            // 1.Ciclo para recorrer archivos a procesar
            foreach (string file in fileList)
            {
                // 1.1 Leer el contenido del archivo
                string contentFile = LogicFiles.ReadFile(file,data);
                
            }
            // 1.2 Convertir cada row a objeto common
            // 1.3 agregar objeto common a una lista de objetos common padre
            // 1.4 mover el aarchivo a complete o error dependiendo del caso
            return fileList;
        }
    }
}
