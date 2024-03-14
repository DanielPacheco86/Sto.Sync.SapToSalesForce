using System.IO;

using Sto.Synchronization.SAP_to_SalesForce.Console.Common;

namespace Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic
{
    public static class FileHelper
    {
       
        public static List<string> GetFiles(FileConfig config)
        {
            List<string> processedFiles = new List<string>();
            try
            {
                Utility.Logger.Instance.WriteInformation($"Get files with this configuration: {config}");
                if (Directory.Exists(config.File_Path))
                {

                    string[] files = Directory.GetFiles(config.File_Path)
                                                  .Where(file => Path.GetFileName(file)
                                                  .IndexOf(config.File_Prefix,
                                                   StringComparison.OrdinalIgnoreCase) >= 0)
                                                  .ToArray();
                    Utility.Logger.Instance.WriteInformation($"Total files getting {files.Length}");
                    foreach (string file in files)
                    {
                        processedFiles.Add(file);
                    }
                }
            }
            catch(Exception ex) {
                Utility.Logger.Instance.WriteError(ex.Message);
            }
            return processedFiles;
        }

        public static void MoveFile(string filePathOriginal, string newFilePath)
        {
            string fileName = Path.GetFileName(filePathOriginal);
            string destination = Path.Combine(newFilePath, fileName);
            try 
            {
                if (!Directory.Exists(newFilePath))
                {
                    Directory.CreateDirectory(newFilePath);
                }
                if (File.Exists(destination))
                {
                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
                    string fileExtension = Path.GetExtension(fileName);

                    int counter = 1;
                    string newFileName = fileNameWithoutExtension + "_" + counter + fileExtension;
                    string newDestination = Path.Combine(newFilePath, newFileName);

                    while (File.Exists(newDestination))
                    {
                        counter++;
                        newFileName = fileNameWithoutExtension + "_" + counter + fileExtension;
                        newDestination = Path.Combine(newFilePath, newFileName);
                    }

                    destination = newDestination;
                }
                Utility.Logger.Instance.WriteInformation($"Move file from: {filePathOriginal} to {destination}");
                System.IO.File.Move(filePathOriginal, destination,false);
            
            
            }
            catch (Exception ex)
            {
                Utility.Logger.Instance.WriteError(ex.Message);

            }
        }

        public static List<string[]> ReadFile(string file, FileConfig fileConfig)
        {
            Utility.Logger.Instance.WriteInformation($"Reading file: {file}");
            List<string[]> rows = new List<string[]>();
         
            using (StreamReader reader = new StreamReader(file))
            {
                if (reader.Peek() == -1)
                {
                    throw new InvalidOperationException($"File empty");

                }
                else
                {
                    string firstRowHeaders = reader.ReadLine();
                    string[] columnNames = firstRowHeaders.Split(fileConfig.File_Separator);

                
                    while (!reader.EndOfStream)
                    {
                        string rowData = reader.ReadLine();
                        string[] rowSeparate = rowData.Split(fileConfig.File_Separator);
                    
                        rows.Add(rowSeparate);
                    }
                    
                }
            }
            
      
            return rows;
        }
    }
}
