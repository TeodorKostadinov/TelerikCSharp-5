﻿using System;

class Program
{
    static double GetAreaWithAltitude(double a, double h)
    {
        return (a * h) / 2;
    }

    static double GetAreaWithHeron(double a, double b, double c)
    {
        double p = (a + b + c) / 2;

        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }


    static double GetAreaWithAngle(double a, double b, double alpha)
    {
        return (a * b * Math.Sin(Math.PI * alpha / 180)) / 2;
    }

    static void Main()
    {
        Console.WriteLine(GetAreaWithAltitude(a: 3, h: 4));
        Console.WriteLine(GetAreaWithHeron(a: 3, b: 4, c: 5));
        Console.WriteLine(GetAreaWithAngle(a: 3, b: 4, alpha: 90));
    }
}