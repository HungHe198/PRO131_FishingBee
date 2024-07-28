using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_FishingBee.Repositories
{
    public interface IAllRepositories<T> where T : class
    {
        public ICollection<T> GetAll();
        public T GetById(dynamic id);
        public bool CreateObj(T Obj);
        public bool UpdateObj(T Obj);
        public bool DeletedObj(dynamic id);
        
    }
}
