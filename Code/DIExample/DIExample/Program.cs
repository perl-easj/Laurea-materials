using System;
using System.Collections.Generic;
using DIExample.Conditions;
using DIExample.Containers;
using DIExample.Filters;
// ReSharper disable UnusedParameter.Local
// ReSharper disable JoinDeclarationAndInitializer

namespace DIExample
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Filter v.1.0

            List<int> filteredValues;
            FilterV10 fv10 = new FilterV10();

            filteredValues = fv10.FilterValues();
            PrintList("FilterV10", filteredValues);

            #endregion

            #region Filter v.2.0

            List<int> values = new List<int>() { 12, 24, 9, 10, 6, 3, 45 };
            FilterV20 fv20 = new FilterV20();

            filteredValues = fv20.FilterValues(values);
            PrintList("FilterV20", filteredValues);

            #endregion

            #region Filter v.3.0

            ICondition intCond = new ConditionLessThan12();
            FilterV30 fv30 = new FilterV30();

            filteredValues = fv30.FilterValues(values, intCond);
            PrintList("FilterV30", filteredValues);

            #endregion

            #region Filter v.4.0

            List<string> valuesStr = new List<string>() { "Paul", "Alice", "James", "Peter", "Susan" };
            List<string> filteredValuesStr;
            IConditionGeneric<string> strCond = new ConditionContainsS();
            FilterV40<string> fv40 = new FilterV40<string>();

            filteredValuesStr = fv40.FilterValues(valuesStr, strCond);
            PrintList("FilterV40", filteredValuesStr);

            #endregion

            #region Filter v.5.0

            FilterV50<string> fv50 = new FilterV50<string>();

            filteredValuesStr = fv50.FilterValues(valuesStr, strCond);
            PrintList("FilterV50", filteredValuesStr);

            #endregion

            #region Filter v.6.0

            IResultCollection<string> rcStr = new FilteredResultCollection<string>();
            FilterV60<string> fv60 = new FilterV60<string>();

            fv60.FilterValues(valuesStr, rcStr, strCond);
            PrintList("FilterV60", rcStr.Values); 

            #endregion

            Console.WriteLine();
            Console.WriteLine("Press any key to close application");
            Console.ReadKey();
        }

        static void PrintList<T>(string leadtext, IEnumerable<T> values)
        {
            Console.Write(leadtext + " :   ");
            foreach (var value in values)
            {
                Console.Write($" {value} ");
            }
            Console.WriteLine();
        }
    }
}
