using ConsoleAppTest1.Partials;

var ctx = new DbConext();
var repPerson = new RepPerson(ctx) as IRepPerson;
var repCar = new RepCar(ctx) as IRepCar;

var list = new List<DataClass>();
var list2 = new System.Collections.ArrayList();
//DataClass a = new DataSubClass();

list.Add(new DataClass()); // "DataClass"     "DataClass"
list.Add(new DataClass()); // "DataClass"     "DataClass"
list.Add(new DataSubClass()); // DataClass"   "DataSubClass"
list.Add(new DataSubClass()); // DataClass"   "DataSubClass"
list.Add(new DataClass()); // DataClass       "DataClass"
list.Add(new DataSubClass()); // DataClass"   "DataSubClass"
list.Add(new DataClass()); // DataClass       "DataClass"

foreach (var dataClass in list)
{
    dataClass.TestMethod();
}

//int aa = 12;
//object a = aa;
//int b = (int)a;
//==================================
int i = 1; // i<=1;
object obj = i;// i<=1, obj<=[1]
++i; // i<=2 obj<=[1]
                              //Squirel  Serega  Bogdan
Console.WriteLine(i);         //  2        2       2
Console.WriteLine(obj);       //  1        1       1   
Console.WriteLine((short)obj);//  1        1       Exception
//==================================
return;

public class DataClass
{
    public virtual void TestMethod()
    {
        Console.WriteLine("DataClass");
    }
}

public class DataSubClass : DataClass
{
    public new bool TestMethod()
    {
        return true;
        Console.WriteLine("DataSubClass");
    }
}

public abstract class AbstractClass
{


    public void Test()
    {
        Console.WriteLine("Test");
    }
}

public class Data : AbstractClass
{
    public void Test2()
    {
        Test();
    }
}

//using ConsoleAppTest1.Partials;

//DataStruct ds = default;
//DataClass dc = new DataClass();

//ds.SomeMethod(); // "DataStruct"
//dc.SomeMethod(); // "<null>"

//int a;

//Console.WriteLine("Test"); // "Test"
//return;

//struct DataStruct
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }

//    public void SomeMethod()
//    {
//        Console.WriteLine("DataStruct");
//    }
//}

//class DataClass2 : DataClass
//{
//    public void SomeMethod2()
//    {

//    }
//}

//public interface IInterface
//{
//    void SomeMethod2();
//}

//abstract class AbstractClass : IInterface
//{
//    public void SomeMethod2()
//    {
//        throw new NotImplementedException();
//    }
//}