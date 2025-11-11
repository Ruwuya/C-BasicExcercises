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
            string input1 = "aaaa";
            string input2 = "abc";
            bool isPalindrome1 = IsPalindrome(input1);
            bool isPalindrome2 = IsPalindrome(input2);
            Console.WriteLine($"Input: '{input1}' => Output: {isPalindrome1}");
            Console.WriteLine($"Input: '{input2}' => Output: {isPalindrome2}");
        }

        private static bool IsPalindrome(string input1)
        {
            int left = 0;
            int right = input1.Length - 1;
            while (left < right)
            {
                if (input1[left] != input1[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}
