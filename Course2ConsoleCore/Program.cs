using MyType = Course2ConsoleCore.TestType.Person;

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

System.Int64 a = 0;
long b = 0;

byte byteValue = 250;
for (byte i = 0; i < 10; i++)
{
    byte b1 = (byte)(byteValue + i);
    Console.WriteLine($"Хрен знает что!: {b1}");
}

//MyType person1 = new MyType();
//Course2ConsoleCore.TestType.Person person2 = new Course2ConsoleCore.TestType.Person();
var person3 = new MyType();
person3 = new MyType();

dynamic person4 = new MyType();
person4 = "sdfasdfasdf";
person4 = 5;

/// 00000100    
/// 00000000

/// 00000000 00000000
/// 00000000 00000000 00000000 00000000

float floatAdd = 0.0F;
var floatAdd1111 = 0.0F;
double doubleAdd2 = 1000000000000000000000.000000000000000000000000000000000000000000000000000000000000001;

float floatAdd3 = (float)doubleAdd2;
double doubleAdd4 = (double)floatAdd;

//for (var i = char.MinValue; i <= char.MaxValue; i++)
//{
//    Console.Write(i);
//}

int intValue = 0;
// + - / * %
// << >>

/// 0000001
byte byte1 = 1;
byte1 = (byte)(byte1 << 3);
/// 00000010
///
int aaaa = 10;
aaaa += 20;
aaaa *= 20;
aaaa /= 20;
aaaa <<= 20;
aaaa >>= 2;

/// logical
/// && || != < > <= >= 
bool boolValue = false;
bool boolValue2 = !boolValue; // <-- true;
           
//-----------------------
// AND  | 1  1 | 1
// OR   | 1  1 | 1
// not
                // false AND true;
var tBool = (boolValue && boolValue2 && (10 > 3)); // <-- false;
var tBool1 = (boolValue2 || boolValue); // <-- false;

     // true        true     ! (  true ||   false)
if((boolValue2 || tBool1) && !(boolValue2 || tBool))
    Console.WriteLine("Какая то логическая фигня");

var aEnum = TestEnum.Test1;
var aEnum1Int = (int)TestEnum.Test2; // aEnum1Int <-- 15
var aEnum1Strin = TestEnum.Test2.ToString(); // aEnum1Strin "Test2"

for (var i = TestEnum.Test1; i != TestEnum.Test3; i++)
{
}

// 0000
//      00 -XY вверх 1 или вниз - 0
//         00 - XY - Y - должны поворачивать (1) или нет (0)
//                   X -  1 - лево 0 - право

//0000 0010

int missileControl = 0b00000010;
// & | ^
var res1 
    = missileControl & (int)ControlDirection.LeftTurn; // 0x00000100;
var res2 = missileControl & 0b00000100;
var res3 = missileControl ^ 0b00000100;

enum TestEnum
{
    Testsdfasdfasdf, // by default = 0
    Test1 = 12, // by default = 0
    Test2 = 15,
    Test3 = 16,
}


[Flags]
enum ControlDirection
{
    HorizontalWork = 0b0001,
    HorizontalRight = 0b0010,
    VerticalWork = 0b0100,
    VerticalTop = 0b1000,

    RightTurn = HorizontalWork | HorizontalRight,
    LeftTurn = HorizontalWork | ~HorizontalRight,
}
