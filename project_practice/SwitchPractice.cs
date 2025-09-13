using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_practice
{
    internal class SwitchPractice
    {
        static void Main(string[] args)
        {
            int num = 5;
            switch (num % 2)
            {
                case 0 :
                    Console.WriteLine("Even");
                    break;
                default:
                    Console.WriteLine("add");
                    break;

            }

        }

    }
}
