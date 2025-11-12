using System;

namespace C_BasicExcercises.Exercises.Exercise51_60
{
    public class Exercise60
    {
        // Have a matrices and calculate the sum of all elements, except if there is a zero in the same row or column.
        public static void SumOfMatrixWithZeroCondition()
        {
            int[,] matrix =
            {
                {0, 2, 3, 2},
                {0, 6, 0, 1},
                {4, 0, 3, 2}
            };

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int sum = 0;

            // Sum elements column-wise, stopping at zeros
            for (int j = 0; j < cols; j++)
            {
                // Check each element in the column
                for (int i = 0; i < rows; i++)
                {
                    // If a zero is encountered, stop adding further down this column
                    if (matrix[i, j] == 0)
                        break; // Stop adding further down this column

                    sum += matrix[i, j];
                }
            }

            Console.WriteLine("Sum = " + sum);
        }

    }
}
