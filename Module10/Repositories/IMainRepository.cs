using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10.Repositories
{
    public interface IMainRepository<T>
    {
        void Save(T Entity);
        void Delete(T Entity);
    }
}
