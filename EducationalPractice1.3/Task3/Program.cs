using System;
using System.IO;

class Task3
{
    static void Main()
    {
        string path = "nums.txt";
        string line;
        using (StreamReader reader = new StreamReader(path))
        {
            line = reader.ReadLine();
        }
        Console.WriteLine("Input:" + line);
        string[] numbersAsString = line.Split((' '), StringSplitOptions.RemoveEmptyEntries);
        int i = numbersAsString.Length;
        Console.WriteLine("Quantity of numbers: " + i);

        int[] height = new int[i];
        for (int j = 0; j < i; j++)
        {
            height[j] = Convert.ToInt32(numbersAsString[j]);
        }

        int maxWater = MaxArea(height);
        Console.WriteLine("\nMaximum water is: " + maxWater);
    }

    static int MaxArea(int[] height)
    {
        int maxArea = 0;
        int left = 0;
        int right = height.Length - 1;

        while (left < right)
        {
            int h = (height[left] < height[right]) ? height[left] : height[right];
            int w = right - left;
            int area = h * w;

            maxArea = (maxArea > area) ? maxArea : area;

            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return maxArea;
    }
}