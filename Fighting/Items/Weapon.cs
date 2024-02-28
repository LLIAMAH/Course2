using Fighting.Person;
using Fighting.Random;

namespace Fighting.Items
{
    public abstract class Weapon : IWeapon
    {
        public string Name { get; protected set; }
        protected EDice _hitDamage;

        public bool AttackRoll(IPerson attacker, IPerson enemy)
        {
            var roll = Dice.Roll(EDice.D20);
            var result = enemy.HitArmor(roll);
            var resultString = result ? "hit" : "miss";
            Console.WriteLine($"{attacker.Name} attacks {enemy.Name} on {roll} and {resultString} his armor");
            return result;
        }

        public void Hit(IPerson enemy)
        {
            enemy.DecreaseHealth(Dice.Roll(_hitDamage));
        }
    }
}
