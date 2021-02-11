using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Models
{
    public class User
    {
        public User() { }
        public User(int userid, string name, Role role)
        {
            UserId = userid;
            Name = name;
            Role = role;
        }
        public int UserId { get; set; }
        public string Name { get; set; }
        public Role Role { get; set; }

        public override string ToString()
        {
            string format = "User Id: [{0}], User Name[{1}], Role[{2}]";

            return String.Format(format, UserId, Name, Role.Description);
        }
    }
}
