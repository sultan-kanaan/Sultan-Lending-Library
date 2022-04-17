using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sultan_Lending_Library
{
    public class Backpack<T> : IBag<T>
    {
        private List<T> _items = new List<T>();

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in _items)
                yield return item;
        }

        public void Pack(T item)
        {
            _items.Add(item);
        }

        public T Unpack(int index)
        {
            T item = _items[index];
            _items.RemoveAt(index);
            return item;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
