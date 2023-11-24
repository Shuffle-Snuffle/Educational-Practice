using System;

class Task5
{
    static void Main(
        )
    {
        Console.Write("Input quantity of rows: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input quantity of columns: ");
        int m = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[n, m];
        Console.WriteLine("Input elemens of matrix (0 or 1):");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                bool invalidInput = true;
                while (invalidInput)
                {
                    Console.WriteLine("Input number 0 or 1:");
                    string input = Console.ReadLine();

                    if (input == "0" || input == "1")
                    {
                        matrix[i, j] = Convert.ToInt32(input);
                        invalidInput = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Input number 0 or 1.");
                    }
                }
            }
        }

        int[,] newMatrix = new int[n, m + 1];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                newMatrix[i, j] = matrix[i, j];
            }
        }

        for (int i = 0; i < n; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < m; j++)
            {
                rowSum += matrix[i, j];
            }
            newMatrix[i, m] = (rowSum % 2 == 0) ? 0 : 1;
        }

        Console.WriteLine("\nOriginal matrix:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nNew matrix with additional column:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= m; j++)
            {
                Console.Write(newMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}