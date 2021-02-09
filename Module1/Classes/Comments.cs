using System;
using System.Collections.Generic;
using System.Text;


namespace Week1Module3.Classes
{
    public class Comments
    {
        public int CommentID { get; set; }
        public string Comment { get; set; }
        public Comments() { }

        public void PrintComments()
        {
            Console.WriteLine(CommentID + " " + Comment);
        }
    }
}
