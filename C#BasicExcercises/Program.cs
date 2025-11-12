using System.Reflection;

namespace C_BasicExcercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Basic Exercises!");
            Console.WriteLine();

            // Find all exercise methods automatically
            // An exercise method is defined as a public static method
            // in a class whose name starts with "Exercise" ffollowed by a number
            var exerciseMethods = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.IsClass && t.Name.StartsWith("Exercise"))
                .SelectMany(t => t.GetMethods(BindingFlags.Public | BindingFlags.Static))
                .Where(m => m.GetParameters().Length == 0 && m.ReturnType == typeof(void))
                .OrderBy(m => m.DeclaringType!.Name)
                .ToList();

            // Display menu
            for (int i = 0; i < exerciseMethods.Count; i++)
            {
                // Get class and method name from the static methods in "Exercise" classes
                var typeName = exerciseMethods[i].DeclaringType!.Name;
                var methodName = exerciseMethods[i].Name;
                Console.WriteLine($"{i + 1}. {typeName} - {methodName}");
            }

            // Get user input for exercise selection
            Console.WriteLine();
            Console.Write("Enter exercise number: ");
            string? input = Console.ReadLine();

            // Invoke selected exercise method
            if (int.TryParse(input, out int choice) &&
                // Validate choice range based on discovered methods
                choice >= 1 &&
                choice <= exerciseMethods.Count)
            {
                // Clear console before running the exercise
                Console.Clear();
                exerciseMethods[choice - 1].Invoke(null, null);
            }
            // Invalid choice handling
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}
/* Old Program.cs content:
using C_BasicExcercises.Exercises;
using C_BasicExcercises.Exercises.Exercise_11_20;
using C_BasicExcercises.Exercises.Exercise11_20;
using C_BasicExcercises.Exercises.Exercise21_30;
using C_BasicExcercises.Exercises.Exercise31_40;
using C_BasicExcercises.Exercises.Exercise41_50;
using C_BasicExcercises.Exercises.Exercise51_60;
using C_BasicExcercises.Exercises.Exercise61_62;

namespace C_BasicExcercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Basic Exercises!");

            Console.WriteLine("Please select an exercise to run:");
            Console.WriteLine("1.  Exercise 1 - Hello Name");
            Console.WriteLine("2.  Exercise 2 - Sum of Two Numbers");
            Console.WriteLine("2.  Exercise 3 - Divide Two Numbers");
            Console.WriteLine("4.  Exercise 4 - Specified Operations Result");
            Console.WriteLine("5.  Exercise 5 - Swap Two Numbers");
            Console.WriteLine("6.  Exercise 6 - Multiply Three Numbers");
            Console.WriteLine("7.  Exercise 7 - Arithmetic Operations");
            Console.WriteLine("8.  Exercise 8 - Multiplication Table");
            Console.WriteLine("9.  Exercise 9 - Average of Four Numbers");
            Console.WriteLine("10. Exercise 10 - Specified Formular With Three Numbers");
            Console.WriteLine("11. Exercise 11 - Print Age Message");
            Console.WriteLine("12. Exercise 12 - Repeat Numbers In Rows");
            Console.WriteLine("13. Exercise 13 - Rectangle Pattern With Number");
            Console.WriteLine("14. Exercise 14 - Celcius to Fahrenheit Conversion");
            Console.WriteLine("15. Exercise 15 - Remove Character By Index");
            Console.WriteLine("16. Exercise 16 - Swap First And Last Charcater");
            Console.WriteLine("17. Exercise 17 - Add First Character To Front And Back");
            Console.WriteLine("18. Exercise 18 - Check Positive And Negative Pair");
            Console.WriteLine("19. Exercise 19 - Sum Or Triple Sum of Intergers");
            Console.WriteLine("20. Exercise 20 - Absolute Difference Or Double It");
            Console.WriteLine("21. Exercise 21 - Check For 20 Or Sum Equal To 20");
            Console.WriteLine("22. Exercise 22 - Check Within 20 of 100 or 200");
            Console.WriteLine("23. Exercise 23 - Convert String to Lowercase");
            Console.WriteLine("24. Exercise 24 - Find Longest Word in String");
            Console.WriteLine("25. Exercise 25 - Print Odd Numbers 1 - 99");
            Console.WriteLine("26. Exercise 26 - Sum of First 500 Primes");
            Console.WriteLine("27. Exercise 27 - Sum of Digits in an Integer");
            Console.WriteLine("28. Exercise 28 - Reverse Words in a String");
            Console.WriteLine("29. Exercise 29 - File Size in Bytes");
            Console.WriteLine("30. Exercise 30 - Hexadecimal to Decimal");
            Console.WriteLine("31. Exercise 31 - Multiply Two Arrays");
            Console.WriteLine("32. Exercise 32 - Four Copies of Last Four Characters");
            Console.WriteLine("33. Exercise 33 - Check Multiple of 3 or 7");
            Console.WriteLine("34. Exercise 34 - Check String Starts with Word");
            Console.WriteLine("35. Exercise 35 - Check Numbers Less than 100 & Greater than 200");
            Console.WriteLine("36. Exercise 36 - Check Integer in Range -10 to 10");
            Console.WriteLine("37. Exercise 37 - Remove 'HP' from String");
            Console.WriteLine("38. Exercise 38 - Extract 'PH' from String");
            Console.WriteLine("39. Exercise 39 - Largest and Lowest of Three Integers");
            Console.WriteLine("40. Exercise 40 - Nearest to 20 or Return 0");
            Console.WriteLine("41. Exercise 41 - Check 'W' Appears 1-3 times");
            Console.WriteLine("42. Exercise 42 - First 4 Chars Lowercase, rest Uppercase");
            Console.WriteLine("43. Exercise 43 - Check String Starts with 'www.'");
            Console.WriteLine("44. Exercise 44 - Every Other Character in String");
            Console.WriteLine("45. Exercise 45 - Count Specific Number in Array");
            Console.WriteLine("46. Exercise 46 - Check Number First or Last in Array");
            Console.WriteLine("47. Exercise 47 - Sum of Array Element");
            Console.WriteLine("48. Exercise 48 - First and Last Element Equal in Array");
            Console.WriteLine("49. Exercise 49 - First or Last Element Equal in Two Arrays");
            Console.WriteLine("50. Exercise 50 - Rotate Array Left");
            Console.WriteLine("51. Exercise 51 - Max of First and Last in Array");
            Console.WriteLine("52. Exercise 52 - Middle Element of Array");
            Console.WriteLine("53. Exercise 53 - Check Odd Number in Array");
            Console.WriteLine("54. Exercise 54 - Find Century of Year");
            Console.WriteLine("55. Exercise 55 - Max Product of Adjacent Elements in Array");
            Console.WriteLine("56. Exercise 56 - Check Palindrome String");
            Console.WriteLine("57. Exercise 57 - Max Product of Adjacent Integers in Array");
            Console.WriteLine("58. Exercise 58 - Complete Missing Numbers in Range");
            Console.WriteLine("59. Exercise 59 - Can Make Strictly Increasing Sequence");
            Console.WriteLine("60. Exercise 60 - Sum of Matrix with Zero Condition");
            Console.WriteLine("61. Exercise 61 - Sort Integers Keeping -5 Fixed");
            Console.WriteLine("62. Exercise 62 - Reverse Strings in Parentheses");


            string? input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Exercise01.HelloName();
                    break;
                case "2":
                    Exercise02.SumOfTwoNumbers();
                    break;
                case "3":
                    Exercise03.DivideTwoNumbers();
                    break;
                case "4":
                    Exercise04.SpecifiedOperationsResult();
                    break;
                case "5":
                    Exercise05.SwapTwoNumbers();
                    break;
                case "6":
                    Exercise06.MultiplyThreeNumbers();
                    break;
                case "7":
                    Exercise07.ArithmeticOperations();
                    break;
                case "8":
                    Exercise08.MultiplicationTable();
                    break;
                case "9":
                    Exercise09.AverageOfFourNumbers();
                    break;
                case "10":
                    Exercise10.SpecifiedFormularWithThreeNumbers();
                    break;
                case "11":
                    Exercise11.PrintAgeMessage();
                    break;
                case "12":
                    Exercise12.RepeatNumbersInRows();
                    break;
                case "13":
                    Exercise13.RectanglePatternWithNumber();
                    break;
                case "14":
                    Exercise14.CelciusToFahrenheitConversion();
                    break;
                case "15":
                    Exercise15.RemoveCharacterByIndex();
                    break;
                case "16":
                    Exercise16.SwapFirstAndLastCharcater();
                    break;
                case "17":
                    Exercise17.AddFirstCharacterToFrontAndBack();
                    break;
                case "18":
                    Exercise18.CheckPositiveAndNegativePair();
                    break;
                case "19":
                    Exercise19.SumOrTripleSumOfIntegers();
                    break;
                case "20":
                    Exercise20.AbsoluteDifferenceOrDoubleIt();
                    break;
                case "21":
                    Exercise21.CheckFor20OrSumEqualTo20();
                    break;
                case "22":
                    Exercise22.CheckWithin20Of100Or200();
                    break;
                case "23":
                    Exercise23.ConvertToLowercase();
                    break;
                case "24":
                    Exercise24.FindLongestWord();
                    break;
                case "25":
                    Exercise25.PrintOddNumbers();
                    break;
                case "26":
                    Exercise26.SumOfFirst500Primes();
                    break;
                case "27":
                    Exercise27.SumOfDigitsInt();
                    break;
                case "28":
                    Exercise28.ReverseWordsInString();
                    break;
                case "29":
                    Exercise29.FileSizeInBytes();
                    break;
                case "30":
                    Exercise30.HexadecimalToDecimal();
                    break;
                case "31":
                    Exercise31.MultiplyTwoArrays();
                    break;
                case "32":
                    Exercise32.FourCopiesOfLastFourCharacters();
                    break;
                case "33":
                    Exercise33.CheckMultipleOf3Or7();
                    break;
                case "34":
                    Exercise34.CheckStringStartsWithWord();
                    break;
                case "35":
                    Exercise35.CheckNumbersLessThan100AndGreaterThan200();
                    break;
                case "36":
                    Exercise36.CheckIntegerInRangeMinus10To10();
                    break;
                case "37":
                    Exercise37.RemoveHPFromString();
                    break;
                case "38":
                    Exercise38.ExtractPHFromString();
                    break;
                case "39":
                    Exercise39.FindLargestAndLowestFromThreeNumbers();
                    break;
                case "40":
                    Exercise40.CheckNearestValueOf20();
                    break;
                case "41":
                    Exercise41.CheckWAppears1To3Times();
                    break;
                case "42":
                    Exercise42.First4CharsLowercaseLastUppercase();
                    break;
                case "43":
                    Exercise43.CheckStringStartsWithWWW();
                    break;
                case "44":
                    Exercise44.PrintEveryOtherCharacterFromString();
                    break;
                case "45":
                    Exercise45.CountSpecificNumberInArray();
                    break;
                case "46":
                    Exercise46.CheckNumberFirstOrLastInArray();
                    break;
                case "47":
                    Exercise47.SumOfArrayElement();
                    break;
                case "48":
                    Exercise48.FirstAndLastElementEqualInArray();
                    break;
                case "49":
                    Exercise49.FirstOrLastElementEqualInTwoArrays();
                    break;
                case "50":
                    Exercise50.RotateArrayLeft();
                    break;
                case "51":
                    Exercise51.MaxOfFirstAndLastInArray();
                    break;
                case "52":
                    Exercise52.MiddleElementOfArray();
                    break;
                case "53":
                    Exercise53.CheckOddNumberInArray();
                    break;
                case "54":
                    Exercise54.FindCenturyOfYear();
                    break;
                case "55":
                    Exercise55.MaxProductOfAdjacentElements();
                    break;
                case "56":
                    Exercise56.CheckPalindromeString();
                    break;
                case "57":
                    Exercise57.MaxProductOfAdjacentIntegers();
                    break;
                case "58":
                    Exercise58.CompleteMissingNumbersInRange();
                    break;
                case "59":
                    Exercise59.CanMakeStrictlyIncreasingSequence();
                    break;
                case "60":
                    Exercise60.SumOfMatrixWithZeroCondition();
                    break;
                case "61":
                    Exercise61.SortIntegersKeepingFixed();
                    break;
                case "62":
                    Exercise62.ReverseStringsInParentheses();
                    break;
                default:
                    Console.WriteLine("Invalid choice, please pick between 1 - 62");
                    Console.ReadKey();
                    break;
            }

        }
    }
}
*/