using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace Xtremly.Core
{
    [DebuggerDisplay("Count = {Count}")]
    public class ReadOnlyList<Target> : IReadOnlyList<Target>, IReadOnlyCollection<Target>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private readonly IList<Target> _collection;
        public ReadOnlyList(IEnumerable<Target> collection)
        {
            _collection = new List<Target>(collection);
        }

        public Target this[int index] => _collection[index];

        public int Count => _collection.Count;

        public IEnumerator<Target> GetEnumerator()
        {
            return _collection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _collection.GetEnumerator();
        }
    }
}
