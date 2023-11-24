using System;
using System.IO;
using System.Collections.Generic;

class Task2
{
    static void Main()
    {
        string filePath = "numsTask2.txt";
        string line;

        List<string> results = new List<string>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            while ((line = reader.ReadLine()) != null)
            {
                if (line != null && line.Trim() != "")
                {
                    results.Add(line.Trim());
                }
            }
        }
        string finalResult = string.Join(" ", results);
        Console.WriteLine(finalResult);
    }
}