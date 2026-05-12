using System;
using System.Collections.Generic;
using System.Text;

namespace Statisch;

class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public static bool operator== (Point a, Point b)
    {
        return (a.X == b.X && a.Y == b.Y);
    }
    public static bool operator !=(Point a, Point b)
    {
        return !(a == b);
    }

    public static explicit operator double(Point p)
    {
        return Math.Sqrt(p.X * p.X + p.Y * p.Y);
    }
    //public static implicit operator double(Point p)
    //{
    //    return Math.Sqrt(p.X * p.X + p.Y * p.Y);
    //}

    public static Point operator+(Point a, Point b)
    {
        return new Point { X = a.X+b.X, Y= a.Y+b.Y };
    }
    public void Display()
    {
        Console.WriteLine($"({X}, {Y})");
    }
}
