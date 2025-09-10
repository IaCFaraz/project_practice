using System;

namespace project_practice
{
    internal class Check
    {
        static void Main(string[] args)
        {
            int num = 100;
            string result = "ODD";

            if (num % 2 == 0)
            {
                result = "EVEN";
            }

            Console.WriteLine(result);
        }
    }
}
