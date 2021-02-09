using System;
using System.Collections.Generic;
using System.Text;

namespace Week1Module3.Classes
{
    public class Users
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Users() { }

        public void printinfo<T>(Users u)
        {
            Console.WriteLine(Address + " " + Name + " " + UserId);
        }
    }
}
