using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ConsoleApp2_9
{
    
    public class Calculator : ICalculator
    {
        public void DoWork()
        {
        }
        public double CalculateMethod1(double x, double y)
        {
            return 2 * (5 * x + 6 * y) / 5;
        }

        public double CalculateMethod2(double x, double y)
        {
            return (3 * Math.Sin(x) + 8 * Math.Cos(y)) / 2;
        }
    }
}
