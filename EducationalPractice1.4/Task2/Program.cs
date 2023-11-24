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
        string[] lineOfNumbers = textFile.Split((';'),StringSplitOptions.RemoveEmptyEntries);

        decimal[] numbers = new decimal[lineOfNumbers.Length];
        Console.WriteLine("Numbers from file: ");
        for (int i = 0; i < lineOfNumbers.Length; i++)
        {
            string numberCorrected = lineOfNumbers[i].Replace('.', ',');
            numbers[i] = Convert.ToDecimal(numberCorrected);
            Console.Write(numberCorrected + " ");
        }

        decimal sumOfPositiveElements = 0;
        Console.WriteLine("\n\nOnly positive numbers from file: ");
        foreach (decimal number in numbers)
        {
            if (number == 0)
            {
                break;
            }

            if (number > 0)
            {
                Console.Write(number + " ");
                sumOfPositiveElements += number;
            }
        }
        Console.WriteLine($"\n\nSum of positive numbers of the sequence is: {sumOfPositiveElements}");
    }
}