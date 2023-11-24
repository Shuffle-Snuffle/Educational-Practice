using System;

class Task1
{
    static void Main()
    {
        Console.WriteLine("Input a positive integer n:");
        double n = Convert.ToDouble(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Invalid input");
            return;
        }
        else if (n == 3 || n == 2 || n == 1)
        {
            Console.WriteLine("There are no numbers up to {0} that are multiples of three and do not exceed {0}", n);
            return;
        }
        double multiplication = 1;
        for (int i = 3; i < n; i += 3)
        {
            multiplication *= i;
        }

        Console.WriteLine($"The multiplication of natural numbers that are multiples of three and do not exceed {n} is {multiplication}");
    }
}