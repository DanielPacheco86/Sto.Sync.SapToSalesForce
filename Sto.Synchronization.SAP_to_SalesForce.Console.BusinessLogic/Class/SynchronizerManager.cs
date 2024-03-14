
using Sto.Synchronization.SAP_to_SalesForce.Console.Common;

namespace Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic.Class
{
    public abstract class SynchronizerManager
    {
        public abstract List<GenericFile> SynchronizeDataAsync(Common.FileConfig data);
    }
}
