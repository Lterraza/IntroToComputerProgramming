using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module10.Classes;

namespace Module10.Repositories.Implementation
{
    public class UserRepository : MainRepository<User>, IUserRepository
    {
        public UserRepository() { }

        public List<User> Search(List<User> users, string name)
        {
            return users.FindAll(u => u.Name.Contains(name));
        }
    }
}
