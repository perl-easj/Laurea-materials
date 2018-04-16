using System.Collections.Generic;

namespace DIExample.Filters
{
    public class FilterV10
    {
        public List<int> FilterValues()
        {
            List<int> values = new List<int>{ 12, 24, 9, 10, 6, 3, 45 };
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