using Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic.Class;
using Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic.Factory
{
    public class SynchronizerCreator : ISynchronizerCreator
    {
        public SynchronizerManager GetSynchronizerObject(string Id)
        {

            switch (Id)
            {
                case "Invoice":
                    return new InvoiceProcess();
                case "Customer":
                    return new CustomerProcess();
                case "OpenOrders":
                    return new OpenOrdersProcess();
                default: return null;
            }
        }
    }
}
