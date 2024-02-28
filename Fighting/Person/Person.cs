using Fighting.Items;
using Fighting.Random;

namespace Fighting.Person
{
    public class Person : IPerson
    {
        private const int maxHealth = 100;

        private int _health;
        private IArmor _armor;
        private IWeapon _weapon;

        public string Name { get; }

        public int HitPoints => _health;

        public Person(string name)
        {
            this.Name = name;
            this._health = maxHealth;
        }

        public void Attack(IPerson enemy)
        {
            if (this._weapon.AttackRoll(this, enemy))
                this._weapon.Hit(enemy);
        }

        public void PickArmor(IArmor armor)
        {
            this._armor = armor;
            Console.WriteLine($"{this.Name} picks armor: {armor.Name}");
        }

        public void PickWeapon(IWeapon weapon)
        {
            this._weapon = weapon;
            Console.WriteLine($"{this.Name} picks weapon: {weapon.Name}");
        }

        public int Initiative(Dice dice)
        {
            return dice.Roll(EDice.D20);
        }

        public bool HitArmor(int roll)
        {
            return this._armor.HitArmor(roll);
        }

        public void DecreaseHealth(int roll)
        {
            this._health -= roll;
            var result = CheckStatus();
            Console.WriteLine($"{this.Name} loosing {roll} hit points and {result}");
        }

        public EPersonStatus CheckStatus()
        {
            if (this._health <= 0)
                return EPersonStatus.Dead;

            if (this._health < maxHealth * 0.4)
                return EPersonStatus.BadlyWounded;

            if (this._health < maxHealth * 0.9)
                return EPersonStatus.Wounded;

            return EPersonStatus.Alive; ;
        }

        public override string ToString()
        {
            return $"{this.Name}, w:{this._weapon?.Name}, a:{this._armor?.Name}, hp:{this._health}";
        }
    }
}
