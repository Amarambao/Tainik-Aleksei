using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] S1 = Console.ReadLine().Split(); //ввод массива из консоли
            int N, M;
            N = Convert.ToInt32(S1[0]);
            M = Convert.ToInt32(S1[1]);
            int[,] A = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                string[] S2 = Console.ReadLine().Split(); 
                    for (int j = 0; j < M; j++)
                    {
                        A[i, j] = Convert.ToInt32(S2[j]);
                    }
            }
            for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        Console.Write(A[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            */
            int[,] B = new int[,] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 } }; 
            for (int i = 0; i <= B.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= B.GetUpperBound(1); j++)
                {
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine();
            }
            
            int[] C1 = new int[] { 1, 2, 3, 4, 5 }; //сравнение массивов
            int[] C2 = new int[] { 1, 2, 3, 4, 5 };
            bool C3 = (C1 == C2) ? true : false;
            Console.WriteLine(C3);
            
            /*
            string[] S3 = Console.ReadLine().Split(); // массив строк
            Console.WriteLine(S3.Length);
            foreach (string s in S3)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            Console.Write("Выберете элемент который хотите изменить: "); 
            int x = int.Parse(Console.ReadLine());
            Console.Write("Напишите на что хотите изменить: "); 
            string y = Console.ReadLine();
            S3[x] = y;
            foreach (string s in S3)
            {
                Console.WriteLine(s + " ");
            }
            Console.WriteLine(); 
            */
            
            /*
            string[] S4 = Console.ReadLine().Split();
            int[][] Array = new int[int.Parse(S4[0])][];
            Array[0] = new int[int.Parse(S4[1])];
            Array[1] = new int[int.Parse(S4[2])];
            Array[2] = new int[int.Parse(S4[3])];
            */
            int[][] Array = new int[3][];
            Array[0] = new int[2];
            Array[1] = new int[3];
            Array[2] = new int[4];
            for (int i = 0; i < Array.Length; i++) //ввод массива из консоли
            {
                for (int j = 0; j < Array[i].Length; j++)
                {
                    Array[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            for (int i = 0; i < Array.Length; i++) //вывод
            {
                for (int j = 0; j < Array[i].Length; j++)
                {
                    Console.Write(Array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
