using System;
class Task2
{
    static void Main()
    {
        Console.WriteLine("Input quantity of numbers: ");
        int N = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[N];
        int a = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = a + i;
            a = a + 1;
        }

        Console.WriteLine("Array with consecutive odd numbers starting with 1:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    }
}