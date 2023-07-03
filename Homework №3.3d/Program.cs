using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__3._3d
{
    internal class Program
    {
        sealed class Month
        {
            public string Name { get; set; }
            public int Number { get; set; }
            public Month(int number, string name)
            {
                Number = number;
                Name = name;
            }
        }
        static void Main(string[] args)
        {
            List<Month> Months = new List<Month>();
            /* пытался сделать циклом
            string[] Names = { "January",   "February",  "March", 
                                "April",    "May",       "June", 
                                "July",     "August",    "September", 
                                "October",  "November",  "December" };
            foreach (string name in Names)
            {
                int i = 1;
                Month I = new Month(i, name);
                i++;
            } 
            for (int i = 1; i <= 12; i++)
            {
                Month Names[i-1] = new Month(i, Console.ReadLine());
            }
            */
            Month Jan = new Month (1, "January");       Month Febr = new Month (2, "February");
            Month Mrch = new Month (3, "March");        Month Apr = new Month (4, "April");
            Month May = new Month (5, "May");           Month Jun = new Month (6, "June");
            Month Jul = new Month (7, "July");          Month Aug = new Month (8, "August");
            Month Septr = new Month (9, "September");   Month Octr = new Month (10, "October");
            Month Nvmr = new Month (11, "November");    Month Dcmbr = new Month (12, "December");
            
            Months.Add (Jan);    Months.Add (Febr);     Months.Add (Mrch);  Months.Add(Apr); 
            Months.Add (May);    Months.Add (Jun);      Months.Add (Jul);   Months.Add (Aug); 
            Months.Add (Septr);  Months.Add (Octr);     Months.Add (Nvmr);  Months.Add (Dcmbr);

            foreach (Month month in Months)
            {
                Console.Write($"{month.Number} {month.Name} ");
            }
            Console.WriteLine();

            //int MonthsLength = Convert.ToInt32(Console.ReadLine());
            int MonthsLength = 7;
            var SelectedMonths1 = Months.Where(Month =>
            {
                return Month.Name.Length == MonthsLength;
            });

            foreach (Month m in SelectedMonths1)
            {
                Console.Write($"{m.Number} {m.Name} ");
            }
            Console.WriteLine();

            /*
            var SelectedMonths2 = Months.Where(Month =>
            {
                return Month.Name == "January" || Month.Name == "February" || Month.Name == "June" ||
                       Month.Name == "July" || Month.Name == "August" || Month.Name == "December";
            });
            */
            var SelectedMonths2 = Months.Where(Month =>
            {
                return Month.Number == 1 || Month.Number == 2 || Month.Number == 6 ||
                       Month.Number == 7 || Month.Number == 8 || Month.Number == 12;
            });
            foreach (Month m in SelectedMonths2)
            {
                Console.WriteLine($"{m.Number} {m.Name} ");
            }
            Console.WriteLine();

            var SelectedMonths3 = Months.OrderByDescending(Month => Month.Number);
            foreach (Month m in SelectedMonths3)
            {
                Console.WriteLine($"{m.Number} {m.Name} ");
            }
            Console.WriteLine();

            var SelectedMonths4 = Months.Where(Month =>
            {
                return Month.Name.Contains('u') && Month.Name.Length >= 4;
            });
            foreach (Month m in SelectedMonths4)
            {
                Console.WriteLine($"{m.Number} {m.Name} ");
            }
            Console.WriteLine();

            var SelectedMonths5 = Months.Where(Month =>
            {
                return Month.Name.Contains('r');
            })
                .OrderBy(month => month.Number)
                .GroupBy(month => month.Name.Length);

            var SelectedMonths6 = SelectedMonths5.Count();

            var SelectedMonths7 = SelectedMonths5.Any(MonthGroup =>
            {
                return MonthGroup.Count() >= 3;
            });

            foreach (var m in SelectedMonths5)
            {
                Console.WriteLine(m.Key);
                foreach (var n in m)
                {
                    Console.WriteLine($"{n.Number} {n.Name} ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("Всего групп в запросе - " + SelectedMonths6);
            Console.WriteLine("Есть группы с количеством элементов >= 3 - " + SelectedMonths7);
        }
    }
}
