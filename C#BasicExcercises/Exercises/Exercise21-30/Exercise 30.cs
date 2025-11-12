using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise21_30
{
    public class Exercise_30
    {
        // Hexadecimal to Decimal Conversion
        // Example: "4B0" => 1200

        public static void HexadecimalToDecimalConversion()
        {
            Console.WriteLine("Hexadecimal to Decimal Conversion: ");
            Console.Write("Input a hexadecimal number: ");
            string hexInput = Console.ReadLine();
            // Convert hex to decimal
            try
            {
                // Converting hexadecimal to decimal then printing the result
                int decimalValue = Convert.ToInt32(hexInput, 16);
                Console.WriteLine($"The decimal value is: {decimalValue}");
            }
            // Handling invalid hexadecimal input
            catch (FormatException)
            {
                Console.WriteLine("Invalid hexadecimal number.");
            }
        }
    }
}
