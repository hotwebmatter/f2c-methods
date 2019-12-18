using System;
using static System.Console;

namespace f2c_methods
{
    class Program
    {
        // no class-level static variables this time
        static void Main(string[] args)
        {
            // initialize variables in Main()
            double tempFahrenheit,
                   tempCelsius;
            tempFahrenheit = ReadDouble("Enter temperature in degrees Fahrenheit:");
            tempCelsius = f2c(tempFahrenheit);
            WriteLine("Hello World!");
        }

        static double f2c(double f)
        {
            return 5 * (f - 32) / 9;
        }
        static double ReadDouble(string label)
        {
            Write("{0} ", label);
            double number;
            string userInput = ReadLine();
            while (Double.TryParse(userInput, out number) == false)
            {
                Write("{0} {1} ", "Invalid input!", label);
                userInput = ReadLine();
            }
            return number;
        }
    }
}
