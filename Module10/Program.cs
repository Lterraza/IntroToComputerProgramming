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
            UserRepository ur = new UserRepository();

            ur.Save(new User(1, "Luis Terrazas", "Student"));
            ur.Save(new User(2, "John Doe", "Student"));
            ur.Save(new User(3, "Ezra Terrazas", "Student"));
            ur.Save(new User(4, "Alvaro Terrazas", "Teacher"));
            ur.Save(new User(5, "Betty Aguilar", "Student"));
            ur.Save(new User(6, "Andrea Terrazas", "Student"));
            ur.Save(new User(7, "Mariana Terrazas", "Student"));

            List<User>usersFound = ur.Search("Terrazas");
            foreach (User u in usersFound)
            {
                Console.WriteLine(u.UserID + " " + u.Name + " " + u.Role);
            }

            ur.Delete(ur.repositorylist.Find(u=>u.UserID == 1));

            usersFound = ur.Search("Terrazas");
            foreach (User u in usersFound)
            {
                Console.WriteLine(u.UserID + " " + u.Name + " " + u.Role);
            }
        }
    }
}
