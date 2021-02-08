using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module10.Classes;

namespace Module10.Repositories
{
    public interface IUserRepository : IMainRepository<User>
    {
        List<User> Search(string Name);
        
    }
}
