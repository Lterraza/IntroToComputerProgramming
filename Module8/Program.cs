using System;

namespace Module8
{
    class Program
    {
        static void Main(string[] args)
        {
            User<int, string> u = new User<int, string>();
            u.UserId = 1;
            u.Name = "Adrian Terrazas";

            Console.WriteLine(u.UserId.ToString() + " " + u.Name);
        }
    }
}
