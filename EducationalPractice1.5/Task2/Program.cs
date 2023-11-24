using System;
using System.IO;

class Task2
{
    static void Main()
    {
        string path = "numsTask2.txt";
        string textFile;

        using (StreamReader reader = new StreamReader(path))
        {
            textFile = reader.ReadToEnd();
        }

        string[] lineOfNumbers = textFile.Split((";"), StringSplitOptions.RemoveEmptyEntries);
        double[] numbers = new double[lineOfNumbers.Length];

        Console.WriteLine("Numbers from file: ");
        for (int i = 0; i < lineOfNumbers.Length; i++)
        {
            string numberCorrected = lineOfNumbers[i].Replace('.', ',');
            lineOfNumbers[i] = numberCorrected;
            numbers[i] = Convert.ToDouble(lineOfNumbers[i]);
            Console.Write(numbers[i] + " ");
        }

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = 0; j < numbers.Length - i - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    double temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\n\nSorted numbers: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }

        using (StreamWriter writer = new StreamWriter(path, true))
        {
            writer.WriteLine("\n\nSorted numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                writer.Write(numbers[i] + " ");
            }
            Console.WriteLine("\nNumbers written to file");
        }
    }
}