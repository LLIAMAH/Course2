namespace AppStackAndQueue.Classes
{
    public interface IMyStack
    {
        IEnumerable<object> Items { get; }
        void Push(object item);
        object? Pop();
    }
}
