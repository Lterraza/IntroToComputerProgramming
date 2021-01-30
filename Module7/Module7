using System;
using System.Collections.Generic;
using System.Linq;

namespace Module7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // create the list of users
                List<User> users = new List<User>();

                // add users to the list
                users.Add(new User(1, "Luis Terrazas", new Role(1, "Student")));
                users.Add(new User(2, "Andrea Terrazas", new Role(1, "Student")));
                users.Add(new User(3, "John Doe", new Role(1, "Student")));
                users.Add(new User(4, "Alvaro Terrazas", new Role(1, "Student")));
                users.Add(new User(5, "Ezra Terrazas", new Role(1, "Student")));
                users.Add(new User(6, "Lupe Terrazas", new Role(1, "Student")));
                users.Add(new User(7, "Mariana Terrazas", new Role(1, "Student")));
                users.Add(new User(8, "Betty Aguilar", new Role(1, "Student")));
                users.Add(new User(9, "Jane Doe", new Role(1, "Student")));
                users.Add(new User(10, "Louis Turruzas", new Role(1, "Student")));

                //user input
                Console.WriteLine("Type the student last name to search for: ");
                //int searchid = Convert.ToInt32(Console.ReadLine());
                string searchname = Convert.ToString(Console.ReadLine());

                
                List<User> usersfound = users.Where(u => u.Name.Contains(searchname)).ToList();
                if (usersfound.Count == 0)
                {
                    throw new UserNotFound("User is not in the list");
                }
                else
                {
                    foreach (User u in usersfound)
                    {
                        Console.WriteLine("User found: " + u.UserId + " " + u.Name + " " + u.Role.Description);
                    }
                }
            }
            catch (UserNotFound ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }

        }
    }

    public class UserNotFound : Exception
    {
        public UserNotFound(string message) : base(message) { }
    }
}
