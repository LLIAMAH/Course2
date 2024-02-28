using Fighting.Person;
using Fighting.Random;

namespace Fighting.Queue
{
    public class Order : IOrder
    {
        public IPerson First { get; }
        public IPerson Last { get; }

        public Order(IPerson p1, IPerson p2)
        {
            this.First = p1;
            this.Last = p2;
        }

        public void Hits()
        {
            this.First.Attack(this.Last);
            this.Last.Attack(this.First);
        }

        public bool CheckDead()
        {
            return this.First.CheckStatus() == EPersonStatus.Dead
                   || this.Last.CheckStatus() == EPersonStatus.Dead;
        }

        public string OutputWinner()
        {
            if (this.First.CheckStatus() == EPersonStatus.Dead && this.Last.CheckStatus() == EPersonStatus.Dead)
                return $"{this.First.Name} and {this.Last.Name} are dead. There is no winner in this battle.";

            return this.First.CheckStatus() == EPersonStatus.Dead
                ? $"The winner is - {this.Last.Name} hp:{this.Last.HitPoints}"
                : $"The winner is - {this.First.Name} hp:{this.Last.HitPoints}";
        }

        public static IOrder RollInitiative(Dice dice, IPerson p1, IPerson p2)
        {
            int roll1;
            int roll2;

            do
            {
                roll1 = p1.Initiative(dice);
                roll2 = p2.Initiative(dice);
            } while (roll1 != roll2);

            return roll1 > roll2
                ? new Order(p1, p2)
                : new Order(p2, p1);
        }
    }
}
