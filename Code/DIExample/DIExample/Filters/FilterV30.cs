using System.Collections.Generic;
using DIExample.Conditions;

namespace DIExample.Filters
{
    public class FilterV30
    {
        public List<int> FilterValues(List<int> values, ICondition cond)
        {
            List<int> filteredValues = new List<int>();

            foreach (int value in values)
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