using System.Collections.Generic;
using DIExample.Conditions;
using DIExample.Containers;

namespace DIExample.Filters
{
    public class FilterV60<T>
    {
        public void FilterValues(
            IEnumerable<T> values, 
            IResultCollection<T> filteredValues,
            IConditionGeneric<T> cond)
        {
            foreach (T value in values)
            {
                if (cond.Condition(value))
                {
                    filteredValues.Add(value);
                }
            }
        }
    }
}