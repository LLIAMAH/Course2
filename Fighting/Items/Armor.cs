using Fighting.Random;

namespace Fighting.Items
{
    public abstract class Armor : IArmor
    {
        protected EDice _armorLevel;
        public string Name { get; protected set; }
        public bool HitArmor(int roll)
        {
            return (int)_armorLevel < roll;
        }
    }
}
