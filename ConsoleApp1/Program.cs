using System.Collections;
using System.Drawing;

var rand = new Random();
var list = new List<int>();

for (var i = 0; i < 100; i++)
    list.Add(rand.Next(1000) + 1);

Console.Write("Unsorted list: ");
Console.WriteLine(string.Join(", ", list));

list.Sort(new ComparerInt());

//list = list.Order(new ComparerInt()).ToList();

//var angle = 30;
//var angleInRadians = Math.PI * angle / 180;
//var cos = Math.Cos(angleInRadians);
//var sin = Math.Sin(angleInRadians);

const int size = 360;
var array = new Angles[size];
for (var i = 0; i < size; i++)
    array[i] = new Angles(i);

var cosFi = array[30].Cos;
var sinFi = - array[30].Sin;



Console.Write("Sorted list: ");
Console.WriteLine(string.Join(", ", list));

public class ComparerInt : IComparer<int>
{
    public int Compare(int x, int y)
    {
        if (x > y) return 1;
        if (x < y) return -1;

        return 0;
    }
}

public class Angles
{
    public double Cos { get; private set; }
    public double Sin { get; private set; }

    public Angles(int angle)
    {
        var angleInRadians = Math.PI * angle / 180;
        this.Cos = Math.Cos(angleInRadians);
        this.Sin = Math.Sin(angleInRadians);
    }
}

//var someNumber = 7;

//var result = FactorialRecursive(someNumber);

//Console.WriteLine(result);

////6! = 1 * 2 * 3 * 4 * 5 * 6
//long FactorialLoop(int number)
//{
//    var result = 1L;
//    for (var i = 2; i <= number; i++)
//        result = result * i;

//    return result;
//}

//long FactorialRecursive(int number)
//{
//    if (number is 1 or 0)
//        return 1;

//    return number * FactorialRecursive(number - 1);
//}




// Работа с формами и элементами управления - это уже прийдёт с опытом

// 00000000 00000000 00000000 00001111 = 15
// Utf16: 00000000 00000000
// UTF16: 00000000 00001111


//var a = new int[] { 4, 12, 24, 432, 14 };
//var str1 = string.Join(", ", a);
//Console.WriteLine(str1);
//for (var i = 0; i < a.Length; i++)
//{
//    Console.Write(a[i]);
//    Console.Write(", ");
//}
//Console.WriteLine();
//Console.WriteLine("=====================================================");

//var aa = new int[4, 3] { { 1, 4, 1 }, { 4, 11, 23 }, { 3, 41, 56 }, { 3, 41, 76 } };
//for (var j = 0; j < 3; j++)
//{
//    for (var i = 0; i < 4; i++)
//    {
//        Console.Write(aa[i, j]);
//        Console.Write(", ");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine();
//Console.WriteLine("=====================================================");

//var rand = new Random();

//var az = new int[10][];
//az[0] = new int[20];
//az[1] = new int[4];

//az[2] = new int[4];
//az[3] = new int[17];
//az[4] = new int[1];
//az[5] = new int[19];
//az[6] = new int[20];
//az[7] = new int[23];
//az[8] = new int[11];
//az[9] = new int[25];

//for (var i = 0; i < 10; i++)
//{
//    for (var j = 0; j < az[i].Length; j++)
//    {
//        az[i][j] = rand.Next(100) + 1;
//    }
//}

//for (var i = 0; i < 10; i++)
//{
//    for (var j = 0; j < az[i].Length; j++)
//    {
//        Console.Write(az[i][j]);
//        Console.Write(", ");
//    }
//    Console.WriteLine();
//}