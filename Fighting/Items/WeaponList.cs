using Fighting.Random;

namespace Fighting.Items
{
    public class Knife : Weapon
    {
        public Knife(Dice dice)
        {
            this._dice = dice;
            this.Name = "Knife";
            this._hitDamage = EDice.D4;
        }
    }

    public class Sword : Weapon
    {
        public Sword(Dice dice)
        {
            this._dice = dice;
            this.Name = "Sword";
            this._hitDamage = EDice.D8;
        }
    }

    public class ShortSword : Weapon
    {
        public ShortSword(Dice dice)
        {
            this._dice = dice;
            this.Name = "ShortSword";
            this._hitDamage = EDice.D6;
        }
    }

    public class Mace : Weapon
    {
        public Mace(Dice dice)
        {
            this._dice = dice;
            this.Name = "Mace";
            this._hitDamage = EDice.D6;
        }
    }

    public class Spear : Weapon
    {
        public Spear(Dice dice)
        {
            this._dice = dice;
            this.Name = "Spear";
            this._hitDamage = EDice.D8;
        }
    }

    public class GreatSword : Weapon
    {
        public GreatSword(Dice dice)
        {
            this._dice = dice;
            this.Name = "GreatSword";
            this._hitDamage = EDice.D12;
        }
    }
}
