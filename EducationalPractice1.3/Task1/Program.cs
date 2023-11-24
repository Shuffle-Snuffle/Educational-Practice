using System;
using System.Collections.Generic;
using System.IO;

class Task1
{
    static void Main()
    {
        string inputPath = "input.txt";
        string outputPath = "output.txt";
        List<string> lines = new List<string>();
        using (StreamReader reader = new StreamReader(inputPath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }
        }

        string[] winNumbers = lines[0].Split((' '),StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Winning numbers are:");
        foreach (string winNumber in winNumbers)
        {
            Console.Write(winNumber + " ");
        }

        int numberOfTickets = Convert.ToInt32(lines[1]);
        Console.WriteLine("\n\nNumber of tickets: " + numberOfTickets);

        List<string> results = new List<string>();
        Console.WriteLine("\nParticipants tickets:");
        for (int i = 2; i < lines.Count; i++)
        {
            Console.WriteLine(lines[i]);
        }
        for (int i = 0; i < numberOfTickets; i++)
        {
            string[] ticketNumbers = lines[i + 2].Split((' '), StringSplitOptions.RemoveEmptyEntries);

            int count = 0;
            for (int j = 0; j < ticketNumbers.Length; j++)
            {
                for (int k = 0; k < winNumbers.Length; k++)
                {
                    if (ticketNumbers[j] == winNumbers[k])
                    {
                        count++;
                        break;
                    }
                }
            }

            if (count >= 3)
            {
                results.Add("Lucky");
            }
            else
            {
                results.Add("Unlucky");
            }
        }
        Console.WriteLine("\nTickets verification results:");
        for (int i = 0; i < results.Count; i++)
        {
            Console.WriteLine(results[i]);
        }

        using (StreamWriter writer = new StreamWriter(outputPath))
        {
            for (int i = 0; i < results.Count; i++)
            {
                writer.WriteLine(results[i]);
            }
        }
    }
}