using System;
using System.Data;

try
{
    string ConvertableToInt = "123456";
    string NonConvertableToInt = "qwerty";
    Console.WriteLine(Convert.ToInt32(ConvertableToInt));
    Console.WriteLine(Convert.ToInt32(NonConvertableToInt));
}
catch (Exception ConvertionFail)
{
    Console.WriteLine(ConvertionFail.Message);
    //Console.WriteLine(ConvertionFail.StackTrace);
    //Console.WriteLine(ConvertionFail.ToString());
}

try
{
    int x = 10;
    Console.WriteLine(x / 0);
}
catch (DivideByZeroException DBZE)
{
    Console.WriteLine(DBZE.Message);
}

try // не вышло
{
    
}
catch (ArgumentOutOfRangeException AOORE)
{
    Console.WriteLine(AOORE.Message);
}
//int z = 30;
//if (z > 18)
//{
//    throw new ArgumentOutOfRangeException(nameof(z));
//}
try
{
    int[] array = new int[10];
    array[11] = 11;
}
catch (IndexOutOfRangeException IOORE)
{
    Console.WriteLine(IOORE.Message);
}

try //не вышло
{
    void Repeat(int x)
    {
        Console.WriteLine(x);
    }
    string a = Console.ReadLine();
    Repeat(a[0]);
}
catch (ArgumentException AE)
{
    Console.WriteLine(AE.Message);
}

try
{
    object obj = new object();
    int i = (int)obj;
}
catch (InvalidCastException ICE)
{
    Console.WriteLine(ICE.Message);
}

try
{
    List<int> list = null;
    Console.WriteLine(list[0]);
}
catch (NullReferenceException NRE)
{
    Console.WriteLine(NRE.Message);
}