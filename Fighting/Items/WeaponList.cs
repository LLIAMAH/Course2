using Fighting.Random;

namespace Fighting.Items
{
    public class Knife : Weapon
    {
        public Knife()
        {
            this.Name = "Knife";
            this._hitDamage = EDice.D4;
        }
    }

    public class Sword : Weapon
    {
        public Sword()
        {
            this.Name = "Sword";
            this._hitDamage = EDice.D8;
        }
    }

    public class ShortSword : Weapon
    {
        public ShortSword()
        {
            this.Name = "ShortSword";
            this._hitDamage = EDice.D6;
        }
    }

    public class Mace : Weapon
    {
        public Mace()
        {
            this.Name = "Mace";
            this._hitDamage = EDice.D6;
        }
    }

    public class Spear : Weapon
    {
        public Spear()
        {
            this.Name = "Spear";
            this._hitDamage = EDice.D8;
        }
    }

    public class GreatSword : Weapon
    {
        public GreatSword()
        {
            this.Name = "GreatSword";
            this._hitDamage = EDice.D12;
        }
    }
}
