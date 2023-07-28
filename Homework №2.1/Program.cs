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
        public override string ToString()
        {
            return Id + " " + Name;
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
            string StringNull = null;
            string StringEmpty = "";
            string StringNotNull = "qwertyuiop";
            Console.WriteLine($"Null String = {string.IsNullOrEmpty(StringNull)} \n" +
                              $"Empty String = {string.IsNullOrEmpty(StringEmpty)} \n" +
                              $"NotNull String = {string.IsNullOrEmpty(StringNotNull)}");

            char Char1 = 'a';
            Console.WriteLine(Char1 + " " + (int)Char1);

            byte Byte1 = 4;
            Console.WriteLine(Byte1);
            int IntByte = Byte1 + 123;
            Console.WriteLine(IntByte);
            
            Person A = new Person(123, "Igosha");
            Console.WriteLine(A.ToString());

            string String1 = "STRING";
            Object STR = String1;
            Console.WriteLine(STR);
            int IntObj = 123456;
            Object ObjInt = IntObj + 1111111;
            Console.WriteLine(ObjInt);

            string String2 = (string)STR;
            Console.WriteLine(String2);

            var Array = new [] {"Name", "Surname", "FatherName" };
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
