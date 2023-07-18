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
            
            string RemoveDuplicateSymbols(string str) // съедает последнюю букву
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

            //string OriginalString = Console.ReadLine();
            string OriginalString = "qqwweerrttyyuuiioopp   {{::''||<<>>??}}   aaAAssSSddDDffFFggGGhhHHjjJJkkKKllLL   [[;;..//'']]   ZZZXXXCCCVVVBBBNNNMMM";

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

<<<<<<< HEAD
            string Instruction2(StringMethod1 param1, StringMethod1 param2, StringMethod1 param3, StringMethod1 param4, string str)
            {
                string result1 = param1.Invoke(str);
                string result2 = param2.Invoke(result1);
                string result3 = param3.Invoke(result2);
                string result4 = param4.Invoke(result3);
                return result4;
            }

            //string ModifiedString2 = Instruction1(AddSymbols, StringToUpper, RemoveDuplicateSymbols, RemoveSymbols, StringReverse, OriginalString);
            //Console.WriteLine(ModifiedString2);

            string ModifiedString3 = Instruction2(AddSymbols, StringToUpper, RemoveDuplicateSymbols, StringReverse, OriginalString);
            Console.WriteLine(ModifiedString3);

            Predicate<string> LongerThan21 = delegate (string str)
                {
                      return str.Length > 21;
                };

            Func <string, string> AddOrRemove = delegate (string str)
            {
                if (LongerThan21(str) == true)
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < 21; i++)
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
                        sb.Append('A');
                    }
                    return sb.ToString();
                }
            };

            Action<string> WriteString = delegate (string str)
            {
                Console.WriteLine(LongerThan21(str));
                Console.WriteLine(AddOrRemove(str));
            };

            string StrLengthLess21 = "qazwsx";
            string StrLengthGreater21 = "qwertyuiopasdfghjklzxcvbnm";
            
            WriteString(StrLengthLess21);
            WriteString(StrLengthGreater21);
=======
            
>>>>>>> main
        }
    }
}
