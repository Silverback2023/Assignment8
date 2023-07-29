using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using SharedContactManager.DataStorage;
using System.Collections.Generic;

namespace ContactManagerDataService.DataStorage
{
    public class ArrayDataStorage<T> : IDataStorage<T>
    {
        private List<T> items;

        public ArrayDataStorage()
        {
            items = new List<T>();
        }

        public void Create(T item)
        {
            items.Add(item);
        }

        public T Retrieve(int id)
        {
            // Assuming the items have an "Id" property
            return items.Find(item => item.GetType().GetProperty("Id")?.GetValue(item).Equals(id) == true);
        }

        public List<T> RetrieveAll()
        {
            return new List<T>(items);
        }

        public void Update(T item)
        {
            int index = items.FindIndex(existingItem => existingItem.GetType().GetProperty("Id")?.GetValue(existingItem).Equals(item.GetType().GetProperty("Id")?.GetValue(item)) == true);
            if (index != -1)
            {
                items[index] = item;
            }
        }

        public void Delete(int id)
        {
            items.RemoveAll(item => item.GetType().GetProperty("Id")?.GetValue(item).Equals(id) == true);
        }
    }
}
