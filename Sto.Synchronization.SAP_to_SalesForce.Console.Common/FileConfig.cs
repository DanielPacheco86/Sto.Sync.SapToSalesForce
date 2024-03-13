
namespace Sto.Synchronization.SAP_to_SalesForce.Console.Common
{
    public class FileConfig
    {
        public FileConfig() 
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
