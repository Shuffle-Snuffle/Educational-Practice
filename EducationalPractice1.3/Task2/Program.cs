using System;
using System.Collections.Generic;
using System.IO;

class Task2
{
    static void Main()
    {
        string path = "nums.txt";
        List<int> oddNumbers = new List<int>();

        using (StreamReader reader = new StreamReader(path))
        {
            string[] textNumbers = reader.ReadToEnd().Split((' '), StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Numbers from file: ");
            for (int i = 0; i < textNumbers.Length; i++)
            {
                int number = Convert.ToInt32(textNumbers[i]);
                Console.Write(number + " ");
                if (number % 2 != 0)
                {
                    oddNumbers.Add(number);
                }
            }
        }

        Console.WriteLine("\nNumbers with only odd digits:");
        foreach (int number in oddNumbers)
        {
            Console.Write(number + " ");
        }

        using (StreamWriter writer = new StreamWriter(path))
        {
            foreach (int oddNumber in oddNumbers)
            {
                writer.Write(oddNumber + " ");
            }
        }
    }
}