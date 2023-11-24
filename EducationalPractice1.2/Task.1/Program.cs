using System;
class Task1
{
    static void Main()
    {
        int[] numbers = new int[100];
        int currentNumber = 300;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = currentNumber;
            currentNumber = currentNumber - 3;
        }

        int count = 0;
        Console.WriteLine("Array of size 100, with numbers in descending order, each number less than the previous one by 3:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + "\t");
            count++;
            if (count % 10 == 0)
            {
                Console.WriteLine();
            }
        }
    }
}