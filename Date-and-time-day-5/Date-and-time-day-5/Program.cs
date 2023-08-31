using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_and_time_day_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToString());
            Console.WriteLine(date.ToShortDateString());
            Console.WriteLine(date.ToShortTimeString());
            Console.WriteLine(date.ToLongDateString());
            Console.WriteLine(date.ToLongTimeString());
            Console.WriteLine(date.AddDays(5).ToString());
            Console.WriteLine(date.AddHours(5).ToString());



            DateTime date2 = DateTime.Parse("1997, 3, 18");
            TimeSpan age = DateTime.Now.Subtract(date2);
            Console.WriteLine(age.TotalDays);
            Console.ReadLine();
        }
    }
}
