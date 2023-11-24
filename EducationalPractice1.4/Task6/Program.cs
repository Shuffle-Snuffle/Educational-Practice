using System;

class Task6
{
    static void Main()
    {
        Console.WriteLine("Input coordinate a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Input coordinate b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        bool isInside = IsPointInsideTriangle(a, b, 0, 2, 2, -3, -2, -3);
        bool isOnBoundary = IsPointOnTriangleBoundary(a, b, 0, 2, 2, -3, -2, -3);

        if (isInside)
        {
            Console.WriteLine($"Point ({a},{b}) is inside the shaded area");
        }
        else if (isOnBoundary)
        {
            Console.WriteLine($"Point ({a},{b}) is on the boundary of the shaded area");
        }
        else
        {
            Console.WriteLine($"Point ({a},{b}) is not inside the shaded area");
        }
    }

    static bool IsPointInsideTriangle(double x, double y, double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double vectorProduct1 = FindVectorsProduct(x, y, x1, y1, x2, y2);
        double vectorProduct2 = FindVectorsProduct(x, y, x2, y2, x3, y3);
        double vectorProduct3 = FindVectorsProduct(x, y, x3, y3, x1, y1);

        return (vectorProduct1 > 0 && vectorProduct2 > 0 && vectorProduct3 > 0) ||
               (vectorProduct1 < 0 && vectorProduct2 < 0 && vectorProduct3 < 0);
    }

    static bool IsPointOnTriangleBoundary(double x, double y, double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double vectorProduct1 = FindVectorsProduct(x, y, x1, y1, x2, y2);
        double vectorProduct2 = FindVectorsProduct(x, y, x2, y2, x3, y3);
        double vectorProduct3 = FindVectorsProduct(x, y, x3, y3, x1, y1);

        return (vectorProduct1 == 0 && IsPointOnLineSegment(x, y, x1, y1, x2, y2)) ||
               (vectorProduct2 == 0 && IsPointOnLineSegment(x, y, x2, y2, x3, y3)) ||
               (vectorProduct3 == 0 && IsPointOnLineSegment(x, y, x3, y3, x1, y1));
    }

    static bool IsPointOnLineSegment(double x, double y, double x1, double y1, double x2, double y2)
    {
        double minX = (x1 < x2) ? x1 : x2;
        double maxX = (x1 > x2) ? x1 : x2;
        double minY = (y1 < y2) ? y1 : y2;
        double maxY = (y1 > y2) ? y1 : y2;

        return (x >= minX && x <= maxX && y >= minY && y <= maxY);
    }

    static double FindVectorsProduct(double x, double y, double x1, double y1, double x2, double y2)
    {
        return (x - x1) * (y2 - y1) - (y - y1) * (x2 - x1);
    }
}