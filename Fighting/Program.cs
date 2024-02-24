var rand = new Random();
var dice = new Dice(rand);

IShop shop = new Shop(dice);

IPerson person1 = new Person("Anastacia");
IPerson person2 = new Person("Bohdan");

person1.PickArmor(shop.GetArmor());
person2.PickArmor(shop.GetArmor());
person1.PickWeapon(shop.GetWeapon());
person2.PickWeapon(shop.GetWeapon());

var order = RollInitiative(dice, person1, person2);
do
{
    order.Hits();
} while (!order.CheckDead());

Console.WriteLine(order.OutputWinner());


// ================================================================================

IOrder RollInitiative(Dice dice, IPerson p1, IPerson p2)
{
    int roll1;
    int roll2;

    do
    {
        roll1 = person1.Initiative(dice);
        roll2 = person2.Initiative(dice);
    } while (roll1 != roll2);

    return roll1 > roll2
        ? new Order(person1, person2)
        : new Order(person2, person1);
}

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

public interface IOrder
{
    IPerson First { get; }
    IPerson Last { get; }
    void Hits();
    bool CheckDead();
    string OutputWinner();
}

public class Order : IOrder
{
    public IPerson First { get; }
    public IPerson Last { get; }

    public Order(IPerson p1, IPerson p2)
    {
        this.First = p1;
        this.Last = p2;
    }
    
    public void Hits()
    {
        this.First.Attack(this.Last);
        this.Last.Attack(this.First);
    }

    public bool CheckDead()
    {
        return this.First.CheckStatus() == EPersonStatus.Dead 
            || this.Last.CheckStatus() == EPersonStatus.Dead;
    }

    public string OutputWinner()
    {
        if(this.First.CheckStatus() == EPersonStatus.Dead && this.Last.CheckStatus() == EPersonStatus.Dead)
            return $"{this.First.Name} and {this.Last.Name} are dead. There is no winner in this battle.";

        return this.First.CheckStatus() == EPersonStatus.Dead
            ? $"The winner is - {this.Last.Name} hp:{this.Last.HitPoints}"
            : $"The winner is - {this.First.Name} hp:{this.Last.HitPoints}";
    }
}

public interface IShop
{
    IArmor GetArmor();
    IWeapon GetWeapon();
}

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

public interface IWeapon
{
    string Name { get; }
    bool AttackRoll(IPerson attacker, IPerson enemy);
    void Hit(IPerson enemy);
}

public abstract class Weapon : IWeapon
{
    public string Name { get; protected set; }
    protected Dice _dice;
    protected EDice _hitDamage;

    public bool AttackRoll(IPerson attacker, IPerson enemy)
    {
        var roll = this._dice.Roll(EDice.D20);
        var result = enemy.HitArmor(roll);
        var resultString = result ? "hit" : "miss";
        Console.WriteLine($"{attacker.Name} attacks {enemy.Name} on {roll} and {resultString} his armor");
        return result;
    }

    public void Hit(IPerson enemy)
    {
        enemy.DecreaseHealth(_dice.Roll(_hitDamage));
    }
}

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

public interface IArmor
{
    public string Name { get; }
    bool HitArmor(int roll);
}

public abstract class Armor : IArmor
{
    protected EDice _armorLevel;
    public string Name { get; protected set; }
    public bool HitArmor(int roll)
    {
        return (int)_armorLevel < roll;
    }
}

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

public enum EDice
{
    D2 = 2,
    D4 = 4,
    D6 = 6,
    D8 = 8,
    D10 = 10,
    D12 = 12,
    D20 = 20,
    D100 = 100
}

public class Dice
{
    private readonly Random _rand;

    public Dice(Random rand)
    {
        this._rand = rand;
    }

    public int Roll(EDice dice = EDice.D10)
    {
        //_rand.Next(10): 0 1 2 3.. 9;
        return this._rand.Next((int)dice) + 1;
    }
}
