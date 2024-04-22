using System;
using ConsoleApp1.Services;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int targetNumber = 5;
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            bool numberFound = false;

            // Loop through the matrix to find the target number
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == targetNumber)
                    {
                        numberFound = true;
                        goto
                        Found;
                    }
                }
            }

            // If the number is not found, execute this block
            if (!numberFound)
            {
                Console.WriteLine("The target number was not found.");
            }

        // This label marks the end of the loop
        Found:
            Console.WriteLine("The target number was found.");
        }
    }
}

