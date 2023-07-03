using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework__3._3e
{
    internal class Program
    {
        enum Months { January,    February,  March,     April, 
                      May,        June,      July,      August, 
                      September,  October,   November,  December }
        static void Main(string[] args)
        {
            foreach (var m in Enum.GetNames(typeof(Months)))
            {
                Console.Write($"{m} ");
            }
            Console.WriteLine();

            //int MonthsLength = Convert.ToInt32(Console.ReadLine());
            int MonthsLength = 7;
            var SelectedMonths1 = Enum.GetNames(typeof(Months)).Where(Month =>
            {
                return Month.Length == MonthsLength;
            });
            foreach (var m in SelectedMonths1)
            {
                Console.Write($"{m} ");
            }
            Console.WriteLine();

            var SelectedMonths2 = Enum.GetNames(typeof(Months)).Where(Month =>
            {
                return Month == "January" || Month == "February" || Month == "June" ||
                       Month == "July" || Month == "August" || Month == "December";
            });
            foreach (var m in SelectedMonths2)
            {
                Console.Write($"{m} ");
            }
            Console.WriteLine();
        }
    }
}
