using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_practice
{
    internal class OperatorDemo

    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 30;
            string result = (a > b) ? "a is greater" : "b is greater";
            Console.WriteLine(result);

        }

        //{
        //    static void Main(string[] args)
        //    {
        //        int a = 10;
        //        int b = a++;   a++;  a++;
        //        Console.WriteLine("a={0} and b={1}" , a++ ,++b);


        //    }
        //}
    }
}   
