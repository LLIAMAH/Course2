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

    public static class Dice
    {
        private static System.Random _rand = new System.Random();
        
        public static int Roll(EDice dice)
        {
            //_rand.Next(10): 0 1 2 3.. 9;
            return _rand.Next((int)dice) + 1;
        }
    }
}
