using System.Collections.Generic;

namespace DIExample.Containers
{
    public class FilteredResultCollection<T> : IResultCollection<T>
    {
        private List<T> _values;

        public FilteredResultCollection()
        {
            _values = new List<T>();
        }

        public IEnumerable<T> Values
        {
            get { return _values; }
        }

        public void Add(T value)
        {
            _values.Add(value);
        }
    }
}