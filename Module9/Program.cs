using System;

namespace Module9
{
    class Program
    {
        static void Main(string[] args)
        {
            Role role = new Role();
            role.RoleID = 1;
            role.Description = "Student";

            User u = new User();
            u.SetValues<Role>(5, "Luis Terrazas",role);

            Console.WriteLine("User id = " + u.UserId);  
            Console.WriteLine("Name = " + u.Name);
            Console.WriteLine("Role = " + u.Role.Description);
        }
    }
}

