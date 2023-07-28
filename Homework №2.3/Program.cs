using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__2._3
{
    internal class Program
    {
        static Tuple<int, string, char, string, ulong> 
        CreateTuple(int age, string name, char a, string city)
        {
            name = name.ToUpper();
            if (a != 'm' && a != 'f')
            {
                a = '0';
            }
            city = city.ToUpper();
            Random rnd = new Random();
            //ulong id = 1;
            ulong id = (ulong)rnd.Next();
            return Tuple.Create <int, string, char, string, ulong> (age, name, a, city, id);
        }
        static void Main(string[] args)
        {
            var Tuple1 = CreateTuple(24, "ASD", 'f', "zxc");
            var Tuple2 = CreateTuple(24, "ASD", 'f', "zxc");
            Console.WriteLine (Tuple1);
            Console.WriteLine ($"{Tuple1.Item2} {Tuple1.Item5}");
            Console.WriteLine (Tuple1 == Tuple2);

            (int, int) tuple1 = (1, 2);
            Console.WriteLine (tuple1.Item1 + " + " + tuple1.Item2 + " = " + tuple1.Item1 + tuple1.Item2);
            ValueTuple<int, int> VTuple1 = new ValueTuple<int, int>(1, 2);
            ValueTuple<int, int> VTuple2 = new ValueTuple<int, int>(1, 2);
            Console.WriteLine (VTuple1 == VTuple2);
            //Tuple<int, double, string> BTuple1 = new Tuple<int, double, string> (1, _, "asd");
        }
    }
}
