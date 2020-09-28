using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}

public class Triangle
{

    private double angleA;
    private double angleB;
    private double angleC;

    public Triangle()
    {
        angleA = 30;
        angleB = 60;
        angleC = 90;
    }
    public double thirdAngles(double angleA, double angleB)
    {
        return 180 - angleA - angleB;
    }

    public double area(double sideA, double sideB)
    {
        return sideA * sideB * 0.5;
    }

    public double GetAngleA()
    {
        return angleA;
    }

    public double GetAngleB()
    {
        return angleB;
    }

    public string GetType()
    {
        if (Math.Max(angleA, angleB) > 90 || angleC > 90)
        {
            return "Obtuse triangle";
        }
        else if (Math.Max(angleA,angleB) < 90|| angleC < 90)
        {
            return "Acute triangle";
        }
        else
        {
            return "Right triangle";
        }

    }
}
