using C_BasicExcercises.Exercises;
using C_BasicExcercises.Exercises.Exercise_11_20;
using C_BasicExcercises.Exercises.Exercise11_20;
using C_BasicExcercises.Exercises.Exercise21_30;

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



                default:
                    Console.WriteLine("Invalid choice");
                    Console.ReadKey();
                    break;
            }

        }
    }
}
