using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Models
{
    public class Comment
    {
        public Comment() { }
        public int CommentId { get; set; }
        public string Comments { get; set; }
        public override string ToString()
        {
            string format = "Comment ID: [{0}], Comments[{1}]";

            return String.Format(format, CommentId, Comments);
        }
    }
}
