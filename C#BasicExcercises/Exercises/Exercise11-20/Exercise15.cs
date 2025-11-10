using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise11_20
{
    public class Exercise15
    {
        // Remove character by index
        public static void RemoveCharacterByIndex()
        {
            // example output: "abcd", 2 => "abd"
            Console.WriteLine("Remove Character by Index Exercise");
            Console.WriteLine("Please enter a string:");
            string inputString = Console.ReadLine();
            Console.WriteLine("Please enter the index of the character to remove:");
            int index = int.Parse(Console.ReadLine());
            if (index < 0 || index >= inputString.Length)
            {
                Console.WriteLine("Index is out of range.");
            }
            else
            {
                string resultString = inputString.Remove(index, 1);
                Console.WriteLine("String after removing character: " + resultString);
            }
        }
    }
}
