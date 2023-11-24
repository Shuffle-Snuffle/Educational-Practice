using System;

class Task1
{
    static void Main()
    {
        int[] numbers = new int[10];
        Random randomizer = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            int randomNumber = 0;
            bool isNotUniqueNumber = true;
            do
            {
                randomNumber = randomizer.Next(1, 11);
                isNotUniqueNumber = false;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] == randomNumber)
                    {
                        isNotUniqueNumber = true;
                    }
                }
            }
            while (isNotUniqueNumber);
            numbers[i] = randomNumber;
        }

        int minimumNumber = numbers[0];
        int minimumIndex = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < minimumNumber)
            {
                minimumNumber = numbers[i];
                minimumIndex = i;
            }
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{numbers[i]} ");
        }

        Console.WriteLine($"\nMinimum number is {minimumNumber} under the index number: {minimumIndex}");
    }
}