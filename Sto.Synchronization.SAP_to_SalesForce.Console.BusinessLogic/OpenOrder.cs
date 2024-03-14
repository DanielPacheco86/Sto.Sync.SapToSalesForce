using Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic.Class;
using Sto.Synchronization.SAP_to_SalesForce.Console.Common;
using static Org.BouncyCastle.Math.EC.ECCurve;
using System.Reflection;

namespace Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic
{
    public class OpenOrder : SynchronizerManager
    {
        public override List<GenericFile> SynchronizeDataAsync(FileConfig config)
        {
            List<GenericFile> genericFiles = new List<GenericFile>();
            List<string> fileList = FileHelper.GetFiles(config);
            PropertyInfo[] properties = typeof(OpenOrderFile).GetProperties();
            foreach (string file in fileList)
            {
                try
                {
                    List<string[]> data = FileHelper.ReadFile(file, config);
                    foreach (string[] row in data)
                    {
                        OpenOrderFile invoiceFile = new OpenOrderFile();
                        for (int i = 0; i < Math.Min(properties.Length, row.Length); i++)
                        {
                            properties[i].SetValue(invoiceFile, row[i]);
                        }
                        genericFiles.Add(invoiceFile);
                    }
                    FileHelper.MoveFile(file, config.File_Path_Completed);
                }
                catch
                {
                    FileHelper.MoveFile(file, config.File_Path_Error);
                }


            }
            return genericFiles;
        }
    }
}
