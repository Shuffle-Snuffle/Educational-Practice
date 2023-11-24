using System;
using System.Collections.Generic;

class Task2
{
    static void Main()
    {
        Console.WriteLine("Input numbers by one for adding (to stop adding numbers, input zero): ");
        List<double> numbers = new List<double>();

        double userInput = 0;
        bool isInputNotZero = true;
        while (isInputNotZero)
        {
            userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 0)
            {
                isInputNotZero = false;
            }
            else
            {
                numbers.Add(userInput);
            }
        }

        double sum = 0;
        double multiplication = 1;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
            multiplication *= numbers[i];
        }

        if (sum == 0)
        {
            Console.WriteLine("There are no elements added");
        }
        else
        {
            Console.WriteLine("Added numbers:");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            double average = sum / numbers.Count;
            Console.WriteLine($"\nArithmetic mean of elements is: {average}");
            Console.WriteLine($"\nSum of elements is: {sum}");
            Console.WriteLine($"\nMultiplication of elements is: {multiplication}");
        }
    }
}