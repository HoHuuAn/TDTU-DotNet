using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    public class ObservableList<T> : List<T>
    {
        public event Action<T>? OnAdd;
        public event Action<T>? OnRemove;
        public event Action<int, T>? OnInsert;
        public event Action<int, T>? OnUpdate;

        public new void Add(T item)
        {
            base.Add(item);
            OnAdd?.Invoke(item);
        }

        public new bool Remove(T item)
        {
            bool result = base.Remove(item);
            if (result)
                OnRemove?.Invoke(item);

            return result;
        }

        public new void Insert(int index, T item)
        {
            base.Insert(index, item);
            OnInsert?.Invoke(index, item);
        }

        public new void RemoveAt(int index)
        {
            T item = this[index];
            base.RemoveAt(index);
            OnRemove?.Invoke(item);
        }

        public new T this[int index]
        {
            get => base[index];
            set
            {
                T oldItem = base[index];
                base[index] = value;
                OnUpdate?.Invoke(index, value);
            }
        }
    }
}
