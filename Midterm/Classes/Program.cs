using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Midterm.Classes;


namespace Midterm.Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            List<User> users = new List<User>();
            List<Comment> comments = new List<Comment>();

            Role studentrole = new Role();
            studentrole.RoleID = 1;
            studentrole.Description = "Student";

            int userinput = 0;
            do
            {
                userinput = displaymenu();
                if (userinput == 1)
                {
                    users.Add(AddUser(1, "Luis Terrazas", studentrole));
                    users.Add(AddUser(2, "Adrian Terrazas", studentrole));
               }
                if (userinput == 2)
                {
                    comments.Add(AddComment(1, "This is a comment"));
                }
                if (userinput == 3)
              {
                    PrintUsers(users);
                }
                if (userinput == 4)
                {
                    PrintComments(comments);
                }
                if (userinput == 5)
                    Environment.Exit(0);
            }
            while (userinput != 5);
        }
        public static int displaymenu()
        {
            Console.WriteLine("1. Create a User");
            Console.WriteLine("2. Create A comment");
            Console.WriteLine("3. Print the list of users");
            Console.WriteLine("4. Print the list of comments");
            Console.WriteLine("5. Exit the program");
            var result = Console.ReadLine();
            return Convert.ToInt32(result);
        }

        public static User AddUser(int userId, string Name, Role studentrole)
        {
            User u = new User();
            u.UserId = userId;
            u.Name = Name;
            u.Role = studentrole;

            return u;
        }

        public static Comment AddComment(int commentid, string comment)
        {
            Comment com = new Comment();
            com.CommentId = commentid;
            com.Comments = comment;
            return com;
        }

        public static void PrintUsers(List<User> Users)
        {
            foreach (User u in Users)
            {
                Console.WriteLine(u.UserId.ToString() + " " + u.Name + " " + u.Role.Description);
            }
        }

        public static void PrintComments(List<Comment> Comments)
        {
            foreach (Comment c in Comments)
            {
                Console.WriteLine(c.CommentId + " " + c.Comments);
            }
        }
    }
}

