using System;

class Task3
{
    static void Main()
    {
        Console.Write("Input your number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0 && number % 10 == 0)
        {
            Console.WriteLine($"The number {number} is even and multiple of 10");
        }
        else
        {
            Console.WriteLine($"The number {number} is not even and multiple of 10");
        }
    }
}