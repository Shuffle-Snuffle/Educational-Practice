using System;
using System.Collections.Generic;

class Task4
{
    static void Main()
    {
        Console.WriteLine("Input start of range: ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input end of range: ");
        int end = Convert.ToInt32(Console.ReadLine());
        if (end >= start)
        {
            int[] arrayOfNumbers = GenerateRandomArray(start, end);
            Console.WriteLine("Generated array of numbers without repeated digits");
            PrintArray(arrayOfNumbers);
        }
        else
        {
            Console.WriteLine("Invalid input");
            return;
        }
    }
    static int[] GenerateRandomArray(int start, int end)
    {
        Random randomizer = new Random();
        int range = (end + 1) - start;

        int[] array = new int[range];
        List<int> listOfNumbers = new List<int>(range);
        for (int i = 0; i < listOfNumbers.Capacity; i++)
        {
            int randomNumber = 0;
            bool isNotUniqueNumber = true;
            do
            {
                randomNumber = randomizer.Next(start, (end + 1));
                isNotUniqueNumber = false;
                for (int j = 0; j < listOfNumbers.Count; j++)
                {
                    if (listOfNumbers[j] == randomNumber)
                    {
                        isNotUniqueNumber = true;
                    }
                }
            }
            while (isNotUniqueNumber);
            listOfNumbers.Add(randomNumber);
        }
        for (int i = 0; i < listOfNumbers.Count; i++)
        {
            array[i] = listOfNumbers[i];
        }
        return array;
    }
    static void PrintArray(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}