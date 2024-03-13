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
            return fileList;
        }
    }
}
