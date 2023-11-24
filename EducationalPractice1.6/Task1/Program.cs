using System;
using System.IO;

class Task1
{
    static void Main()
    {
        string path = "numsTask1.txt";
        string textFile;

        using(StreamReader reader = new StreamReader(path))
        {
            textFile = reader.ReadToEnd();
        }

        string[] words = textFile.Split((","), StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("Words from file: ");
        for (int i = 0; i < words.Length; i++)
        {
            Console.Write(words[i] + " ");
        }

        Console.WriteLine("\n\nWords of odd length:");
        foreach (string word in words)
        {
            string trimmedWord = word.Trim();
            if (trimmedWord.Length % 2 != 0)
            {
                Console.Write(trimmedWord + " ");
            }
        }
    }   
}