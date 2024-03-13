using Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic.Class;

namespace Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic.Interface
{
    public interface ISynchronizerCreator
    {
        SynchronizerManager GetSynchronizerObject(string Id);
    }
}
