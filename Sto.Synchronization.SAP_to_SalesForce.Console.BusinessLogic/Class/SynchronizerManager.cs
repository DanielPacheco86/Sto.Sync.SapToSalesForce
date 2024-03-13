
namespace Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic.Class
{
    public abstract class SynchronizerManager
    {
        public abstract List<string> SynchronizeDataAsync(Common.FileConfig data);
    }
}
