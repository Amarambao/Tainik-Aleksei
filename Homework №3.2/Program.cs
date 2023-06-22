using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            Stack<int> stack = new Stack<int>(list);
            Queue<int> queue = new Queue<int>(list);
            
            foreach (int i in list) // вывод списка
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            list.Add(0); // добавлен элемент в конец списка
            list.Sort(); // сортировка 0 станет 1м элементом
            list.RemoveAt(6); // удаление 6 элемента
            foreach (int i in list)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            list.Clear();

            Console.WriteLine();

            stack.Push(7);
            foreach (int i in stack) // вывод стека
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            stack.Pop(); // удаление 1го элемента из стека
            foreach (int i in stack) 
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            stack.Clear();

            Console.WriteLine();

            queue.Enqueue(7);
            foreach (int i in queue) // вывод очереди
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            queue.Dequeue(); // удаление 1го элемента из очереди
            foreach (int i in queue) 
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            queue.Clear();

            Console.WriteLine();

            Dictionary<int, string> dictionary = new Dictionary<int, string>()
            {
                { 1, "QWE"}, { 2, "ASD"}, { 3, "ZXC"}, {4, "rty"}, {5, "fgh"}, {6, "vbn"}
            };
            dictionary.Add(7, "ujm");
            foreach (var i in dictionary)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            dictionary.Remove(1);
            foreach (var i in dictionary)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            dictionary.Clear();
            
            Console.WriteLine();

            List<List<int>> ListList = new List<List<int>>()
            {
                new List<int>(){1, 2, 3, 4, 5},
                new List<int>(){6, 7, 8, 9},
                new List<int>(){10, 11, 12},
                new List<int>(){13, 14}
            };
            foreach (var List in ListList)
            {
                foreach (int i in List)
                {
                    Console.Write($"{i.ToString()} ");
                }
                Console.WriteLine();
            }
        }
    }
}
