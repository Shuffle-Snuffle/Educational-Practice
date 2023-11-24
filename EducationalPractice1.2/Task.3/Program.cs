using System;

class Task3
{
    static void Main()
    {
        Console.WriteLine("Input number of size of square matrix: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            matrix[0, i] = 1;
            matrix[i, 0] = 1;
        }

        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j < n; j++)
            {
                matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
            }
        }

        Console.WriteLine("Result matrix is:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}