using Microsoft.VisualBasic.FileIO;

using Sto.Synchronization.SAP_to_SalesForce.Console.Common;

namespace Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic
{
    public static class FileHelper
    {
       
        public static List<string> GetFiles(FileConfig config)
        {
            List<string> processedFiles = new List<string>();
            if (Directory.Exists(config.File_Path))
            {
               // string[] files = Directory.GetFiles(config.File_Path);
                string[] files = Directory.GetFiles(config.File_Path)
                                              .Where(file => Path.GetFileName(file)
                                              .IndexOf(config.File_Prefix,
                                               StringComparison.OrdinalIgnoreCase) >= 0)
                                              .ToArray();
                foreach (string file in files)
                {
                    processedFiles.Add(file);
                }
            }
            return processedFiles;
        }

        public static void MoveFile(string filePathOriginal, string newFilePath)
        {
            string fileName = Path.GetFileName(filePathOriginal);
            string destination = Path.Combine(newFilePath, fileName);
            
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

            System.IO.File.Move(filePathOriginal, destination);
        }

        public static List<string[]> ReadFile(string file, FileConfig fileConfig)
        {
            List<string[]> rows = new List<string[]>();
         
            using (TextFieldParser parser = new TextFieldParser(file))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(fileConfig.File_Separator);
                string[] columnNames = parser.ReadFields();
                while (!parser.EndOfData)
                {
                    string[] row = parser.ReadFields();
                    rows.Add(row);
                }
            }
            
      
            return rows;
        }
    }
}
