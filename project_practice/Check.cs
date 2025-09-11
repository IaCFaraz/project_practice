using System;
using System.Diagnostics.Eventing.Reader;

namespace project_practice
{
    internal class Check
    {
        static void Main(string[] args)
        {
            int a = 100, b = 20, c = 30;
            if (a > b)
            {
                if (a > c )
                {
                    Console.WriteLine("a is greates");
                }
                else
                {
                    Console.WriteLine("c is greates");
                }


            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("b is greates");
                }
                else
                {
                    Console.WriteLine("c is greates");
                }
            }

           
        }
        
        
        
        
    }
   

}
