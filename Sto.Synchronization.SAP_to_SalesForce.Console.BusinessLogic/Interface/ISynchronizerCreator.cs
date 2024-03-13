using Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic.Interface
{
    public interface ISynchronizerCreator
    {
        SynchronizerManager GetSynchronizerObject(string Id);
    }
}
