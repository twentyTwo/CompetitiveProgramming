using System;
using System.Linq;
using System.Runtime.InteropServices;

class Test
{
    static void Main(string[] args)
    {
        /*
         if x is a odd number then f(x) = (-1) * ( 2 ^ x ) , 
         Otherwise f(x) = 2 ^ x . 
         */

        var N = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var a = TraverseSpiral(N[0], N[0]);

        for (int i = 1; i <= N[1]; i++)
        {
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}, {1}", a[p]._y + 1, a[p]._x + 1);

        }

    }


    private static Point[] TraverseSpiral(int width, int height)
    {
        int numElements = width * height + 1;
        Point[] points = new Point[numElements];

        int x = 0;
        int y = 0;
        int dx = 1;
        int dy = 0;
        int xLimit = width - 0;
        int yLimit = height - 1;
        int counter = 0;

        int currentLength = 1;
        while (counter < numElements)
        {
            points[counter] = new Point(x, y);

            x += dx;
            y += dy;

            currentLength++;
            if (dx > 0)
            {
                if (currentLength >= xLimit)
                {
                    dx = 0;
                    dy = 1;
                    xLimit--;
                    currentLength = 0;
                }
            }
            else if (dy > 0)
            {
                if (currentLength >= yLimit)
                {
                    dx = -1;
                    dy = 0;
                    yLimit--;
                    currentLength = 0;
                }
            }
            else if (dx < 0)
            {
                if (currentLength >= xLimit)
                {
                    dx = 0;
                    dy = -1;
                    xLimit--;
                    currentLength = 0;
                }
            }
            else if (dy < 0)
            {
                if (currentLength >= yLimit)
                {
                    dx = 1;
                    dy = 0;
                    yLimit--;
                    currentLength = 0;
                }
            }

            counter++;
        }

        Array.Reverse(points);
        return points;
    }

}

public class Point
{
    public int _x;

    public int _y;
    public Point(int x, int y)
    {
        _x = x;
        _y = y;
    }


}



