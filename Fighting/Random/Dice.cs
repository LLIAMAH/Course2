namespace Fighting.Random
{
    public enum EDice
    {
        D2 = 2,
        D4 = 4,
        D6 = 6,
        D8 = 8,
        D10 = 10,
        D12 = 12,
        D20 = 20,
        D100 = 100
    }

    public class Dice
    {
        private readonly System.Random _rand;

        public Dice(System.Random rand)
        {
            this._rand = rand;
        }

        public int Roll(EDice dice = EDice.D10)
        {
            //_rand.Next(10): 0 1 2 3.. 9;
            return this._rand.Next((int)dice) + 1;
        }
    }
}
