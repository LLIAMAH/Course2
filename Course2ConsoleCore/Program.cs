using System.Xml.Schema;
using Microsoft.VisualBasic.CompilerServices;
using MyType = Course2ConsoleCore.TestType.Person;


Console.Write("Enter some double value: ");
string inputValue1 = Console.ReadLine();

//var inputValueInt = Convert.ToInt32(inputValue1);
var inputValueInt = 0;
if (int.TryParse(inputValue1, out inputValueInt))
    Console.WriteLine($"Succsess: {inputValueInt}");
else
    Console.WriteLine($"Parsing failed: '{inputValue1}'");

//var inputValueDouble = Convert.ToDouble(inputValue1);

//var t = inputValueDouble;


//// inputValue1 может прийти строка: 342523423423.123141532049874
//double inputValueDouble2 = 0.0;
//if(double.TryParse(inputValue1, out inputValueDouble2))
//    Console.WriteLine($"Succsess: {inputValueDouble2}");
//else
//    Console.WriteLine($"Parsing failed: '{inputValue1}'");

// Задача - вывести таблицу умножения на экран
var array = new int[9, 9];
// i[.] 0 1 2 3 4 5 6 7 8
//j[0]: 0 0 0 0 0 0 0 0 0 
//j[1]: 0 0 0 0 0 0 0 0 0 
//j[2]: 0 0 0 0 0 0 0 0 0 
//j[3]: 0 0 0 0 0 0 0 0 0 
//j[4]: 0 0 0 0 0 0 0 0 0 
//j[5]: 0 0 0 0 0 0 0 0 0 
//j[6]: 0 0 0 0 0 0 0 0 0 
//j[7]: 0 0 0 0 0 0 0 0 0 
//j[8]: 0 0 0 0 0 0 0 0 0 


for (var j = 0; j < 9; j++)
{
    for (var i = 0; i < 9; i++)
    {
        array[i, j] = (i + 1) * (j + 1);
    }
}

for (var j = 0; j < 9; j++)
{
    OutputRow(array, j);
}

void OutputRow(int[,] array_m, int j)
{
    var stringOut = string.Empty;
    for (var i = 0; i < 9; i++)
    {
        //                1x1 = 1
        stringOut += $"{i + 1}x{j + 1} = {array_m[i,j]} ";
        //stringOut += string.Format("{0}x{1} = {2}", i + 1, j + 1, array_m[i, j]);
    }

    Console.WriteLine($"Output row: {stringOut}");
}

//==============================================================================
var resDouble = Test.Multiply(45.56, 12.35);
var resInt = Test.Multiply(45, 12);

Console.WriteLine(resDouble);
Console.WriteLine(resInt);

var arrayInt = new int[] { 4, 3, 5, 2, 6, 2, 3, 10, 9, 32 };
var arrayDouble = new double[] { 4.56, 3.3, 5.01, 2.1, 6.9, 2.2, 3.3, 10.4, 9.2, 32.8 };

ArrayOutput(arrayInt);
Console.WriteLine("-------------------------------------");
ArrayOutput(arrayDouble);
Console.WriteLine("=====================================");

Test.Swap(ref arrayInt[4], ref arrayInt[5]);
Test.Swap(ref arrayDouble[4], ref arrayDouble[5]);

ArrayOutput(arrayInt);
Console.WriteLine("-------------------------------------");
ArrayOutput(arrayDouble);
Console.WriteLine("=====================================");

int param = 10;
ChangeParameter(ref param);
Console.WriteLine(param); // <-???

int someParam;
SetValue(out someParam);
Console.WriteLine(param); // <-???

bool a;

return;

void ChangeParameter2(int a)
{
    a = 5;
}

void ChangeParameter(ref int a)
{
    a = 5;
}

void SetValue(out int b)
{
    b = 12;
}

void ProcessParam(in int c)
{
    //c = 14;
}

void ArrayOutput<T>(T[] array)
{
    var res = string.Join(", ", array);
    Console.WriteLine(res);
}

class Test
{
                                 // 5         7
    public static void Swap<T>(ref T a, ref T b)
    {
        var temp = a;   // temp <-5, a == 5, b == 7
        a = b;            // temp == 5, a <-7, b == 7; 
        b = temp;         // temp == 5, b <- 5, a == 7
    }

    public static T[] ReturnArray<T>(int size)
    {
        return new T[size];
    }
    
    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }
}

/* ======================================================================= СходитьЗаХлебом(Х)
 * 1. Выходим из дома
 * 2. Захоздим в лифт      \ Под Программой - Ехать НаЛИфтеНаЭтаж(X) 
 * 3. Спускаемся на этаж 1 /
 * 4. Выходим из подъеда
 * 5. выходим на тротуар
 * 6. ЖДём зелёного света
 * 7. Переходжим длорогу
 * 8. Заходим в магазим
 * 9. Покупаем нужное
 * 10. Выходим из магазина
 * 11. ..
 ========================================================================= */

//var arrayInt = new long[10];

//// Ввести 10 элементов
//arrayInt[0] = 1;
//arrayInt[1] = 441;
//arrayInt[2] = 409238;
//arrayInt[3] = 423;
//arrayInt[4] = 348;
//arrayInt[5] = 4902;
//arrayInt[6] = 324;
//arrayInt[7] = 6404;
//arrayInt[8] = 56;
//arrayInt[9] = 321;

//// Показать эти 10 элементов на экране.
//ArrayOutput(arrayInt);

//Console.WriteLine("----------------------------");

//// Обработать - пройти по каждому элементу массива и перезаписать его - его квадратом числа.
//for (var i = 0; i < arrayInt.Length; i++)
//    arrayInt[i] = arrayInt[i] * arrayInt[i]; // <- 441 * 441

//Console.WriteLine("Result: ");
//// Показать эти 10 элементов - уже новые - на экране.
//ArrayOutput(arrayInt);

////bool a = false;
////bool b = true;

////// ==, <, >, <=, >=, !=, унарная операция !,

////if (!a)
////    Console.WriteLine("True");
////else
////    Console.WriteLine("False");


//byte byteValueMin = Byte.MinValue;
//byte byteValueMax = Byte.MaxValue;

//Console.WriteLine($"Byte value min: {byteValueMin}");
//Console.WriteLine($"Byte value max: {byteValueMax}");

//double floatA = 0.0;
//double floatA1 = 0.01;
//double floatB = 0.0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001;
//double floatB1 = 0.00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001;

//if (Math.Abs(floatA - floatA1) < 0.00001)
//    Console.WriteLine("Хрен знает что!");

//System.Int64 a = 0;
//long b = 0;

//byte byteValue = 250;
//for (byte i = 0; i < 10; i++)
//{
//    byte b1 = (byte)(byteValue + i);
//    Console.WriteLine($"Хрен знает что!: {b1}");
//}

////MyType person1 = new MyType();
////Course2ConsoleCore.TestType.Person person2 = new Course2ConsoleCore.TestType.Person();
//var person3 = new MyType();
//person3 = new MyType();

//dynamic person4 = new MyType();
//person4 = "sdfasdfasdf";
//person4 = 5;

///// 00000100    
///// 00000000

///// 00000000 00000000
///// 00000000 00000000 00000000 00000000

//float floatAdd = 0.0F;
//var floatAdd1111 = 0.0F;
//double doubleAdd2 = 1000000000000000000000.000000000000000000000000000000000000000000000000000000000000001;

//float floatAdd3 = (float)doubleAdd2;
//double doubleAdd4 = (double)floatAdd;

////for (var i = char.MinValue; i <= char.MaxValue; i++)
////{
////    Console.Write(i);
////}

//int intValue = 0;
//// + - / * %
//// << >>

///// 0000001
//byte byte1 = 1;
//byte1 = (byte)(byte1 << 3);
///// 00000010
/////
//int aaaa = 10;
//aaaa += 20;
//aaaa *= 20;
//aaaa /= 20;
//aaaa <<= 20;
//aaaa >>= 2;

///// logical
///// && || != < > <= >= 
//bool boolValue = false;
//bool boolValue2 = !boolValue; // <-- true;

////-----------------------
//// AND  | 1  1 | 1
//// OR   | 1  1 | 1
//// not
//                // false AND true;
//var tBool = (boolValue && boolValue2 && (10 > 3)); // <-- false;
//var tBool1 = (boolValue2 || boolValue); // <-- false;

//     // true        true     ! (  true ||   false)
//if((boolValue2 || tBool1) && !(boolValue2 || tBool))
//    Console.WriteLine("Какая то логическая фигня");

//var aEnum = TestEnum.Test1;
//var aEnum1Int = (int)TestEnum.Test2; // aEnum1Int <-- 15
//var aEnum1Strin = TestEnum.Test2.ToString(); // aEnum1Strin "Test2"

//for (var i = TestEnum.Test1; i != TestEnum.Test3; i++)
//{
//}

//// 0000
////      00 -XY вверх 1 или вниз - 0
////         00 - XY - Y - должны поворачивать (1) или нет (0)
////                   X -  1 - лево 0 - право

////0000 0010

//int missileControl = 0b00000010;
//// & | ^
//var res1 
//    = missileControl & (int)ControlDirection.LeftTurn; // 0x00000100;
//var res2 = missileControl & 0b00000100;
//var res3 = missileControl ^ 0b00000100;

//IntegerType: 4byte

//  2147483647
// -2147483648
// 00000000 00000000 00000000 00000000
// 10000000 00000000 00000000 00000001

// 00000000 00000000 00000000 00000000 00000000 00000000 00000000 00000000
// 10000000 00000000 00000000 00000000 00000000 00000000 00000000 00000001

//int[] numsNonInitialized = new int[12];
//int[] numsNonInitialized2 = new int[120];
////numsNonInitialized2[0] = 34;
////numsNonInitialized2[1] = 1415;

//var init = 0;
//var resultInc1 = init++; // resultInc1 <- 0; init <- 1
//var resultInc2 = ++init; // resultInc2 <- 2; init <- 2

//for (var i = 0; i < numsNonInitialized.Length; i++)
//{
//    double test1;
//    numsNonInitialized[i] = i;
//}

//for (var i = 0; i < numsNonInitialized.Length; i++)
//    numsNonInitialized[i] = i;

//for (var i5 = 0; i5 < numsNonInitialized.Length; i5++)
//    numsNonInitialized[i5] = i5;

//{
//    var test23 = 6565;

//    {
//        var tesdt2 = test23;
//    }

//    {
//        var tesdt2 = 4;
//    }
//}

//for (var i = numsNonInitialized.Length - 1; i >= 0; i--)
//{
//    int test1;
//    numsNonInitialized[i] = i;
//}


//    var i2 = 0;
////while (i2 < numsNonInitialized2.Length)
//while (i2 < numsNonInitialized2.Length)
//{
//    if (i2 == 4)
//    {
//        i2++;
//        continue;
//    }

//    if (i2 == 7)
//        break;

//    numsNonInitialized2[i2] = i2;
//    i2++;
//}

//var i3 = numsNonInitialized2.Length - 1;
//while (i3 >= 0)
//{
//    numsNonInitialized2[i3] = i3;
//    i3--;
//}

//i2 = 0;
//do
//{
//    numsNonInitialized2[i2] = i2;
//    i2++; // 120
//} while(i2 < numsNonInitialized2.Length); // i2 < 120;


//foreach (var elem in numsNonInitialized2)
//{
//    var aa= elem * elem;
//}


//int[] numsInitialized = new[] { 3, 4, 2, 43, 4, 252 };
////                              0  1  2   3  4   5
//var someElement = numsInitialized[3]; // <-- 43

//int[,] nums2 = new int[5, 6]; // i j
//// 0 0 0 0 0 
//// 0 0 0 0 0 
//// 0 0 0 0 0 
//// 0 0 0 0 0 
//// 0 0 0 0 0 
//// 0 0 0 0 0 

//var nums2Val = nums2[2, 5];

//int[][] nums3 = new int[6][];

//nums3[0] = new int[3];
//nums3[1] = new int[4];
//nums3[2] = new int[5];
//nums3[3] = new int[1];
//nums3[4] = new int[10];
//nums3[5] = new int[125];

//enum TestEnum
//{
//    Testsdfasdfasdf, // by default = 0
//    Test1 = 12, // by default = 0
//    Test2 = 15,
//    Test3 = 16,
//}

//[Flags]
//enum ControlDirection
//{
//    HorizontalWork = 0b0001,
//    HorizontalRight = 0b0010,
//    VerticalWork = 0b0100,
//    VerticalTop = 0b1000,

//    RightTurn = HorizontalWork | HorizontalRight,
//    LeftTurn = HorizontalWork | ~HorizontalRight,
//}
