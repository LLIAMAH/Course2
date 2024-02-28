namespace Fighting.Items
{
    public interface IArmor
    {
        public string Name { get; }
        bool HitArmor(int roll);
    }
}
