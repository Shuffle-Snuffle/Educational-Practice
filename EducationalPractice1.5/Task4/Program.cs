using System;
using System.IO;

class Task4
{
    static void Main()
    {
        string path = "numsTask4.txt";
        string textFile;

        using (StreamReader reader = new StreamReader(path))
        {
            textFile = reader.ReadToEnd();
        }

        string[] lineOfNumbers = textFile.Split((","), StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[lineOfNumbers.Length];

        Console.WriteLine("Numbers from file: ");
        for (int i = 0; i < lineOfNumbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(lineOfNumbers[i]);
            Console.Write(numbers[i] + " ");
        }

        int maximumNumber = numbers[0];
        int maximumNumberIndex = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (maximumNumber < numbers[i])
            {
                maximumNumber = numbers[i];
                maximumNumberIndex = i;
            }
        }
        Console.WriteLine("\n\nMaximum number is: " + maximumNumber);
        Console.WriteLine("\nMaximum number index is: " + maximumNumberIndex);

        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == maximumNumber - 1 || numbers[i] == maximumNumber + 1)
            {
                sum += numbers[i];
            }
        }
        Console.WriteLine("\nSum of numbers differing from the maximum by 1: " + sum);
    }
}