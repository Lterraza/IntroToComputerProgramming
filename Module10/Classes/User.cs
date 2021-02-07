using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10.Classes
{
    public class User
    {
        public User() { }
        public User(int id, string name, string role)
        {
            UserID = id;
            Name = name;
            Role = role;
        }
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
             
    }
}
