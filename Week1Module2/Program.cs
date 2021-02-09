using System;
using Week1Module2.Classes;

namespace Week1Module2
{
    class Program
    {
        static void Main(string[] args)
        {
            Users Users1 = new Users();
            Users1.Name = "alvaro";
            Users1.Address = "123 Road";
            Users1.UserId = 7;

            Console.WriteLine(Users1.Address + " " + Users1.Name + " " + Users1.UserId);
            
        }
    }
}
