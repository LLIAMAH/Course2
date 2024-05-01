var a = 234;
var b = (object)a;
var c = (int)b;

List<int> list = new List<int>();
list.Add(c);
list.Remove(c);
list.Add(a);
list.Add(a);
list.Add(a);
list.Add(a);
list.Add(a);

int aaaa = (short)list[0];

var inst1 = new GenericClass<int>();
var inst2 = new GenericClass<double>();
var inst3 = new GenericClass<string>();
var inst4 = new GenericClass<DataClass>();

var item = GenClass.Method<int, Object>(453);

Console.WriteLine("");

var itemUser = new object() as IRepUsers;
var itemSomeData = new object() as IRepSomeData;
var itemSomeData2 = new object() as IRep<long, User>;

return;

public interface IRep<TId, asdaDSFASDJFAS>
{
    string A { get; set; }
    A2 SomeMethod<A1,A2>(A1 testParam);
    IList<asdaDSFASDJFAS> Select(string A);
    asdaDSFASDJFAS Find(TId id);
    void Add(asdaDSFASDJFAS item);
    void Update(TId id, asdaDSFASDJFAS item);
    void Remove(asdaDSFASDJFAS item);
    void Remove(TId id);
}
public interface IRepUsers : IRep<string, User> { }

public class Rep<TId, T> : IRep<TId, T>
{
    public IList<T> Select()
    {
        throw new NotImplementedException();
    }

    public string A { get; set; }

    public A2 SomeMethod<A1, A2>(A1 testParam)
    {
        throw new NotImplementedException();
    }

    public IList<T> Select(string A)
    {
        throw new NotImplementedException();
    }

    public T Find(TId id)
    {
        throw new NotImplementedException();
    }

    public void Add(T item)
    {
        throw new NotImplementedException();
    }

    public void Update(TId id, T item)
    {
        throw new NotImplementedException();
    }

    public void Remove(T item)
    {
        throw new NotImplementedException();
    }

    public void Remove(TId id)
    {
        throw new NotImplementedException();
    }
}

public class RepUsers : IRepUsers, IRep<string, User>
{
    public IList<User> Select()
    {
        throw new NotImplementedException();
    }

    public string A { get; set; }

    public A2 SomeMethod<A1, A2>(A1 testParam)
    {
        throw new NotImplementedException();
    }

    public IList<User> Select(string A)
    {
        throw new NotImplementedException();
    }

    public User Find(string id)
    {
        throw new NotImplementedException();
    }

    public void Add(User item)
    {
        throw new NotImplementedException();
    }

    public void Update(string id, User item)
    {
        throw new NotImplementedException();
    }

    public void Remove(User item)
    {
        throw new NotImplementedException();
    }

    public void Remove(string id)
    {
        throw new NotImplementedException();
    }
}


public class User { }
public class SomeTable { }




public interface IRepSomeData : IRep<long, SomeTable> { }

public interface IGeneric<T>
{
    public T Method(T item);
}

public class GenericClass<T> : IGeneric<T>
{
    private T someField;
    public T Value { get; set; }

    public T Method(T item)
    {
        return default(T);
    }
}

public class GenClass
{
    public static TI Method<T,TI>(T someParam)
    {
        //......
        return default(TI);
    }
}



//using ConsoleAppTest1.Partials;

//var ctx = new DbConext();
//var repPerson = new RepPerson(ctx) as IRepPerson;
//var repCar = new RepCar(ctx) as IRepCar;

//var list = new List<DataClass>();
//var list2 = new System.Collections.ArrayList();
////DataClass a = new DataSubClass();

//list.Add(new DataClass()); // "DataClass"     "DataClass"
//list.Add(new DataClass()); // "DataClass"     "DataClass"
//list.Add(new DataSubClass()); // DataClass"   "DataSubClass"
//list.Add(new DataSubClass()); // DataClass"   "DataSubClass"
//list.Add(new DataClass()); // DataClass       "DataClass"
//list.Add(new DataSubClass()); // DataClass"   "DataSubClass"
//list.Add(new DataClass()); // DataClass       "DataClass"

//foreach (var dataClass in list)
//{
//    dataClass.TestMethod();
//}

////int aa = 12;
////object a = aa;
////int b = (int)a;
////==================================
//int i = 1; // i<=1;
//object obj = i;// i<=1, obj<=[1]
//++i; // i<=2 obj<=[1]
//                              //Squirel  Serega  Bogdan
//Console.WriteLine(i);         //  2        2       2
//Console.WriteLine(obj);       //  1        1       1   
//Console.WriteLine((short)obj);//  1        1       Exception
////==================================
//return;

public class DataClass
{
    public virtual void TestMethod()
    {
        Console.WriteLine("DataClass");
    }
}

//public class DataSubClass : DataClass
//{
//    public new bool TestMethod()
//    {
//        return true;
//        Console.WriteLine("DataSubClass");
//    }
//}

//public abstract class AbstractClass
//{


//    public void Test()
//    {
//        Console.WriteLine("Test");
//    }
//}

//public class Data : AbstractClass
//{
//    public void Test2()
//    {
//        Test();
//    }
//}

////using ConsoleAppTest1.Partials;

////DataStruct ds = default;
////DataClass dc = new DataClass();

////ds.SomeMethod(); // "DataStruct"
////dc.SomeMethod(); // "<null>"

////int a;

////Console.WriteLine("Test"); // "Test"
////return;

////struct DataStruct
////{
////    public string FirstName { get; set; }
////    public string LastName { get; set; }

////    public void SomeMethod()
////    {
////        Console.WriteLine("DataStruct");
////    }
////}

////class DataClass2 : DataClass
////{
////    public void SomeMethod2()
////    {

////    }
////}

////public interface IInterface
////{
////    void SomeMethod2();
////}

////abstract class AbstractClass : IInterface
////{
////    public void SomeMethod2()
////    {
////        throw new NotImplementedException();
////    }
////}