namespace AppStackAndQueue.Classes
{
    public interface IMyQueue<T>
    {
        IEnumerable<T> Items { get; }
        void Push(T item);
        T? Pop();
        int Count();
    }
}
