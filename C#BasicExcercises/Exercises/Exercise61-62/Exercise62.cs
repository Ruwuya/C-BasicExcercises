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
            Stack<int> stack = new Stack<int>();
            char[] charArray = input.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == '(')
                {
                    stack.Push(i);
                }
                else if (charArray[i] == ')')
                {
                    int start = stack.Pop();
                    Array.Reverse(charArray, start + 1, i - start - 1);
                }
            }
            string result = new string(charArray).Replace("(", "").Replace(")", "");
            Console.WriteLine("Reversed String: " + result);
        }

    }
}
