using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sultan_Lending_Library
{
    public interface IBag<T> : IEnumerable<T>
    // IEnumerable: loops over the generic or non-generic collections.
    // GetEnumerator: get current elements from the collection.
    {
        /// <summary>
        /// Add an item to the bag. <c>null</c> items are ignored.
        /// </summary>
        void Pack(T item);

        /// <summary>
        /// Remove the item from the bag at the given index.
        /// </summary>
        /// <returns>The item that was removed.</returns>
        T Unpack(int index);
    }
}
