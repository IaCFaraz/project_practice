using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_practice
{
    internal class SumDateDigit
    {
        // Write a C# program to calculate the sum of the digits of a given date (in the format YYYYMMDD).
        // Using a loop to extract each digit from the date string and add them together.
        static void Mian(string[] args)
        {
            string date1 = "20231005";

            int d1 = Convert.ToInt32(date1);
            int sum = 0;
            while (d1 > 0)
            {
                int first = d1 % 10;
                d1 = (int)(d1 / 10); ;
                sum += first;
                Console.WriteLine(sum);
            }
            
        }




        // Another approach without using a loop


        //static void Main(string[] args)
        //{
        //    string date1 = "20231005";
        //    int d1 = Convert.ToInt32(date1);
        //    int first =d1 % 10;
        //    d1 = (int)(d1 / 10);
        //    int second = d1 % 10;
        //    d1 = (int)(d1 / 10);
        //    int third = d1 % 10;
        //    d1 = (int)(d1 / 10);
        //    int fourth = d1 % 10;
        //    d1 = (int)(d1 / 10);
        //    int fifth = d1 % 10;
        //    d1 = (int)(d1 / 10);
        //    int sixth = d1 % 10;
        //    d1 = (int)(d1 / 10);
        //    int seventh = d1 % 10;
        //    d1 = (int)(d1 / 10);
        //    int eighth = d1 % 10;
        //    d1 = (int)(d1 / 10); 
        //    Console.WriteLine(first + second + third + fourth + fifth + sixth + seventh + eighth);
        //}
    }
}
