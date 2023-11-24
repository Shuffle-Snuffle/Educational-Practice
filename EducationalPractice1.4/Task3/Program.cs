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
        string[] lineOfNumbers = textFile.Split((','), StringSplitOptions.RemoveEmptyEntries);

        int[] numbers = new int[lineOfNumbers.Length];

        Console.WriteLine("Numbers from file: ");
        for (int i = 0; i < lineOfNumbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(lineOfNumbers[i]);
            Console.Write(numbers[i] + " ");
        }

        decimal maximumNumber = numbers[0];
        decimal minimumNumber = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] != 0)
            {
                if (maximumNumber < numbers[i])
                {
                    maximumNumber = numbers[i];
                }

                if (minimumNumber > numbers[i])
                {
                    minimumNumber = numbers[i];
                }
            }
            else
            {
                break;
            }
        }
        Console.WriteLine("\n\nMinimum number is: " + minimumNumber);
        Console.WriteLine("\nMaximum number is: " + maximumNumber);

        decimal ratio = minimumNumber / maximumNumber;
        Console.WriteLine($"\nRatio of minimum and maximum number is: {ratio}");
    }
}