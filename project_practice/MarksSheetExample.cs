using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_practice
{
    internal class MarksSheetExample
    {
        static void Main(string[] args)
        {
            int marks;
            Console.WriteLine("Enter your marks");
            marks = Convert.ToInt32(Console.ReadLine());
            if (marks >= 90 && marks <= 100)
            {
                Console.WriteLine("A+ Grade");
            }
            else if (marks >= 80 && marks < 90)
            {
                Console.WriteLine("A Grade");
            }
            else if (marks >= 70 && marks < 80)
            {
                Console.WriteLine("B+ Grade");
            }
            else if (marks >= 60 && marks < 70)
            {
                Console.WriteLine("B Grade");
            }
            else if (marks >= 50 && marks < 60)
            {
                Console.WriteLine("C Grade");
            }
            else if (marks >= 40 && marks < 50)
            {
                Console.WriteLine("D Grade");
            }
            else if (marks >= 0 && marks < 40)
            {
                Console.WriteLine("Fail");
            }
            else
            {
                Console.WriteLine("Invalid Marks");
            }
        }
    }
}
