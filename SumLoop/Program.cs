using System;

namespace SumLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int total=0;
            for (int x = 1; x <=20 ;x++)
            {
                total += x;  
            }
            Console.WriteLine("Total = {0}", total);
        }
    }
}
