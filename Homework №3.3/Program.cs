using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Months = { 
                                "January", "February", "March", 
                                "April", "May", "June", 
                                "July", "August", "September",
                                "October", "November", "December"
                              };

            //int[] MonthsNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            string[] MonthsNumbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };

            //последовательность месяцев с длиной строки равной n
            int MonthsLength = Convert.ToInt32(Console.ReadLine());

            var SelectedMonths1 = from m in Months
                                 where m.Length == MonthsLength 
                                 select m;

            foreach (var m in SelectedMonths1)
            {
                Console.Write($"{m} ");
            }
            Console.WriteLine();

            //летние и зимние месяцы
            var SelectedMonths2 = Months.Where(Month =>
            {
                return Month == "January" || Month == "February" || Month == "June" || 
                       Month == "July" || Month == "August" || Month == "December";
            });

            foreach (var m in SelectedMonths2)
            {
                Console.Write($"{m} ");
            }
            Console.WriteLine();

            // алфавитный порядок
            var SelectedMonths3 = Months.OrderBy(Month => Month);

            foreach (var m in SelectedMonths3)
            {
                Console.Write($"{m} ");
            }
            Console.WriteLine();

            //символ «u» и длина имени не менее 4-х
            var SelectedMonths4 = from m in Months
                                  where m.Length >= 4 && m.Contains('u')
                                  select m;
            
            foreach (var m in SelectedMonths4)
            {
                Console.Write($"{m} ");
            }
            Console.WriteLine();

            // 5 запросов
            var SelectedMonths5 = Months.Where(Month =>
            {
                return Month.Contains('r');
            })
                .OrderBy(month => month)
                .GroupBy(month => month.Length);

            var SelectedMonths6 = SelectedMonths5.Count();

            var SelectedMonths7 = SelectedMonths5.Any(MonthGroup =>
            {
                return MonthGroup.Count() >= 3;
            });

            foreach (var m in SelectedMonths5)
            {
                Console.Write(m.Key + " ");
                foreach (var n in m)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Всего групп в запросе - " + SelectedMonths6);
            Console.WriteLine("Есть группы с количеством элементов >= 3 - " + SelectedMonths7);

            // я не понимаю почему это не работает если MonthsNumbers - int
            /* var JoinMonths = Months.Join(MonthsNumbers,
                                         Month => Month.Length >= 1,
                                         MonthsNumber => MonthsNumber.Length > 1,
                                         (m1, m2) => m1 + " " + m2
                                         );
            foreach (var m in JoinMonths)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine();
            */
        }
    }
}
