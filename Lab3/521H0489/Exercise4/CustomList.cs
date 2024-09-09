using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    public class CustomList<T>
    {
        private T[] items;
        private int count;
        private const int DefaultCapacity = 4;

        public CustomList()
        {
            items = new T[DefaultCapacity];
        }

        public int Count => count;
        public int Capacity => items.Length;

        public void Add(T item)
        {
            if (count == items.Length)
            {
                ResizeArray();
            }

            items[count] = item;
            count++;
        }

        public bool Remove(T item)
        {
            int index = IndexOf(item);
            if (index >= 0)
            {
                RemoveAt(index);
                return true;
            }

            return false;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = index; i < count - 1; i++)
            {
                items[i] = items[i + 1];
            }

            count--;
            items[count] = default(T);
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }

                return items[index];
            }
            set
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }

                items[index] = value;
            }
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (Equals(items[i], item))
                {
                    return i;
                }
            }

            return -1;
        }

        private void ResizeArray()
        {
            int newCapacity = items.Length * 2;
            T[] newArray = new T[newCapacity];
            Array.Copy(items, newArray, count);
            items = newArray;
        }
    }

}
