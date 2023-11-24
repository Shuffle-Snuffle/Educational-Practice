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
        string[] lineOfNumbers = textFile.Split((' '), StringSplitOptions.RemoveEmptyEntries);

        int[] numbers = new int[lineOfNumbers.Length];
        Console.WriteLine("Numbers from file: ");
        for (int i = 0; i < lineOfNumbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(lineOfNumbers[i]);
            Console.Write(numbers[i] + " ");
        }

        int count = 0;
        int currentCoincidence = 1;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                currentCoincidence++;
            }
            else if (currentCoincidence > 1)
            {
                count += currentCoincidence;
                currentCoincidence = 1;
            }
        }
        if (currentCoincidence > 1)
        {
            count += currentCoincidence;
        }
        Console.WriteLine("\n\nQuantity of identical adjacent numbers is: " + count);
    }
}