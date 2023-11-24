using System;

class Task4
{
    static void Main()
    {
        int[,] temperature = new int[12, 30];
        Random randomTemperature = new Random();
        int count = 0;

        Console.WriteLine("Array of the temperatures:");
        for (int i = 0; i < temperature.GetLength(0); i++)
        {
            Console.Write($"Month №{i + 1}:" + " ");
            for (int j = 0; j < temperature.GetLength(1); j++)
            {
                temperature[i, j] = randomTemperature.Next(23, 33);
                Console.Write(temperature[i, j] + " ");
                count++;

                if (count % 30 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
        Console.WriteLine();
        double[] averageTemperatures = CalculateAverageTemperatures(temperature);

        for (int i = 0; i < averageTemperatures.Length; i++)
        {
            Console.WriteLine($"Month number №{i + 1} average temperature: " + averageTemperatures[i]);
        }

        double[] averageTemperaturesSorted = new double[averageTemperatures.Length];
        for (int i = 0; i < averageTemperatures.Length; i++)
        {
            averageTemperaturesSorted[i] = averageTemperatures[i];
        }

        for (int i = 0; i < averageTemperaturesSorted.Length - 1; i++)
        {
            for (int j = 0; j < averageTemperaturesSorted.Length - i - 1; j++)
            {
                if (averageTemperaturesSorted[j] > averageTemperaturesSorted[j + 1])
                {
                    double temp = averageTemperaturesSorted[j];
                    averageTemperaturesSorted[j] = averageTemperaturesSorted[j + 1];
                    averageTemperaturesSorted[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("\nAverage temperatures sorted in ascending order:");
        for (int i = 0; i < averageTemperaturesSorted.Length; i++)
        {
            Console.WriteLine(averageTemperaturesSorted[i]);
        }
    }

    static double[] CalculateAverageTemperatures(int[,] temperature)
    {
        double[] averageTemperatures = new double[temperature.GetLength(0)];
        for (int i = 0; i < temperature.GetLength(0); i++)
        {
            double sum = 0;
            for (int j = 0; j < temperature.GetLength(1); j++)
            {
                sum += temperature[i, j];
            }
            averageTemperatures[i] = sum / temperature.GetLength(1);
        }
        return averageTemperatures;
    }
}