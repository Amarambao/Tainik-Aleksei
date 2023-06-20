using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__2._1
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Bool = true;
            Console.WriteLine(Bool);
            Bool = false;
            Console.WriteLine(Bool);

            /*
            uint Int1 = Convert.ToUInt32(Console.ReadLine());
            int Int2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Int1 + " " + Int2);
                                    
            double Double1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Double1);
            */

            int? IntNull = null;
            int IntNotNull = IntNull ?? 123;
            Console.WriteLine(IntNotNull + " " + IntNull);

            char Char1 = 'a';
            Console.WriteLine(Char1 + " " + (int)Char1);

            byte Byte1 = 4;
            Console.WriteLine(Byte1);
            int IntByte = Byte1 + 123;
            Console.WriteLine(IntByte);
            
            Person A = new Person(123, "Igosha");

            string String1 = "STRING";
            Object STR = String1;
            Console.WriteLine(STR);

            string String2 = (string)STR;
            Console.WriteLine(String2);

            var Array = new [] {"Name", "Surname", "Patronymic" };
            foreach (var a in Array)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
            var Var = true;
            Console.WriteLine(Var);
            //Var = "STRING"; //не сработает тк Var уже считается переменной булевого типа
        }
    }
}
