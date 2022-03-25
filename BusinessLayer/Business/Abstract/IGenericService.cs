using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Business.Abstract
{
    public interface IGenericService<T>
    {
        void Add(T parameter);
        void Delete(T parameter);
        void Update(T parameter);
        List<T> GetAll();
        T GetById(int id);
    }
}
