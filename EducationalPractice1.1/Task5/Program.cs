using System;
class Task5
{
    static void Main()
    {
        Console.WriteLine("Input line:");
        string input = Console.ReadLine();

        char[] wordsSeparators = { ' ', ',', '.', ';', '!', '?', '-' };
        input = input.Replace("-", "");
        string[] words = input.Split(wordsSeparators, StringSplitOptions.RemoveEmptyEntries);
        int wordCount = words.Length;

        string changedLine = "Start" + input + "End";

        Console.WriteLine($"Quantity of words is: {wordCount}");
        Console.WriteLine($"Changed line is: {changedLine}");
    }
}