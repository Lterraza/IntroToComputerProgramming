using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm.Classes
{
    public class User
    {
        public User() { }
        public int UserId { get; set; }
        public string Name { get; set; }
        public Role Role { get; set; }
    }
}
