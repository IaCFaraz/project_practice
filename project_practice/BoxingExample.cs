using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_practice
{
    internal class BoxingExample
    {
        internal void Boxingfun()
        {
            int a = 20; // value type
            object o; // boxing
            o = a;
            Console.WriteLine(o);

        }
        internal void UnBoxingfun2()
        {
            object o = 30;
            int a = (int)o; // unboxing
            Console.WriteLine(o);
        }


        }
    } 
