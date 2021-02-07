using System;
using System.IO;

namespace Module11
{
    public class FileManagmentClass
    {
        public FileManagmentClass() { }

        public void CreateFile(string FileName)
        {
            string filepath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\" + FileName;
            if (File.Exists(filepath))
            {
                Console.Write("File Already Exists");
                Console.ReadLine();

            }
            else
            {
                File.Create(filepath);

            }
        }
        public void CreateDirectory(string FolderName)
        {
            string folderpath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\" + FolderName;
            if (File.Exists(folderpath))
            {
                Console.Write("Folder Already Exists");
                Console.ReadLine();

            }
            else
            {
                File.Create(folderpath);

            }
        }
    }
}
