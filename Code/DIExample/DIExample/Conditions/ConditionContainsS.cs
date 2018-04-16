namespace DIExample.Conditions
{
    public class ConditionContainsS : IConditionGeneric<string>
    {
        public bool Condition(string value)
        {
            return value.ToLower().Contains("s");
        }
    }
}