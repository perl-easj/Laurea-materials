namespace DIExample.Conditions
{
    public class ConditionLessThan12 : ICondition
    {
        public bool Condition(int value)
        {
            return (value < 12);
        }
    }
}