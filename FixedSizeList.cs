using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Assignment
{
    public class FixedSizeList<T>
    {
        private T[] _array;
        private int _count;

        public FixedSizeList(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentException("Capacity cannot be negative");
            }
            _array = new T[capacity];
        }

        public void Add(T item)
        {
            if (_count >= _array.Length)
            {
                throw new InvalidOperationException("List is full");
            }
            _array[_count++] = item;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _array.Length)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
            return _array[index];
        }
        public int Count => _count;

    }
}
