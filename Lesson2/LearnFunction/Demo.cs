using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnFunction
{
    internal class Demo
    {
        public double CalculateSRec(double width, double length)
        {
            var area = width * length;
            return area;
        }

        public double CaculateSCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        public double _average(double a, double b, double c)
        {
            var average = (a + b + c) / 3;
            return average;
        }

        public double CalculateSRec1(double width, double length, out double p)
        {
            var area = width * length;
            p = 2 * (width + length);
            return area;
        }

        public void ChangeValue(int value)
        {
            value += 10;
        }
        public void ChangeValue1(ref int value)
        {
            value += 10;
        }
    }
}
