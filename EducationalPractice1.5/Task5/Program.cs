using System;
using System.IO;

class Task5
{
    static void Main()
    {
        string path = "numsTask5.txt";

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
        int maximumNumber = numbers[0];
        int minimumNumberIndex = 0;
        int maximumNumberIndex = 0;
        for (int i = 0;i < numbers.Length; i++)
        {
            if (numbers[i] < minimumNumber)
            {
                minimumNumber = numbers[i];
                minimumNumberIndex = i;
            }

            if (numbers[i] > maximumNumber)
            {
                maximumNumber = numbers[i];
                maximumNumberIndex = i;
            }
        }
        Console.WriteLine("\n\nMinimum number is: " + minimumNumber);
        Console.WriteLine("Minimum number index is: " + minimumNumberIndex);

        Console.WriteLine("\nMaximum number is: " + maximumNumber);
        Console.WriteLine("Maximum number index is: " + maximumNumberIndex);

        int start = (minimumNumberIndex < maximumNumberIndex) ? minimumNumberIndex : maximumNumberIndex;
        int end = (maximumNumberIndex > minimumNumberIndex) ? maximumNumberIndex : minimumNumberIndex;

        double sum = 0;
        double count = 0;
        for(int i = 0; i < numbers.Length; i++)
        {
            if(i > start && i < end)
            {
                sum += numbers[i];
                count++;
            }
        }
        if (count != 0)
        {
            double average = sum / count;
            Console.WriteLine("\nArithmetic mean of elements located between the minimum and maximum is: " + average);
        }
        else
        {
            Console.WriteLine("\nThere are no elements between maximum and minimum numbers");
        }
    }
}