using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic.Class
{
    public abstract class SynchronizerManager
    {
        public abstract List<string> SynchronizeDataAsync(Common.FilesConfig data);
    }
}
