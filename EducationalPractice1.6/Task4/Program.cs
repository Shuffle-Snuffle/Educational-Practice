using System;

class Task4
{
    static void Main()
    {
        Console.WriteLine("Input positive number a:");
        int a = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        while (true)
        {
            Console.WriteLine("Input number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number <= 0)
            {
                break;
            }

            if (number % a == 0)
            {
                sum += number;
            }
        }
        Console.WriteLine("Sum of numbers divisible by {0} a whole: {1} ", a, sum);
    }
}
