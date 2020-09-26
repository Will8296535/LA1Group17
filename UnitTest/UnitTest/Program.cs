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
    public double thirdAngles(double angleA, double angleB)
    {
        return 180 - angleA - angleB;
    }

    public double area(double sideA, double sideB)
    {
        return sideA * sideB * 0.5;
    }
}
