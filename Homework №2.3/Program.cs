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
        CreateTuple(int age, string name, char gender, string city)
        {
            name = name.ToUpper();
            if (gender != 'm' && gender != 'f')
            {
                gender = '0';
            }
            city = city.ToUpper();
            Random rnd = new Random();
            //ulong id = 1;
            ulong id = (ulong)rnd.Next();
            return Tuple.Create <int, string, char, string, ulong> (age, name, gender, city, id);
        }
        static void Main(string[] args)
        {
            var Tuple1 = CreateTuple(24, "ASD", 'f', "zxc");
            var Tuple2 = CreateTuple(24, "ASD", 'f', "zxc");
            Console.WriteLine (Tuple1);
            Console.WriteLine ($"{Tuple1.Item2.ToString()} {Tuple1.Item5.ToString()}");
            if (Tuple1 == Tuple2) //false тк смотрит на ссылку
            {
                Console.WriteLine(true);
            } else
            {
                Console.WriteLine(false);
            }
        }
    }
}
