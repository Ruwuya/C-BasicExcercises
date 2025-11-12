using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise51_60
{
    public class Exercise56
    {
        // Check Palindrome String
        // Example:
        // input: 'aaaa' => output: true
        // input: 'abc'  => output: false
        public static void CheckPalindromeString()
        {
            // Test cases
            string input1 = "aaaa";
            string input2 = "abc";

            // Check and display results
            bool isPalindrome1 = IsPalindrome(input1);
            bool isPalindrome2 = IsPalindrome(input2);

            // Output results
            Console.WriteLine($"Input: '{input1}' => Output: {isPalindrome1}");
            Console.WriteLine($"Input: '{input2}' => Output: {isPalindrome2}");
        }

        private static bool IsPalindrome(string input1)
        {
            // Two-pointer technique to check for palindrome
            int left = 0;
            int right = input1.Length - 1;

            // Compare characters from both ends
            while (left < right)
            {
                // If characters do not match, it's not a palindrome
                if (input1[left] != input1[right])
                {
                    return false;
                }
                // Move towards the center
                left++;
                right--;
            }
            return true;
        }
    }
}
