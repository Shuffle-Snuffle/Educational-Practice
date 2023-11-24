using System;

class Task5
{
    static void Main()
    {
        Console.Write("Input coordinate a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Input coordinate b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        if (-1 <= a && a <= 3 && -2 <= b && b <= 4)
        {
            Console.WriteLine($"Point ({a},{b}) is inside the shaded area");
        }
        else
        {
            Console.WriteLine($"Point ({a},{b}) is not inside the shaded area");
        }
    }
}