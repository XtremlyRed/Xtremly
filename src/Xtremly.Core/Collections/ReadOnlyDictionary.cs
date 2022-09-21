using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace Xtremly.Core
{
    public class ReadOnlyDictionary<TKey, TValue> : IReadOnlyDictionary<TKey, TValue>
        where TKey : notnull
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private readonly Dictionary<TKey, TValue> collection;

        public TValue this[TKey key]
        {
            get => collection[key];
            internal set => collection[key] = value;
        }

        internal ReadOnlyDictionary()
        {
            collection = new Dictionary<TKey, TValue>();
        }

        public ReadOnlyDictionary(IEnumerable<KeyValuePair<TKey, TValue>> keyValues) : this()
        {
            if (keyValues is null)
            {
                return;
            }

            foreach (KeyValuePair<TKey, TValue> kvp in keyValues)
            {
                collection[kvp.Key] = kvp.Value;
            }
        }


        public IEnumerable<TKey> Keys => collection.Keys;
        public IEnumerable<TValue> Values => collection.Values;
        public int Count => collection.Count;
        public bool ContainsKey(TKey key)
        {
            return collection.ContainsKey(key);
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return collection.GetEnumerator();
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            return collection.TryGetValue(key, out value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return collection.GetEnumerator();
        }
    }
}
