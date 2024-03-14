using Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic.Class;
using Sto.Synchronization.SAP_to_SalesForce.Console.Common;

namespace Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic
{
    internal class Customer : SynchronizerManager
    {
        public override List<GenericFile> SynchronizeDataAsync(FileConfig data)
        {
            List<GenericFile> genericFiles = new List<GenericFile>();
            List<string> fileList = FileHelper.GetFiles(data);
            return genericFiles;
        }
    }
}
