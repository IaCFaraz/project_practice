using System;

namespace project_practice
{
    internal class Datatype
    {
        public void DDatatypeFun()
        {
            Int16 a = 1;
            Byte b = 2;
            Double d = 2.5;    // fixed
            Boolean c1 = true;
            Char ch = 'a';
            String s = "hello";
            object o = 12;

            Console.WriteLine("a={0}, b={1}, c={2}, d={3}, ch={4}, s={5}",
                               a, b, c1, d, ch, s);
        }
    }
}
