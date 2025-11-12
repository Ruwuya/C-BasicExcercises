using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise61_62
{
    public class Exercise62
    {
        // Reverse Strings in Parentheses
        // Example:
        // Input: "p(rq)st"
        // Output: "prqst"
        public static void ReverseStringsInParentheses()
        {
            string input = "p(rq)st";
            Console.WriteLine("Original String: " + input);

            // Stack to hold the positions of opening parentheses
            Stack<int> stack = new Stack<int>();
            char[] charArray = input.ToCharArray();

            // Iterate through the character array
            for (int i = 0; i < charArray.Length; i++)
            {
                // If we find an opening parenthesis, push its index onto the stack
                if (charArray[i] == '(')
                {
                    stack.Push(i);
                }
                // If we find a closing parenthesis, pop the last opening parenthesis index and reverse the substring
                else if (charArray[i] == ')')
                {
                    int start = stack.Pop();
                    Array.Reverse(charArray, start + 1, i - start - 1);
                }
            }
            // Build the result string without parentheses
            string result = new string(charArray).Replace("(", "").Replace(")", "");
            Console.WriteLine("Reversed String: " + result);
        }

    }
}
