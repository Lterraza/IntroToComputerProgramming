using System;
using System.Collections.Generic;
using System.Text;

namespace Week1Module2.Classes
{
    public class Roles
    {
        public int RoleID { get; set; }
        public string Name { get; set; }

        public Roles(int roleid, string name) { RoleID = roleid; Name = name; }
    }
}
