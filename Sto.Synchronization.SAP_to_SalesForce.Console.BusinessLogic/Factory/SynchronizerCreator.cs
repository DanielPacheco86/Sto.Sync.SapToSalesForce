using Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic.Class;
using Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic.Interface;

namespace Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic.Factory
{
    public class SynchronizerCreator : ISynchronizerCreator
    {
        public SynchronizerManager GetSynchronizerObject(string id)
        {
            switch (id)
            {
                case "Invoice":
                    return new Invoice();
                case "Customer":
                    return new Customer();
                case "OpenOrders":
                    return new OpenOrder();
                default: 
                    return null;
            }
        }
    }
}
