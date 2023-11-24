using System;
using System.Collections.Generic;
class Task5
{
    static void Main()
    {
        Dictionary<string, int[]> temperature = GenerateTemperatureData();
        Dictionary<string, double> averageTemperatures = CalculateAverageTemperatures(temperature);
        foreach (var data in averageTemperatures)
        {
            Console.WriteLine($"Average temperature for {data.Key}: {data.Value}");
        }

        List<KeyValuePair<string, double>> tempPairs = new List<KeyValuePair<string, double>>(averageTemperatures);

        for (int i = 0; i < tempPairs.Count - 1; i++)
        {
            for (int j = 0; j < tempPairs.Count - i - 1; j++)
            {
                if (tempPairs[j].Value > tempPairs[j + 1].Value)
                {
                    var temp = tempPairs[j];
                    tempPairs[j] = tempPairs[j + 1];
                    tempPairs[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\n\nSorted average temperatures:");
        foreach (var pair in tempPairs)
        {
            Console.WriteLine($"Average temperature for {pair.Key}: {pair.Value}");
        }
    }
    static Dictionary<string, int[]> GenerateTemperatureData()
    {
        Random randomizer = new Random();
        Dictionary<string, int[]> temperature = new Dictionary<string, int[]>();

        string[] months = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
        foreach (string month in months)
        {
            int[] monthTemperature = new int[30];
            for (int i = 0; i < 30; i++)
            {
                monthTemperature[i] = randomizer.Next(25, 33);
            }
            temperature[month] = monthTemperature;
        }
        return temperature;
    }

    static Dictionary<string, double> CalculateAverageTemperatures(Dictionary<string, int[]> temperatureData)
    {
        Dictionary<string, double> averageTemperatures = new Dictionary<string, double>();
        foreach (var data in temperatureData)
        {
            string month = data.Key;
            int[] dailyTemperatures = data.Value;

            double sum = 0;
            foreach (int temperature in dailyTemperatures)
            {
                sum += temperature;
            }
            double averageTemperature = sum / dailyTemperatures.Length;
            averageTemperatures[month] = averageTemperature;
        }
        return averageTemperatures;
    }
}