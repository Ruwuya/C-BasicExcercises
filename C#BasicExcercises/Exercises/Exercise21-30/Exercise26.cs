using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise21_30
{
    public class Exercise26
    {
        // Sum of first 500 primes
        // Expected result: 82 4693
        public static void SumOfFirst500Primes()
        {
            Console.WriteLine("Sum of the first 500 primes: ");

            int sum = 0;
            int count = 0;
            int number = 2; // The first prime number

            // Loop until we find 500 prime numbers
            while (count < 500)
            {
                if (IsPrime(number))
                {
                    sum += number;
                    count++;
                }
                number++;
            }
            Console.WriteLine(sum);
        }

        // Function to check if a number is prime
        private static bool IsPrime(int number)
        {
            int x = (int)Math.Sqrt(number);

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= x; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
