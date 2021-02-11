using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.DTOS
{
    public class UserDTO
    {
        public UserDTO() { }
        public UserDTO(int userid, string name, RoleDTO role)
        {
            UserId = userid;
            Name = name;
            Role = role;
        }
        public int UserId { get; set; }
        public string Name { get; set; }
        public RoleDTO Role { get; set; }
    }
}
