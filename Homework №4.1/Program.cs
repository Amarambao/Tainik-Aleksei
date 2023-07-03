using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FromConsole = Console.ReadLine();

            string RemoveSymbols(string str)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < str.Length; i++)
                {
                    char c = str[i];
                    int code = (int)c;
                    if (code <= 0x5a && code >= 0x41)
                    {
                        sb.Append(c);
                    }
                    if (code <= 0x7a && code >= 0x61)
                    {
                        sb.Append(c);
                    }
                }
                return sb.ToString();
            }

            string AddSymbols(string str)
            {
                StringBuilder sb = new StringBuilder();
                string str1 = Console.ReadLine();
                return str += str1;
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

            void instuct(StringMethod1 parameter1, string str2)
            {
                parameter1.Invoke(str2);
            }

            public delegate string StringMethod1(string str);
        }
    }
}
