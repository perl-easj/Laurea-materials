namespace DIExample.Conditions
{
    public class ConditionEven : ICondition
    {
        public bool Condition(int value)
        {
            return ((value % 2) == 0);
        }
    }
}