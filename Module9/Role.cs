using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9
{
    public class Role
    {
        public Role(int roleid, string description)
        {
            RoleID = roleid;
            Description = description;
        }
        public Role() { }
        public int RoleID { get; set; }
        public string Description { get; set; }
    }
}
