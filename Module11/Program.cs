using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Module11
{
    class Program
    {
        static void Main(string[] args)
        {
            FileManagmentClass fmc = new FileManagmentClass();
            fmc.CreateFile("test.txt");
            fmc.CreateDirectory("New Directory");

        }
    }
}
