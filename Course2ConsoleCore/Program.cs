
//bool a = false;
//bool b = true;

//// ==, <, >, <=, >=, !=, унарная операция !,

//if (!a)
//    Console.WriteLine("True");
//else
//    Console.WriteLine("False");


byte byteValueMin = Byte.MinValue;
byte byteValueMax = Byte.MaxValue;

Console.WriteLine($"Byte value min: {byteValueMin}");
Console.WriteLine($"Byte value max: {byteValueMax}");

double floatA = 0.0;
double floatA1 = 0.01;
double floatB = 0.0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001;
double floatB1 = 0.00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001;

if (Math.Abs(floatA - floatA1) < 0.00001)
    Console.WriteLine("Хрен знает что!");