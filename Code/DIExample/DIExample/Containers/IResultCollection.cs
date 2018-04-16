using System.Collections.Generic;

namespace DIExample.Containers
{
    public interface IResultCollection<T>
    {
        IEnumerable<T> Values { get; }
        void Add(T value);
    }
}