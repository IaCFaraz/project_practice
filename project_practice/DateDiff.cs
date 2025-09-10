using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_practice
{
    internal class DateDiff
    {
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime(2023, 6, 1);
            DateTime dt2 = new DateTime(2024, 6, 1);
            TimeSpan ts = dt2 - dt1;
            Console.WriteLine("Difference in days: " + ts.TotalDays);
            Console.WriteLine("Difference in hours: " + ts.TotalHours);
            Console.WriteLine("Difference in minutes: " + ts.TotalMinutes);
            Console.WriteLine("Difference in seconds: " + ts.TotalSeconds);
        }
    }
}
