using Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic.Class;
using Sto.Synchronization.SAP_to_SalesForce.Console.Common;
using System.Reflection;

namespace Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic
{
    internal class Customer : SynchronizerManager
    {
        public override List<GenericFile> SynchronizeDataAsync(FileConfig config)
        {
            Utility.Logger.Instance.WriteInformation("Starting Customer - Synchronize Data");
            List<GenericFile> genericFiles = new List<GenericFile>();
            List<string> fileList = FileHelper.GetFiles(config);
            PropertyInfo[] properties = typeof(CustomerFile).GetProperties();
            foreach (string file in fileList)
            {
                try
                {
                    Utility.Logger.Instance.WriteInformation($"Processing file: {file}");
                    List<string[]> data = FileHelper.ReadFile(file, config);
                    foreach (string[] row in data)
                    {
                        CustomerFile invoiceFile = new CustomerFile();
                        for (int i = 0; i < Math.Min(properties.Length, row.Length); i++)
                        {
                            properties[i].SetValue(invoiceFile, row[i]);
                        }
                        genericFiles.Add(invoiceFile);
                    }
                    FileHelper.MoveFile(file, config.File_Path_Completed);
                }
                catch (Exception ex)
                {
                    Utility.Logger.Instance.WriteError(ex.Message);
                    FileHelper.MoveFile(file, config.File_Path_Error);
                }


            }
            return genericFiles;
        }
    }
}
