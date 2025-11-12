using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise11_20
{
    public class Exercise14
    {
        // Convert celsius to fahrenheit
        public static void CelciusToFahrenheitConversion()
        {
            // Formula: (C × 1.8) + 32 = F
            Console.WriteLine("Convert Celsius to Fahrenheit Exercise");
            Console.WriteLine("Please enter temperature in Celsius:");
            double celsius = double.Parse(Console.ReadLine());
            // Conversion
            double fahrenheit = (celsius * 1.8) + 32;
            Console.WriteLine($"{celsius} degree Celsius is equal to {fahrenheit} degree Fahrenheit.");
        }
    }
}
