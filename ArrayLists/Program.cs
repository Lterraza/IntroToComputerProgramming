using System;
using System.Collections.Generic;


namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string allnames = string.Empty;
            string[] namesArray = { "Luis ", "Adrian ", "Terrazas " };
            foreach(string s in namesArray)

            {
                allnames += s;
            }

            Console.WriteLine(" using Array " + allnames);

            string allintegers = string.Empty;
            List<int> intList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int i in intList)
            {

                allintegers += i.ToString();
            }
            Console.WriteLine(" Using List " + allintegers);
        }
    }
}
