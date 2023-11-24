using System;
using System.IO;

class Task3
{
    static void Main()
    {
        string path = "numsTask3.txt";
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

        int minimumNumber = numbers[0];
        int minimumNumberIndex = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (minimumNumber > numbers[i])
            {
                minimumNumber = numbers[i];
                minimumNumberIndex = i;
            }
        }
        Console.WriteLine("\n\nMinimum number is: " + minimumNumber);
        Console.WriteLine("\nMinimum number index is: " + minimumNumberIndex);

        double sum = 0;
        double average = 0;
        if (minimumNumberIndex == 0)
        {
            Console.WriteLine("\nNo elements before the minimum");
        }
        else
        {
            for (int i = 0; i < minimumNumberIndex; i++)
            {
                sum += numbers[i];
            }
            average = sum / minimumNumberIndex;

            Console.WriteLine("\nArithmetic mean of elements located before the minimum: " + average);
        }
    }
}