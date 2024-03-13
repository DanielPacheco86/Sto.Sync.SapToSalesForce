using Microsoft.VisualBasic.FileIO;

using Sto.Synchronization.SAP_to_SalesForce.Console.Common;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic
{
    public static class LogicFiles
    {
       
        public static List<string> ObtainFiles(FilesConfig config)
        {
            List<string> processedFiles = new List<string>();
            if (Directory.Exists(config.File_Path))
            {
               // string[] files = Directory.GetFiles(config.File_Path);
                string[] files = Directory.GetFiles(config.File_Path)
                                              .Where(file => Path.GetFileName(file)
                                              .IndexOf(config.file_prefix,
                                               StringComparison.OrdinalIgnoreCase) >= 0)
                                              .ToArray();
                foreach (string file in files)
                {
                    processedFiles.Add(file);
                }
            }
            return processedFiles;
        }

        public static void moveFileToCompleted(string filePath, FilesConfig config)
        {
            string fileName = Path.GetFileName(filePath);
            string destino = Path.Combine(config.file_path_completed, fileName);
            System.IO.File.Move(filePath, destino);
        }
        public static void moveFileToError(string filePath, FilesConfig config)
        {
            string fileName = Path.GetFileName(filePath);
            string destino = Path.Combine(config.file_path_error, fileName);
            System.IO.File.Move(filePath, destino);
        }

    }
}
