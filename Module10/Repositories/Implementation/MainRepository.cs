using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10.Repositories.Implementation
{
    public class MainRepository<T> : IMainRepository<T>
    {
        public List<T> repositorylist = new List<T>();
        public MainRepository()
        { }
        public void Delete(T Entity)
        {
            repositorylist.Remove(Entity);
        }
        public void Save(T Entity)
        {
            repositorylist.Add(Entity);
        }
    }
}
