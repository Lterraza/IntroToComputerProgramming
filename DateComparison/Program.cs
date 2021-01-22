using System;

namespace DateComparison
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime firstdate = new DateTime(1992, 11, 14);
            DateTime seconddate = new DateTime(1992, 11, 14);
            int result = DateTime.Compare(firstdate, seconddate);
            switch (result)
            {
                case 0:
                    Console.WriteLine("First Date {0} is equal to the Second Date {1}", firstdate.ToShortDateString(), seconddate.ToString());
                    break;
                case 1:
                    Console.WriteLine("First Date {0} is greater than Second Date {1}", firstdate.ToString(), seconddate.ToString());
                    break; 
                case -1:
                    Console.WriteLine("Second Date {0} is greater than First Date {1}", firstdate.ToString(), seconddate.ToString());
                    break;

            }

        }
    }
}

