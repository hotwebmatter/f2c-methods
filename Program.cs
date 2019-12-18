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
            WriteLine(DisplayResults(tempFahrenheit, tempCelsius));
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
        static string DisplayResults(double f, double c)
        {
            string result = String.Format("{0}\n", "****** Temperature Table ******");
            result += String.Format("{0, 14} {1, 12:N2}\n", "Fahrenheit:", f);
            result += String.Format("{0, 14} {1, 12:N2}\n", "Celsius:", c);
            result += String.Format("{0}", "*******************************");
            return result;
        }
    }
}
