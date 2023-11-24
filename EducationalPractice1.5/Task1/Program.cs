using System;
using System.IO;

class Task1
{
    static void Main()
    {
        string path = "numsTask1.txt";
        string textFile;

        using (StreamReader reader = new StreamReader(path))
        {
            textFile = reader.ReadToEnd();
        }

        string[] lineOfNumbers = textFile.Split((","),StringSplitOptions.RemoveEmptyEntries);
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

        double multiplication = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i > minimumNumberIndex)
            {
                multiplication *= numbers[i]; 
            }
        }

        if (minimumNumberIndex == numbers.Length - 1)
        {
            Console.WriteLine("\nNo elements found after the minimum number.");
        }
        else
        {
            Console.WriteLine("\nProduct of elements located after the minimum is: " + multiplication);
        }
    }
}