using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sto.Synchronization.SAP_to_SalesForce.Console.Common
{
    public class FilesConfig
    {
        public FilesConfig() 
        {
            Id = string.Empty;
            File_Separator = string.Empty;
            File_Path = string.Empty;
            File_Path_Completed = string.Empty;
            File_Path_Error = string.Empty;
            File_Prefix = string.Empty;
        }

        public string Id { get; set; }
        public string File_Separator { get; set; }
        public string File_Path { get; set; }
        public string File_Path_Completed { get; set; }
        public string File_Path_Error { get; set; }
        public string File_Prefix { get; set; }

    }
}
