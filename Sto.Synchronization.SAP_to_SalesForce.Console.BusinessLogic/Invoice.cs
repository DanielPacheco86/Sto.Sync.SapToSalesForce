using NPOI.Util.Collections;
using Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic.Class;
using Sto.Synchronization.SAP_to_SalesForce.Console.Common;
using System.Reflection;

namespace Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic
{
    public class Invoice : SynchronizerManager
    {
       
        public override List<GenericFile> SynchronizeDataAsync(FileConfig config)
        {
            List<GenericFile> genericFiles = new List<GenericFile>();
            List<string> fileList = FileHelper.GetFiles(config);
            PropertyInfo[] properties = typeof(InvoiceFile).GetProperties();
            foreach (string file in fileList)
            {
                try
                {
                    List<string[]> data = FileHelper.ReadFile(file,config);
                    foreach (string[] row in data)
                    {
                        InvoiceFile invoiceFile = new InvoiceFile();
                        for (int i = 0; i < Math.Min(properties.Length, row.Length); i++)
                        {
                            properties[i].SetValue(invoiceFile, row[i]);
                        }
                        genericFiles.Add(invoiceFile);
                    }
                    FileHelper.MoveFile(file,config.File_Path_Completed);
                }
                catch 
                {
                    FileHelper.MoveFile(file,config.File_Path_Error);
                }

                
            }
            return genericFiles;
        }
    }
}
