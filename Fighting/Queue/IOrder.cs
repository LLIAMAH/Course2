using Fighting.Person;

namespace Fighting.Queue
{
    public interface IOrder
    {
        IPerson First { get; }
        IPerson Last { get; }
        void Hits();
        bool CheckDead();
        string OutputWinner();
    }
}
