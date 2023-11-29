using Course2.DB;
using Course2.DB.Entities;
using Microsoft.EntityFrameworkCore;

// New: Entity Framework
// Old: ADO.NET

using (var ctx = new AppDbCtx())
{
    foreach (var color in ctx.Colors)
    {
        Console.WriteLine($"{color.Id}: {color.Name}");
    }
}

//using (var ctx = new AppDbCtx())
//{
//    try
//    {
//        ctx.Users.Add(new User() { Name = "Vasiliy", Surname = "S" });
//        ctx.Users.Add(new User() { Name = "Anastcia", Surname = "Y" });
//        ctx.Users.Add(new User() { Name = "Bogdan", Surname = "H" });

//        ctx.SaveChanges();
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//        if(ex.InnerException != null)
//            Console.WriteLine(ex.InnerException.Message);
//    }
//}

//using (var ctx = new AppDbCtx())
//{
//    ctx.Brands.Add(new Brand() { Name = "BMW" });
//    ctx.Brands.Add(new Brand() { Name = "Fiat" });
//    ctx.Brands.Add(new Brand() { Name = "Toyota" });

//    var colorBlack = ctx.Colors.FirstOrDefault(c => c.Name == "Black");
//    var owner = ctx.Users.FirstOrDefault(o => o.Name == "Vasiliy" && o.Surname == "H");

//    if (colorBlack != null && owner != null)
//    {
//        ctx.Cars.Add(new Car()
//        {
//            Brand = new Brand() { Name = "Peugeot" },
//            ColorId = colorBlack.Id,
//            Number = "VVX-4536",
//            Vin = "sdafja;slekjrq;welkrwq",
//            UserId = owner.Id
//        });
//    }

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

using (var ctx = new AppDbCtx())
{
    var car = ctx.Cars
        .Include(o => o.Brand)
        .Include(o => o.Owner)
        .Include(o => o.Color)
        .FirstOrDefault(o => o.Brand.Name == "Peugeot");

    Console.WriteLine(
        $"{car.Id}, {car.Brand.Name}, {car.Color.Name}, {car.Number}, {car.Vin}, {car.Owner.Name}, {car.Owner.Surname}");
}