using Fighting.Random;

namespace Fighting.Items
{
    public class Shop : IShop
    {
        public Shop() { }

        public IArmor GetArmor()
        {
            var result = Dice.Roll(EDice.D4);
            switch (result)
            {
                case 1: return new Leather();
                case 2: return new BreastMail();
                case 3: return new ChainMail();
                case 4: return new FullPlate();
                default: return new Leather();
            }
        }

        public IWeapon GetWeapon()
        {
            var result = Dice.Roll(EDice.D6);
            switch (result)
            {
                case 1: return new Sword();
                case 2: return new Mace();
                case 3: return new Knife();
                case 4: return new GreatSword();
                case 5: return new ShortSword();
                case 6: return new Spear();
                default: return new Sword();
            }
        }
    }
}
