using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace IntechCode.IntechCollection
{
    public class MyDictionary<TKey, TValue> : IMyDictionary<TKey, TValue>
    {

        int _count;
        Node[] _buckets;

        struct Node
        {
            public KeyValuePair<TKey, TValue> Data;
            public int Next;
        }

        public TValue this[TKey key] => throw new NotImplementedException();

        public int Count => _count;

        public void Add(TKey key, TValue value)
        {
            int idxBucket = Math.Abs(key.GetHashCode()) % _buckets.Length;
            Node head = _buckets[idxBucket];
            if (head != null && FindIn(head, key) != null)
            {
                throw new Exception("Duplicate key");
            }
            _buckets[idxBucket] = new Node()
            {
                Data = new KeyValuePair<TKey, TValue>(key, value),
                Next = head
            };
            ++_count;
        }

        Object FindIn(Node head, TKey key)
        {
            Debug.Assert(head != null);
            do
            {
                if (EqualityComparer<TKey>.Equals(key, head.Data.key)) break;

                head = head.Next;
            } while (head != null);
            return head;
        }

        public bool ContainsKey(TKey key)
        {
            throw new NotImplementedException();
        }

        public IMyEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(TKey key)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            throw new NotImplementedException();
        }
    }


}