using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise21_30
{
    public class Exercise30
    {
        // Hexadecimal to Decimal Conversion
        public static void HexadecimalToDecimal()
        {
            Console.Write("Enter a hexadecimal number: ");
            string hexInput = Console.ReadLine();
            // Convert hexadecimal to decimal
            try
            {
                // Using Convert.ToInt32 to convert from hexadecimal (base 16) to decimal (base 10)
                int decimalValue = Convert.ToInt32(hexInput, 16);
                Console.WriteLine($"The decimal value of hexadecimal {hexInput} is: {decimalValue}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid hexadecimal number format.");
            }
            // Handle cases where the number is too large to fit in an Int32
            catch (OverflowException)
            {
                Console.WriteLine("The hexadecimal number is too large to convert.");
            }
        }
    }
}
