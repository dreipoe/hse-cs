using System;
using System.Collections;
using System.Collections.Generic;

namespace LabLauncher.Lab11Dir
{
    public class Hashtable<TKey, TValue> : IEnumerable<TKey>
    {
        protected class Node
        {
            public TKey key;
            public TValue value;
            public int hash;
            public Node next;

            public Node(TKey key, TValue value)
            {                
                this.key = key;
                this.value = value;
                hash = key.GetHashCode();
                next = null;
            }

            public override int GetHashCode()
            {
                return hash;
            }
        }

        protected class Enumerator : IEnumerator<TKey>
        {
            protected int pos = -1;
            protected Node current = null;
            protected Node[] hashtable;

            public Enumerator(Node[] hashtable)
            {
                this.hashtable = hashtable;
            }

            public TKey Current
            {
                get
                {
                    if (pos == -1) throw new InvalidOperationException();
                    return current.key;
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public void Dispose() { }

            public bool MoveNext()
            {
                if (pos == -1) pos++;
                while (pos < hashtable.Length)
                {
                    if (current == null)
                    {
                        if (hashtable[pos] != null)
                        {
                            current = hashtable[pos];
                            return true;
                        }
                    }
                    else if (current.next != null)
                    {
                        current = current.next;
                        return true;
                    }

                    pos++; current = null;
                }

                return false;
            }

            public void Reset()
            {
                pos = -1; current = null;
            }
        }

        protected Node[] hashtable;

        public int Capacity
        {
            get
            {
                return hashtable.Length;
            }
        }

        public int Count { get; protected set; } = 0;

        public ICollection<TKey> Keys
        {
            get
            {
                ICollection<TKey> result = new List<TKey>();
                foreach (TKey key in this) result.Add(key);
                return result;
            }
        }

        public ICollection<TValue> Values
        {
            get
            {
                ICollection<TValue> result = new List<TValue>();
                Node current;

                foreach (Node node in hashtable)
                {
                    current = node;
                    while (current != null)
                    {
                        result.Add(current.value);
                        current = current.next;
                    }
                }

                return result;
            }
        }

        public Hashtable()
        {
            hashtable = new Node[255];
        }

        public Hashtable(int capacity)
        {
            if (capacity > 0) hashtable = new Node[capacity];
        }

        public Hashtable(ICollection<TKey> collection)
        {
            int capacity = 0;
            foreach (TKey node in collection) capacity++;
            hashtable = new Node[capacity * 10];
            foreach (TKey node in collection) Add(node, default(TValue));
        }

        // добавление элемента в хэш-таблицу
        public void Add(TKey key, TValue value)
        {
            int hash = key.GetHashCode(), i = hash % Capacity;
            Node node = hashtable[i];

            if (node != null)
            {
                while (node.next != null) node = node.next;
                node.next = new Node(key, value);
            }
            else node = new Node(key, value);

            Count++;
        }

        // если ли такой ключ в хэш-таблице?
        public bool ContainsKey(TKey key)
        {
            int hash = key.GetHashCode(), i = hash % Capacity;
            Node node = hashtable[i];

            while (node != null)
                if (node.key.Equals(key))
                    return true;
                else
                    node = node.next;

            return false;
        }

        // есть ли элемент 
        public bool ContainsValue(TValue value)
        {
            throw new NotImplementedException();

            /*
            int i = value % Capacity;
            Node node = hashtable[i];

            while (node != null)
                if (node.value == value)
                    return true;
                else
                    node = node.next;

            return false;
            */
        }

        //удаляет все данные из хеш-таблицы
        public void Clear()
        {
            hashtable = new Node[Capacity];
        }

        public Hashtable<TKey, TValue> Clone()
        {
            throw new NotImplementedException();

            /*
            Hashtable<TKey, TValue> clone = new Hashtable<TKey, TValue>(Capacity);
            bool nullable = (default(TKey) == null);
            
            if (nullable)
            {
                ICloneable cloneableKey;
                foreach (TKey key in this)
                {
                    cloneableKey = key as ICloneable;
                    if (cloneableKey != null)
                    {
                        
                    }
                }
            }
            else foreach (TKey key in this) clone.Add(key);

            return clone;
            */
        }

        public void Remove(TKey key)
        {
            int hash = key.GetHashCode(), i = hash % Capacity;
            Node node = hashtable[i], pre = null;
            while (node != null)
            {
                if (node.key.Equals(key))
                {
                    //pre будет равен null, только если рассматривается первый элемент цепочки
                    if (pre != null)                        
                        pre.next = node.next;
                    else
                        hashtable[i] = node.next;
                    Count--; return;
                }
                else
                {
                    pre = node;
                    node = node.next;
                }
            }
        }

        public TValue[] ToArray()
        {
            throw new NotImplementedException();

            /*
            int i = 0;
            TKey[] result = new TKey[Count];
            foreach (TKey key in this)
            {
                result[i] = key;
                i++;
            }

            return result;
            */
        }

        public IEnumerator<TKey> GetEnumerator()
        {
            return new Enumerator(hashtable);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
