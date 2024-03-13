﻿using Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic.Class;
using Sto.Synchronization.SAP_to_SalesForce.Console.Common;

namespace Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic
{
    internal class Customer : SynchronizerManager
    {
        public override List<string> SynchronizeDataAsync(FileConfig data)
        {
            List<string> fileList = FileHelper.GetFiles(data);
            return fileList;
        }
    }
}