using System;
using System.Collections.Generic;

class Task3
{
    static void Main()
    {
        Console.WriteLine("Input lines by one for adding (to stop adding lines, input empty string): ");
        List<string> lines = new List<string>();

        bool isLineNotEmpty = true;

        while (isLineNotEmpty)
        {
            string input = Console.ReadLine();
            input = input.Trim();

            if (input == "")
            {
                isLineNotEmpty = false;
            }
            else
            {
                lines.Add(input);
            }
        }

        if (lines.Count > 0)
        {
            string shortestLine = lines[0];
            string longestLine = lines[0];
            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].Length < shortestLine.Length)
                {
                    shortestLine = lines[i];
                }
                if (lines[i].Length > longestLine.Length)
                {
                    longestLine = lines[i];
                }
            }
            Console.WriteLine("Shortest line is: " + shortestLine);
            Console.WriteLine("Longest line is: " + longestLine);
        }
        else
        {
            Console.WriteLine("There are no lines added");
        }
    }
}