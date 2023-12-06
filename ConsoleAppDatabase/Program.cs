using Course2.DB;
using Course2.DB.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Color = Course2.DB.Entities.Color;

using (var ctx = new AppDbCtx())
{
    var modelValue = "530";
    var m = ctx.Models
        .Include(o => o.Brand).ThenInclude(o => o.Cars).ThenInclude(o => o.Color)
        .Include(o => o.Brand).ThenInclude(o => o.Cars).ThenInclude(o => o.Owner)
        .FirstOrDefault(o => o.Name == modelValue)
        .Brand.Cars;
}

//using (var ctx = new AppDbCtx())
//{
//    var model = ctx.Models.FirstOrDefault(o => o.Name == "530");
//}

//// New: Entity Framework
//// Old: ADO.NET
///
//using (var ctx = new AppDbCtx())
//{
//    var model = ctx.Models.FirstOrDefault(o => o.Name == "530");
//}

//using (var ctx = new AppDbCtx())
//{
//    var model = ctx.Models
//        .Include(o=>o.Brand)
//        .FirstOrDefault(o => o.Name == "530");
//}

//using (var ctx = new AppDbCtx())
//{
//    var user = new User() { Name = "Vasiliy", Surname = "H" };
//    ctx.Users.Add(user);
//    ctx.SaveChanges();
//}

//long brandId, modelId, colorId, userId;

//using (var ctx = new AppDbCtx())
//{
//    var brand = ctx.Brands.Include(o => o.Models).First(o => o.Name == "BMW");
//    var model = brand.Models.First(o => o.Name == "530");
//    var color = ctx.Colors.FirstOrDefault(o => o.Name == "Orange");
//    var user = ctx.Users.FirstOrDefault(o=>o.Name == "Vasiliy");

//    brandId = brand.Id;
//    modelId = model.Id;
//    colorId = color.Id;
//    userId = user.Id;

//    ctx.Cars.Add(new Car()
//    {
//        Owner = user,
//        Color = color,
//        Number = "NT-2415",
//        Vin = "SLKJEWTRERPOT",
//        Brand = brand,
//        Model = model,
//    });

//    try
//    {
//        ctx.SaveChanges();
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//        if (ex.InnerException != null)
//            Console.WriteLine(ex.InnerException.Message);
//    }
//}

//using (var ctx = new AppDbCtx())
//{
//    ctx.Cars.Add(new Car()
//    {
//        UserId = userId,
//        ColorId = colorId,
//        Number = "NT-2416",
//        Vin = "FLKJEWTRERPOH",
//        BrandId = brandId,
//        ModelId = modelId,
//    });

//    try
//    {
//        ctx.SaveChanges();
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//        if (ex.InnerException != null)
//            Console.WriteLine(ex.InnerException.Message);
//    }
//}


//using (var ctx = new AppDbCtx())
//{
//    var list = new List<Brand>()
//    {
//        new Brand()
//        {
//            Name = "Bmw", Models = new List<Model>()
//            {
//                new Model() { Name = "230" },
//                new Model() { Name = "530" },
//                new Model() { Name = "535" },
//                new Model() { Name = "X1" },
//                new Model() { Name = "X3" },
//                new Model() { Name = "X5" },
//                new Model() { Name = "X6" },
//            }
//        },
//        new Brand()
//        {
//            Name = "Peugeot", Models = new List<Model>()
//            {
//                new Model() { Name = "204" },
//                new Model() { Name = "306" },
//                new Model() { Name = "407" },
//                new Model() { Name = "5008" },
//            }
//        },
//        new Brand()
//        {
//            Name = "Toyota", Models = new List<Model>()
//            {
//                new Model() { Name = "Land Cruiser" },
//                new Model() { Name = "Taiga" }
//            }
//        }
//    };

//    ctx.Brands.AddRange(list);

//    try
//    {
//        ctx.SaveChanges();
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//        if (ex.InnerException != null)
//            Console.WriteLine(ex.InnerException.Message);
//    }
//}

//using (var ctx = new AppDbCtx())
//{
//    var listMemory = ctx.Colors.ToList();
//    //var listMemory = ctx.Colors.Where(o=>o.Name.StartsWith("B")).ToList();
//    //var listDataBase = ctx.Colors.Where(o => o.Name.StartsWith("B"));

//    for (var i = 0; i < listMemory.Count; i++)
//    {
//        Console.WriteLine($"{listMemory[i].Id}: {listMemory[i].Name}");
//        i = i + 2;
//    }

//    var enumer = (IEnumerator<Color>)listMemory;
//    Color t;
//    do
//    {
//        t = enumer.Current;
//    } while (enumer.MoveNext());

//    enumer.Reset();
//    do
//    {
//        t = enumer.Current;
//    } while (enumer.MoveNext());


//    //foreach (var color in listMemory)
//    //{
//    //    Console.WriteLine($"{color.Id}: {color.Name}");
//    //}

//    //Console.WriteLine("==================================================");

//    //foreach (var color in listDataBase)
//    //{
//    //    Console.WriteLine($"{color.Id}: {color.Name}");
//    //}
//}

////using (var ctx = new AppDbCtx())
////{
////    try
////    {
////        ctx.Users.Add(new User() { Name = "Vasiliy", Surname = "S" });
////        ctx.Users.Add(new User() { Name = "Anastacia", Surname = "Y" });
////        ctx.Users.Add(new User() { Name = "Bogdan", Surname = "H" });

////        ctx.SaveChanges();
////    }
////    catch (Exception ex)
////    {
////        Console.WriteLine(ex.Message);
////        if (ex.InnerException != null)
////            Console.WriteLine(ex.InnerException.Message);
////    }
////}

////using (var ctx = new AppDbCtx())
////{
////    //ctx.Brands.Add(new Brand() { Name = "BMW" });
////    //ctx.Brands.Add(new Brand() { Name = "Fiat" });
////    //ctx.Brands.Add(new Brand() { Name = "Toyota" });

////    var colorBlack = ctx.Colors.FirstOrDefault(c => c.Name == "Black");
////    var owner = ctx.Users.FirstOrDefault(o => o.Name == "Vasiliy" && o.Surname == "S");

////    if (colorBlack != null && owner != null)
////    {
////        ctx.Cars.Add(new Car()
////        {
////            Brand = new Brand() { Name = "Peugeot" },
////            ColorId = colorBlack.Id,
////            Number = "VVX-4536",
////            Vin = "sdafja;slekjrq;welkrwq",
////            UserId = owner.Id
////        });
////    }

////    try
////    {
////        ctx.SaveChanges();
////    }
////    catch (Exception ex)
////    {
////        Console.WriteLine(ex.Message);
////        if (ex.InnerException != null)
////            Console.WriteLine(ex.InnerException.Message);
////    }
////}

////using (var ctx = new AppDbCtx())
////{
////    var car = ctx.Cars
////        .Include(o => o.Brand)
////        .Include(o => o.Owner)
////        .Include(o => o.Color)
////        .FirstOrDefault(o => o.Brand.Name == "Peugeot");

////    if (car != null)
////    {
////        ctx.Cars.Remove(car);
////        try
////        {
////            ctx.SaveChanges();
////        }
////        catch (Exception ex)
////        {
////            Console.WriteLine(ex.Message);
////            if (ex.InnerException != null)
////                Console.WriteLine(ex.InnerException.Message);
////        }
////    }
////}


////using (var ctx = new AppDbCtx())
////{
////    var brand = ctx.Brands.FirstOrDefault(o => o.Name == "Peugeot");
////    if (brand != null)
////    {
////        var dateTime = new DateTime(2023, 12, 02, 18, 20, 00);
////        var car = ctx.Cars
////            .TemporalBetween(dateTime.AddMinutes(-10), dateTime.AddMinutes(+20))
////            .FirstOrDefault(o => o.BrandId == brand.Id);

////        if (car == null)
////            Console.WriteLine("No car found");
////        else
////            Console.WriteLine(
////                $"{car.Id}, {car.BrandId}, {car.ColorId}, {car.Number}, {car.Vin}, {car.UserId}");
////        //Console.WriteLine(
////        //    $"{car.Id}, {car.Brand.Name}, {car.Color.Name}, {car.Number}, {car.Vin}, {car.Owner.Name}, {car.Owner.Surname}");
////    }
////}


////// КОНТРАКТ
////public interface ISomeInterface1
////{
////    void DoSomething();
////}

////public interface ISomeInterface2
////{
////    void DoSomething();
////}

////public interface ISomeInterfaceCommon: ISomeInterface1, ISomeInterface2
////{
////}

////public class SomeProcess : ISomeInterfaceCommon
////{
////    public void DoSomething()
////    {
////        Console.WriteLine("Do something");
////    }
////}

////public class SomeProcess2 
////{
////    public void DoSomething()
////    {
////        Console.WriteLine("Do something");
////    }
////}

////public class SomeProcessCommon : SomeProcess, ISomeInterface2, ISomeInterface1
////{
////    public void Test()
////    {
////        ((ISomeInterface2)instance).DoSomething();
////    }
////}