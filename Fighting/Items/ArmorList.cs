using Fighting.Random;

namespace Fighting.Items
{
    public class Leather : Armor
    {
        public Leather()
        {
            this.Name = "Leather";
            this._armorLevel = EDice.D6;
        }
    }

    public class BreastMail : Armor
    {
        public BreastMail()
        {
            this.Name = "Breast mail";
            this._armorLevel = EDice.D10;
        }
    }

    public class ChainMail : Armor
    {
        public ChainMail()
        {
            this.Name = "Chain mail";
            this._armorLevel = EDice.D8;
        }
    }

    public class FullPlate : Armor
    {
        public FullPlate()
        {
            this.Name = "Full plate";
            this._armorLevel = EDice.D12;
        }
    }
}
