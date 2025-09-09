using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_practice
{
    internal class SI
    {
        float p, r, t, si;

        internal void CalcSI()
        {
            p = 12000;
            r = 2.5F;
            t = 4.5F;
            si = (p * r * t) / 100;
            Console.WriteLine("Result is {0}", si);


        }


    }
}