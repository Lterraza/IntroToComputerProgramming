using System;

namespace Week1Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = MultiplyNumbers(5, 8);
            Console.WriteLine(result);
        }

        public static int MultiplyNumbers(int number1, int number2)
        { 
            return number1 * number2;
        }
    }
}
