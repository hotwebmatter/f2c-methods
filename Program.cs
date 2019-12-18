using System;
using static System.Console;

namespace f2c_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");
        }

        static double f2c(double f)
        {
            return 5 * (f - 32) / 9;
        }

    }
}
