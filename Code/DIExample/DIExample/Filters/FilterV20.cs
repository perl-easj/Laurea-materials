using System.Collections.Generic;

namespace DIExample.Filters
{
    public class FilterV20
    {
        public List<int> FilterValues(List<int> values)
        {
            List<int> filteredValues = new List<int>();

            foreach (int value in values)
            {
                if (value < 12)
                {
                    filteredValues.Add(value);
                }
            }

            return filteredValues;
        }
    }
}