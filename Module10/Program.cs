using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module10.Classes;
using Module10.Repositories;
using Module10.Repositories.Implementation;

namespace Module10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            UserRepository ur = new UserRepository();
            users.Add(new User(1, "Luis Terrazas", "Student"));
            users.Add(new User(2, "John Doe", "Student"));
            users.Add(new User(3, "Ezra Terrazas", "Student"));
            users.Add(new User(1, "Alvaro Terrazas", "Teacher"));
            users.Add(new User(1, "Betty Aguilar", "Student"));
            users.Add(new User(1, "Andrea Terrazas", "Student"));
            users.Add(new User(1, "Mariana Terrazas", "Student"));

            List<User>usersFound = ur.Search(users, "Terrazas");
            foreach (User u in usersFound)
            {
                Console.WriteLine(u.UserID + " " + u.Name + " " + u.Role);
            }
        }
    }
}
