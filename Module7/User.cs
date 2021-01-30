using System;
namespace Module7
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
    }
}
