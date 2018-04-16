using System.Collections.Generic;
using DIExample.Conditions;

namespace DIExample.Filters
{
    public class FilterV50<T>
    {
        public List<T> FilterValues(IEnumerable<T> values, IConditionGeneric<T> cond)
        {
            List<T> filteredValues = new List<T>();

            foreach (T value in values)
            {
                if (cond.Condition(value))
                {
                    filteredValues.Add(value);
                }
            }

            return filteredValues;
        }
    }
}