using Fighting.Random;

namespace Fighting.Items
{
    public class Shop : IShop
    {
        private readonly Dice _dice;

        public Shop(Dice dice)
        {
            this._dice = dice;
        }

        public IArmor GetArmor()
        {
            var result = this._dice.Roll(EDice.D4);
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
            var result = this._dice.Roll(EDice.D6);
            switch (result)
            {
                case 1: return new Sword(this._dice);
                case 2: return new Mace(this._dice);
                case 3: return new Knife(this._dice);
                case 4: return new GreatSword(this._dice);
                case 5: return new ShortSword(this._dice);
                case 6: return new Spear(this._dice);
                default: return new Sword(this._dice);
            }
        }
    }
}
