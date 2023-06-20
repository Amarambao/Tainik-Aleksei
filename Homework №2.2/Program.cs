using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__2._2
{
    internal class Program
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
        static void Main(string[] args)
        {
            string a = "qwert", b = "asdfg", c = "zxcvb";
            Console.WriteLine($"{a} {b} {c}");
            string d = a + b;
            Console.WriteLine(d);
            string e = string.Concat(a, "12345");
            Console.WriteLine(e);
            b = a;
            Console.WriteLine(b);
            Console.WriteLine($"{a.IndexOf('e')} {c.EndsWith("coi")}"); //индекс считается с 0, 2е выражение булевое
           /* string[] f = Console.ReadLine().Split();
            foreach (string s in f)
            {
                Console.WriteLine(s);
            } */
            c = c.Insert(5, " ][poi");
            Console.WriteLine(c);
            c = c.Remove(5, 3);
            Console.WriteLine(c);

            Person A = new Person(123, "Igosha");
            Console.WriteLine($"Индекс {A.Id} \nИмя {A.Name}");

            string NullString = null, EmptyString = "";
            Console.WriteLine(string.IsNullOrEmpty(EmptyString));
            Console.WriteLine(string.IsNullOrEmpty(NullString));
            if (string.IsNullOrEmpty(EmptyString))
            {
                EmptyString = "Not empty anymore";
                Console.WriteLine(EmptyString);
            }
            string[] String = Console.ReadLine().Split();
            StringBuilder StringBuilder1 = new StringBuilder();
            foreach (string str in String) //задача с лекции
            {
                if (str.EndsWith(".png"))
                    {
                    StringBuilder1.Append(str + " ");
                    } 
            }
            Console.WriteLine(StringBuilder1.ToString());
        }
    }
}
