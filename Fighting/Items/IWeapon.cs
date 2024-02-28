using Fighting.Person;

namespace Fighting.Items
{
    public interface IWeapon
    {
        string Name { get; }
        bool AttackRoll(IPerson attacker, IPerson enemy);
        void Hit(IPerson enemy);
    }
}
