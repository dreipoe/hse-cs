using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabLauncher.Lab11Dir
{
    // TODO: Не готово

    public class PersonHashtable<T> // : IEnumerable<T>, IEnumerator<T>
    {
        class Point
        {
            public T key;
            public int value;
            public Point next;

            public Point (T key)
            {                
                this.key = key;
                value = key.GetHashCode();
                next = null;
            }

            public override int GetHashCode()
            {
                return key.GetHashCode();
            }

            public override string ToString()
            {
                return key.ToString() + ":" + value.ToString();
            }
        }

        private Point[] hashtable;

        public int Capacity { get; protected set; }
        public int Count
        {
            get
            {
                return hashtable.Count();
            }
        }
        public ICollection<int> Keys
        {
            get
            {
                return null;
            }
        }

        public ICollection<T> Values
        {
            get
            {
                return null;
            }
        }

        public PersonHashtable()
        {
            Capacity = 255;
            hashtable = new Point[Capacity];
        }

        public PersonHashtable(int capacity)
        {
            Capacity = capacity;
            hashtable = new Point[Capacity];
        }

        public PersonHashtable(ICollection<T> collection)
        {

        }

        // добавление элемента в хэш-таблицу
        public void Add(T value)
        {
            
        }

        // если ли такой ключ в хэш-таблице?
        public bool ContainsKey(T key)
        {
            bool result = false;
            return result;
        }

        public bool ContainsValue(int value)
        {
            return true;
        }

        public void Clear()
        {
            hashtable = new Point[Capacity];
        }

        public PersonHashtable<T> Clone()
        {
            return null;
        }

        public void Remove(T value)
        {

        }
    }
}
