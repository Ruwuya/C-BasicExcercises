using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise11_20
{
    public class Exercise13
    {
        // Rectangle pattern with number
        // expected output for input 5:
        // 555
        // 5 5
        // 5 5
        // 555
        public static void RectanglePatternWithNumber()
        {
            Console.WriteLine("Rectangle Pattern with Number Exercise");
            Console.WriteLine("Please enter a number:");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    if (i == 1 || i == 4 || j == 1 || j == 3)
                    {
                        Console.Write(number);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
