using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_practice
{
    internal class ForLoopExample
    {
        static void Main(string[] args)    
        {
            Console.WriteLine("For Loop step Increment");
            for (int step = 1; step <= 10; step++)
            {
                Console.WriteLine("step is " + step);
            }
            Console.WriteLine("For Loop step decrement");
            for (int step =10; step >= 1; step--)
            {
               Console.WriteLine( "step is " +step);
            }
            


        }
    }
}
