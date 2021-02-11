using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final.Models;
using Final.Exceptions;
using System.IO;


namespace Final.Models
{
    public class GeneralMenu
    {
        private List<User> users = new List<User>();
        private List<Comment> comments = new List<Comment>();

        public GeneralMenu() { }
        public void ExecuteMainMenu()
        {
            Role studentrole = new Role();
            studentrole.RoleID = 1;
            studentrole.Description = "Student";

            int userinput = 0;

            do
            {
                userinput = displaymenu();
                if (userinput == 1)
                {
                    users.Add(AddUser(1, "Luis Adrian Terrazas", studentrole));
                    users.Add(AddUser(2, "Joe Smith", studentrole));
                    Console.WriteLine("");
                    Console.WriteLine("You have created a User");
                    Console.WriteLine("");
                }
                if (userinput == 2)
                {
                    comments.Add(AddComment(1, "This is a comment"));
                    comments.Add(AddComment(2, "This is another comment"));
                    Console.WriteLine("");
                    Console.WriteLine("You have created a Comment");
                    Console.WriteLine("");
                }
                if (userinput == 3)
                {
                    Console.WriteLine("");
                    PrintUsers(users);
                    Console.WriteLine("");
                }
                if (userinput == 4)
                {
                    Console.WriteLine("");
                    PrintComments(comments);
                    Console.WriteLine("");
                }
                if (userinput == 5)
                {                 
                    LookforUser();
                }
                if (userinput == 6)
                {
                    LookforComment();
                }
                if (userinput == 7)
                {
                    CreateDataFile();
                }

            }
            while (userinput != 8);
        }
        public static int displaymenu()
        {
            Console.WriteLine("1. Create a User");
            Console.WriteLine("2. Create A comment");
            Console.WriteLine("3. Print the list of users");
            Console.WriteLine("4. Print the list of comments");
            Console.WriteLine("5. Look for User");
            Console.WriteLine("6. Look for Comments");
            Console.WriteLine("7. Create Data File");
            Console.WriteLine("8. Exit the program");
            var result = Console.ReadLine();
            int sel;
            if (!int.TryParse(result, out sel))
                return 0;
            else
                return sel;
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

        public void LookforUser()
        {
            Console.WriteLine("");
            Console.WriteLine("Type the user name to search");
            string username = Console.ReadLine();

            List<User> usersfound = users.Where(u => u.Name.Contains(username)).ToList();
            if (usersfound.Count == 0)
            {
                throw new UserNotFoundException("The user name specified does not exist.");
            }
            else
            {
                Console.WriteLine("These are the users that exist on the list:");
                foreach (User u in usersfound)
                {
                    Console.WriteLine(u.ToString());
                }
            }
        }
        public void LookforComment()
        {
            Console.WriteLine("");
            Console.WriteLine("Type the comment text that you want to search");
            string comment = Console.ReadLine();

            List<Comment> commentsfound = comments.Where(c => c.Comments.Contains(comment)).ToList();
            if (commentsfound.Count == 0)
            {
                throw new CommentNotFoundException("There is no comment with the text.");
            }
            else
            {
                Console.WriteLine("These are the comments that exist on the list:");
                foreach (Comment c in commentsfound)
                {
                    Console.WriteLine(c.ToString());
                }
            }
        }
        public void CreateDataFile()
        {
            
            string filename = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + @"\Data.txt";
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                foreach (User u in users)
                    sw.WriteLine(u.ToString());
                foreach (Comment c in comments)
                    sw.WriteLine(c.ToString());
            }
            Console.WriteLine("File created: " + filename);
        }
    }
}