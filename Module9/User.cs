using System;
namespace Module9
{ 
    public class User
    {
        public User() { }

        public int UserId { get; set; }

        public string Name { get; set; }

        public Role Role { get; set; }

        public void SetValues<R>(int id, string name, R role) where R : Role
        {
            UserId = id;
            Name = name;
            Role = role;
        }
    }
   
}

