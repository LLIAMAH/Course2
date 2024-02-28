using Fighting.Items;
using Fighting.Random;

namespace Fighting.Person
{
    public enum EPersonStatus
    {
        Alive,
        Wounded,
        BadlyWounded,
        Dead
    }

    public interface IPerson
    {
        string Name { get; }
        int HitPoints { get; }
        void Attack(IPerson enemy);
        void PickArmor(IArmor armor);
        void PickWeapon(IWeapon weapon);
        int Initiative(Dice dice);
        bool HitArmor(int roll);
        void DecreaseHealth(int roll);
        EPersonStatus CheckStatus();
    }
}
