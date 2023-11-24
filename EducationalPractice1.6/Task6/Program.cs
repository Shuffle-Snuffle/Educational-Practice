using System;

class Task6
{
    static void Main()
    {
        Random randomizer = new Random();
        int arraySize = randomizer.Next(5, 11);
        double[] originalArray = new double[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            originalArray[i] = randomizer.NextDouble() * (randomizer.Next(0, 2) == 0 ? -1 : 1);
        }

        int positiveCount = 0;
        int negativeCount = 0;

        for (int i = 0; i < arraySize; i++)
        {
            if (originalArray[i] > 0)
            {
                positiveCount++;
            }

            if (originalArray[i] < 0)
            {
                negativeCount++;
            }
        }

        double[] positiveArray = new double[positiveCount];
        double[] negativeArray = new double[negativeCount];
        int positiveNumberIndex = 0;
        int negativeNumberIndex = 0;

        foreach (double number in originalArray)
        {
            if (number >= 0)
            {
                positiveArray[positiveNumberIndex] = number;
                positiveNumberIndex++;
            }
            else if (number < 0)
            {
                negativeArray[negativeNumberIndex] = number;
                negativeNumberIndex++;
            }
        }
        Console.WriteLine("Original array:");
        PrintArray(originalArray);
        Console.WriteLine("\nArray with positive elements:");
        PrintArray(positiveArray);
        Console.WriteLine("\nArray with negative elements:");
        PrintArray(negativeArray);
    }

    static void PrintArray(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}