namespace DIExample.Conditions
{
    public interface IConditionGeneric<T>
    {
        bool Condition(T value);
    }
}