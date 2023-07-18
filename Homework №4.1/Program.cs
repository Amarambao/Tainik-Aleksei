using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__4._1
{
    internal class Program
    {
        public delegate string StringMethod1 (string str);


        static void Main(string[] args)
        {
            //string OriginalString = Console.ReadLine();
            string OriginalString = "qqwweerrttyyuuiioopp   {{::''||<<>>??}}   aaAAssSSddDDffFFggGGhhHHjjJJkkKKllLL   [[;;..//'']]   ZZZXXXCCCVVVBBBNNNMMM";
            
            string RemoveSymbols(string str)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < str.Length; i++)
                {
                    char c = str[i];
                    int code = (int)c;
                    if ((code <= 'Z' && code >= 'A') || (code <= 'z' && code >= 'a'))
                    {
                        sb.Append(c);
                    }
                }
                return sb.ToString();
            }
            
            string AddSymbols(string str)
            {
                StringBuilder sb = new StringBuilder(str);
                string str1 = Console.ReadLine();
                sb.Append(str1);
                return sb.ToString();
            }
            
            string RemoveDuplicateSymbols(string str)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < str.Length - 1; i++)
                {
                    if (i == str.Length - 1)
                    {
                        sb.Append(str[i]);
                    }
                    else if (str[i] != str[i + 1])
                    {
                        sb.Append(str[i]);
                    }
                }
                return sb.ToString();
            }
            
            string StringToUpper(string str)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < str.Length; i++)
                {
                    char c = str[i];
                    int code = (int)c;
                    if (code <= 'z' && code >= 'a')
                    {
                        sb.Append(char.ToUpper(c));
                    }
                    else
                    {
                        sb.Append(c);
                    }
                }
                return sb.ToString();
            }

            string StringReverse(string str)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    char c = str[i];
                    sb.Append(c);
                }
                return sb.ToString();
            }

            string ModifiedString1 = StringReverse(RemoveDuplicateSymbols(StringToUpper(RemoveSymbols(OriginalString))));
            Console.WriteLine(ModifiedString1);

            string Instruction1(StringMethod1 param1, StringMethod1 param2, StringMethod1 param3, StringMethod1 param4, StringMethod1 param5, string str)
            {
                string result1 = param1.Invoke(str);
                string result2 = param2.Invoke(result1);
                string result3 = param3.Invoke(result2);
                string result4 = param4.Invoke(result3);
                string result5 = param5.Invoke(result4);
                return result5;
            }

            //string ModifiedString2 = Instruction1(AddSymbols, StringToUpper, RemoveDuplicateSymbols, RemoveSymbols, StringReverse, OriginalString);
            //Console.WriteLine(ModifiedString2);

            //Action<string> RemoveSpaces = delegate (string str)
            //{
            //    for (int i = 0; i < str.Length; i++)
            //    {
            //        if (str[i] == ' ')
            //        {
            //            str[i] = '.';
            //        }
            //    }
            //};

            Predicate<string> LongerThan21 = delegate (string str)
                {
                      return str.Length > 21;
                };

            Func <string, string> AddOrRemove = delegate (string str)
            {
                if (LongerThan21(str) == true)
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < str.Length; i++)
                    {
                        char c = str[i];
                        sb.Append(c);
                    }
                    return sb.ToString();
                } 
                else
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < str.Length; i++)
                    {
                        char c = str[i];
                        sb.Append(c);
                    }
                    while (sb.Length < 21)
                    {
                        int j = str.Length - 1;
                        sb.Append('A');
                        j++;
                    }
                    return sb.ToString();
                }
            };
            string StrLengthLess21 = "qaz   wsx";
            Console.WriteLine(AddOrRemove(StrLengthLess21));
<<<<<<< HEAD
            //RemoveSpaces(StrLengthLess21);
=======
            RemoveSpaces(StrLengthLess21);
>>>>>>> origin/main
            Console.WriteLine(StrLengthLess21);
        }
    }
}
