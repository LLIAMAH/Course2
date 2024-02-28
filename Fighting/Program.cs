using Fighting.Items;
using Fighting.Person;
using Fighting.Queue;

IShop shop = new Shop();

IPerson person1 = new Person("Anastacia");
IPerson person2 = new Person("Bohdan");

person1.PickArmor(shop.GetArmor());
person2.PickArmor(shop.GetArmor());
person1.PickWeapon(shop.GetWeapon());
person2.PickWeapon(shop.GetWeapon());

var order = Order.RollInitiative(person1, person2);
do
{
    order.Hits();
} while (!order.CheckDead());

Console.WriteLine(order.OutputWinner());