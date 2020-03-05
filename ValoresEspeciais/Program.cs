using System;
using System.Text;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = short.MaxValue;
            Console.WriteLine((short)(i+1));
            double x = 2 * double.MaxValue;
            float f1, f2;
            f1 = f2 = 10000.0f;
            Console.WriteLine(f1 == f2 + 0.0001f);
            Console.OutputEncoding=Encoding.UTF8;
            Console.WriteLine(x);
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(double.PositiveInfinity);
            Console.WriteLine(double.NegativeInfinity);
        }
    }
}
