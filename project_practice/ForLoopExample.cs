using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_practice
{
    internal class ForLoopExample
    {
        static void Main(string[] args)    
        {
            int num = 10;
            int r = 1;
            for (int step = num; step > 1; step--)
            {
                r = r * step;
            }
            Console.WriteLine("fatorail is " +r);


            // calculate the Table
            //int num = 12;
            //for(int step =1; step <=10; step++)
            //{
            //    Console.WriteLine(num * step);
            //}

                // simple for loop 
                //Console.WriteLine("For Loop step Increment");
                //for (int step = 1; step <= 10; step++)
                //{
                //    Console.WriteLine("step is " + step);
                //}
                //Console.WriteLine("For Loop step decrement");
                //for (int step =10; step >= 1; step--)
                //{
                //   Console.WriteLine( "step is " +step);
                //}



        }
    }
}
