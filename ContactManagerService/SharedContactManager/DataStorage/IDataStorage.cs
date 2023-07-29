using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedContactManager.DataStorage
{
    public interface IDataStorage<T>
    {
        void Create(T item);
        T Retrieve(int id);
        List<T> RetrieveAll();
        void Update(T item);
        void Delete(int id);
    }
}
