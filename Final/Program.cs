using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final.Models;
using Final.Exceptions;


namespace Final
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                GeneralMenu gm = new GeneralMenu();
                gm.ExecuteMainMenu();
            }
            catch(GeneralException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }           
    }
}
