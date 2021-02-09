using System;
using Week1Module3.Classes;
using Week1Module3.DTOS;
using System.Collections.Generic;

namespace Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            Comments comments1 = new Comments();
            comments1.CommentID = 1;
            comments1.Comment = "this is a comment for #1";
            comments1.PrintComments();

            Comments Comments2 = new Comments();
            Comments2.CommentID = 2;
            Comments2.Comment = "This is a comment for #2";
            Comments2.PrintComments();

            Users users1 = new Users();
            users1.UserId = 1;
            users1.Name = "Luis Adrian";
            users1.printinfo();

            Users users2 = new Users();
            users2.UserId = 2;
            users2.Name = "Ezra";
            users2.printinfo();

            Roles Roles1 = new Roles();
            Roles1.RoleID = 1;
            Roles1.Name = "Student";

            Roles Roles2 = new Roles();
            Roles2.RoleID = 2;
            Roles2.Name = "Student";

            Posts Posts1 = new Posts();
            Posts1.PostID = 1;
            Posts1.PostDescription = "yes";

            Posts Posts2 = new Posts();
            Posts2.PostID = 2;
            Posts2.PostDescription = "no";

            // DTO
            CommentsDTO commentDTO = new CommentsDTO();
            commentDTO.CommentID = 1;
            commentDTO.Comment = "this is a comment fro a DTO class";

            List<Users> use = new List<Users>();
            use.Add(users1);
            use.Add(users2);

            Users found = use.Find(u => u.Name == "Ezra");
            Console.WriteLine(found.UserId);
            
        }
    }
}
